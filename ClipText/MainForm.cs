// <copyright file="MainForm.cs" company="PublicDomain.is">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace ClipText
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using System.Xml.Serialization;
    using PublicDomain;
    using WK.Libraries.SharpClipboardNS;
    using static WK.Libraries.SharpClipboardNS.SharpClipboard;

    /// <summary>
    /// Main form.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The clipboard.
        /// </summary>
        SharpClipboard clipboard = new SharpClipboard();

        /// <summary>
        /// The add new line flag.
        /// </summary>
        bool? addNewLine = null;

        /// <summary>
        /// The captures.
        /// </summary>
        int captures = 0;

        /// <summary>
        /// Gets or sets the associated icon.
        /// </summary>
        /// <value>The associated icon.</value>
        private Icon associatedIcon = null;

        /// <summary>
        /// The settings data.
        /// </summary>
        private SettingsData settingsData = null;

        /// <summary>
        /// The settings data path.
        /// </summary>
        private string settingsDataPath = $"{Application.ProductName}-SettingsData.txt";


        /// <summary>
        /// Initializes a new instance of the <see cref="T:ClipText.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();

            // TODO Set accept button [Can be done via designer]
            this.AcceptButton = this.startStopButton;

            // TODO Only do text [Check removing e.ContentType comparison]
            this.clipboard.ObservableFormats.Texts = true;
            this.clipboard.ObservableFormats.Files = false;
            this.clipboard.ObservableFormats.Images = false;
            this.clipboard.ObservableFormats.Others = false;

            /* Settings data */

            // HACK Flag for options
            bool setDefaultOptions = false;

            // Check for settings file
            if (!File.Exists(this.settingsDataPath))
            {
                // Create new settings file
                this.SaveSettingsFile(this.settingsDataPath, new SettingsData());

                // Toggle flag
                setDefaultOptions = true;
            }

            // Load settings from disk
            this.settingsData = this.LoadSettingsFile(this.settingsDataPath);

            // Check if must set default options
            if (setDefaultOptions)
            {
                // Set default options
                this.settingsData.CheckedOptionsList = new List<string>() { "rememberTextFileToolStripMenuItem" };
            }
        }

        /// <summary>
        /// Handles the clipboard changed event
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnClipboardChanged(Object sender, ClipboardChangedEventArgs e)
        {
            // TODO Check for text [Can improve, see above]
            if (e.ContentType == SharpClipboard.ContentTypes.Text)
            {
                try
                {
                    // Append current clipboard text
                    File.AppendAllText(this.targetFileTextBox.Text, $"{(this.addNewLine != false ? Environment.NewLine : string.Empty)}{clipboard.ClipboardText}");

                    // TODO If new line flag is not null [Can be improved]; it already did the job yet may be implemented differently]
                    if (this.addNewLine != null)
                    {
                        // Set it to null
                        this.addNewLine = null;
                    }

                    // Raise
                    this.RaiseCaptures();
                }
                catch (Exception ex)
                {
                    // Write to error log
                    File.AppendAllText("ClipText_ErrorLog.txt", $"{Environment.NewLine}Error when appending to \"{this.targetFileTextBox.Text}\". Message: {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Raises the captures.
        /// </summary>
        private void RaiseCaptures()
        {
            // Raise
            this.captures++;

            // Update in GUI
            this.capturesToolStripStatusLabel.Text = this.captures.ToString();
        }

        /// <summary>
        /// Resets the captures.
        /// </summary>
        private void ResetCaptures()
        {
            // Reset 
            this.captures = 0;

            // Update in GUI
            this.capturesToolStripStatusLabel.Text = this.captures.ToString();
        }

        /// <summary>
        /// Handles the start stop button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnStartStopButtonClick(object sender, EventArgs e)
        {
            // Check for star(t)
            if (this.startStopButton.Text.EndsWith("t", StringComparison.InvariantCulture))
            {
                // First check there's a file
                if (this.targetFileTextBox.TextLength == 0)
                {
                    // Advise user
                    MessageBox.Show("Please set target text file.", "Empty text file", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Halt flow
                    return;
                }

                // Check if must add new line
                if (this.addNewLine == null)
                {
                    try
                    {
                        // Check if file doesn't exist
                        if (!File.Exists(this.targetFileTextBox.Text))
                        {
                            // No previous file hence no need to prepend a new line
                            this.addNewLine = false;
                        }
                        else
                        {
                            // TODO Set according to file end [Read only the last few bytes instead of all text]
                            this.addNewLine = !File.ReadAllText(this.targetFileTextBox.Text).EndsWith(Environment.NewLine, StringComparison.CurrentCulture);
                        }
                    }
                    catch (Exception ex)
                    {
                        // TODO There was an error, assume no new line [User can be advised, flow can be halted]
                        this.addNewLine = true;
                    }
                }

                // Subscribe 
                this.clipboard.ClipboardChanged += OnClipboardChanged;

                // Update button text
                this.startStopButton.Text = "&Stop";

                // Update button icon
                this.startStopButton.ImageIndex = 1;

                // Disable text box
                this.targetFileTextBox.Enabled = false;
            }
            else
            {
                // Unsubscribe 
                this.clipboard.ClipboardChanged -= OnClipboardChanged;

                // Null new line flag
                this.addNewLine = null;

                // Update button text
                this.startStopButton.Text = "&Start";

                // Update button icon
                this.startStopButton.ImageIndex = 0;

                // Enable text box
                this.targetFileTextBox.Enabled = true;
            }
        }

        /// <summary>
        /// Handles the new tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Collect dialog result from user
            DialogResult userDialogResult = MessageBox.Show($"Backup target text file to start afresh?{Environment.NewLine}{Environment.NewLine}YES = Copy current to backup file.{Environment.NewLine}NO = Overwrite resetting contents.{Environment.NewLine}Cancel = Discard \"File.New\" operation.", "Backup on File/New", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

            // Halt flow on cancel
            if (userDialogResult == DialogResult.Cancel)
            {
                // Halt flow
                return;
            }

            // Get absolute path for source
            string sourceFilePath = Path.GetFullPath(this.targetFileTextBox.Text);

            // Backup 
            if (userDialogResult == DialogResult.Yes)
            {
                try
                {
                    // Set path for backup
                    string backupFilePath = Path.Combine(Path.GetDirectoryName(sourceFilePath), String.Concat(Path.GetFileNameWithoutExtension(sourceFilePath), $"-{(int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds}", Path.GetExtension(sourceFilePath)));

                    // Backup file with epoch
                    File.Copy(sourceFilePath, backupFilePath);

                    // Delete source file
                    File.Delete(sourceFilePath);

                    // TODO No previous file hence no need to prepend a new line [DRY, accuonting for catch]
                    this.addNewLine = false;

                    // TODO Reset [DRY, accuonting for catch]
                    this.ResetCaptures();
                }
                catch (Exception ex)
                {
                    // Set error message
                    string errorMessage = $"Error when backing up to \"{sourceFilePath}\". Message: {ex.Message}";

                    // Write to error log
                    File.AppendAllText("ClipText_ErrorLog.txt", $"{Environment.NewLine}errorMessage");

                    // Advise user
                    MessageBox.Show($"{errorMessage}{Environment.NewLine}{Environment.NewLine}File/New operation cancelled.", "File/New error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Halt flow
                    return;
                }
            }
            else
            {
                try
                {
                    // No backup, simply delete file
                    File.Delete(sourceFilePath);

                    // TODO No previous file hence no need to prepend a new line [DRY, accuonting for catch]
                    this.addNewLine = false;

                    // TODO Reset [DRY, accuonting for catch]
                    this.ResetCaptures();
                }
                catch (Exception ex)
                {
                    // Set error message
                    string errorMessage = $"Error when deleting \"{sourceFilePath}\". Message: {ex.Message}";

                    // Advise user
                    MessageBox.Show($"{errorMessage}{Environment.NewLine}", "File/New error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Write to error log
                    File.AppendAllText("ClipText_ErrorLog.txt", $"{Environment.NewLine}errorMessage");
                }
            }
        }

        /// <summary>
        /// Handles the open file button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOpenFileButtonClick(object sender, EventArgs e)
        {
            // Reset file name
            this.textFileOpenFileDialog.FileName = string.Empty;

            // Show open file dialog
            if (this.textFileOpenFileDialog.ShowDialog() == DialogResult.OK && this.textFileOpenFileDialog.FileNames.Length > 0)
            {
                // Set into text box
                this.targetFileTextBox.Text = this.textFileOpenFileDialog.FileName;
            }
        }

        /// <summary>
        /// Handles the options tool strip menu item drop down item clicked.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Set tool strip menu item
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)e.ClickedItem;

            // Toggle checked
            toolStripMenuItem.Checked = !toolStripMenuItem.Checked;

            // Set topmost by check box
            this.TopMost = this.alwaysOnTopToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Handles the free releases public domainis tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFreeReleasesPublicDomainisToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open our site
            Process.Start("https://publicdomain.is");
        }

        /// <summary>
        /// Handles the original thread donation codercom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadDonationCodercomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open original thread
            Process.Start("https://www.donationcoder.com/forum/index.php?topic=43151.0");
        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open GitHub repository
            Process.Start("https://github.com/publicdomain/clip-text");
        }

        /// <summary>
        /// Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the main form load.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormLoad(object sender, EventArgs e)
        {
            // Check options
            foreach (ToolStripMenuItem toolStripMenuItem in this.optionsToolStripMenuItem.DropDownItems)
            {
                // Set checked state
                toolStripMenuItem.Checked = this.settingsData.CheckedOptionsList.Contains(toolStripMenuItem.Name);
            }

            // Set file name
            this.targetFileTextBox.Text = this.settingsData.TargetTextFile;

            // Set topmost by settings data
            this.TopMost = this.settingsData.CheckedOptionsList.Contains("alwaysOnTopToolStripMenuItem");
        }

        /// <summary>
        /// Handles the main form form closing.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            /* Target text file */

            // Confirm it's checked and there's something to work with
            if (this.rememberTextFileToolStripMenuItem.Checked && this.targetFileTextBox.Text.Length > 0)
            {
                // Save to settings data
                this.settingsData.TargetTextFile = this.targetFileTextBox.Text;
            }

            /* Checked options */

            // New checked options list
            List<string> checkedOptionsList = new List<string>();

            // Set checked options list
            foreach (ToolStripMenuItem toolStripMenuItem in this.optionsToolStripMenuItem.DropDownItems)
            {
                // Check if checked
                if (toolStripMenuItem.Checked)
                {
                    // Add to checked options list
                    checkedOptionsList.Add(toolStripMenuItem.Name);
                }
            }

            // Set into settings data
            this.settingsData.CheckedOptionsList.Clear();
            this.settingsData.CheckedOptionsList = checkedOptionsList;

            /* Save to disk */

            // Save settings data to disk
            this.SaveSettingsFile(this.settingsDataPath, this.settingsData);
        }

        /// <summary>
        /// Loads the settings file.
        /// </summary>
        /// <returns>The settings file.</returns>
        /// <param name="settingsFilePath">Settings file path.</param>
        private SettingsData LoadSettingsFile(string settingsFilePath)
        {
            // Use file stream
            using (FileStream fileStream = File.OpenRead(settingsFilePath))
            {
                // Set xml serialzer
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SettingsData));

                // Return populated settings data
                return xmlSerializer.Deserialize(fileStream) as SettingsData;
            }
        }

        /// <summary>
        /// Saves the settings file.
        /// </summary>
        /// <param name="settingsFilePath">Settings file path.</param>
        /// <param name="settingsDataParam">Settings data parameter.</param>
        private void SaveSettingsFile(string settingsFilePath, SettingsData settingsDataParam)
        {
            try
            {
                // Use stream writer
                using (StreamWriter streamWriter = new StreamWriter(settingsFilePath, false))
                {
                    // Set xml serialzer
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(SettingsData));

                    // Serialize settings data
                    xmlSerializer.Serialize(streamWriter, settingsDataParam);
                }
            }
            catch (Exception exception)
            {
                // Advise user
                MessageBox.Show($"Error saving settings file.{Environment.NewLine}{Environment.NewLine}Message:{Environment.NewLine}{exception.Message}", "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the exit tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close program        
            this.Close();
        }
    }
}