
namespace ClipText
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.textFileOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rememberTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.freeReleasesPublicDomainisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.originalThreadDonationCodercomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
			this.termsTextToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.termsToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.textFileSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.openFileButton = new System.Windows.Forms.Button();
			this.targetFileTextBox = new System.Windows.Forms.TextBox();
			this.startStopButton = new System.Windows.Forms.Button();
			this.mainImageList = new System.Windows.Forms.ImageList(this.components);
			this.mainMenuStrip.SuspendLayout();
			this.mainStatusStrip.SuspendLayout();
			this.mainTableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// textFileOpenFileDialog
			// 
			this.textFileOpenFileDialog.DefaultExt = "txt";
			this.textFileOpenFileDialog.Filter = "TXT Files|*.txt|All files (*.*)|*.*";
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.minimizeToolStripMenuItem,
									this.fileToolStripMenuItem,
									this.optionsToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(284, 24);
			this.mainMenuStrip.TabIndex = 35;
			// 
			// minimizeToolStripMenuItem
			// 
			this.minimizeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
			this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
			this.minimizeToolStripMenuItem.Visible = false;
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newToolStripMenuItem,
									this.openToolStripMenuItem,
									this.toolStripSeparator,
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
			this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.newToolStripMenuItem.Text = "&New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.OnNewToolStripMenuItemClick);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
			this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.openToolStripMenuItem.Text = "&Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.OnOpenFileButtonClick);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.alwaysOnTopToolStripMenuItem,
									this.rememberTextFileToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.optionsToolStripMenuItem.Text = "&Options";
			this.optionsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnOptionsToolStripMenuItemDropDownItemClicked);
			// 
			// alwaysOnTopToolStripMenuItem
			// 
			this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
			this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.alwaysOnTopToolStripMenuItem.Text = "&Always on top";
			// 
			// rememberTextFileToolStripMenuItem
			// 
			this.rememberTextFileToolStripMenuItem.Checked = true;
			this.rememberTextFileToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.rememberTextFileToolStripMenuItem.Name = "rememberTextFileToolStripMenuItem";
			this.rememberTextFileToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.rememberTextFileToolStripMenuItem.Text = "&Remember text file";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.freeReleasesPublicDomainisToolStripMenuItem,
									this.originalThreadDonationCodercomToolStripMenuItem,
									this.sourceCodeGithubcomToolStripMenuItem,
									this.toolStripSeparator2,
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// freeReleasesPublicDomainisToolStripMenuItem
			// 
			this.freeReleasesPublicDomainisToolStripMenuItem.Name = "freeReleasesPublicDomainisToolStripMenuItem";
			this.freeReleasesPublicDomainisToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
			this.freeReleasesPublicDomainisToolStripMenuItem.Text = "Free Releases @ PublicDomain.is";
			this.freeReleasesPublicDomainisToolStripMenuItem.Click += new System.EventHandler(this.OnFreeReleasesPublicDomainisToolStripMenuItemClick);
			// 
			// originalThreadDonationCodercomToolStripMenuItem
			// 
			this.originalThreadDonationCodercomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("originalThreadDonationCodercomToolStripMenuItem.Image")));
			this.originalThreadDonationCodercomToolStripMenuItem.Name = "originalThreadDonationCodercomToolStripMenuItem";
			this.originalThreadDonationCodercomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
			this.originalThreadDonationCodercomToolStripMenuItem.Text = "&Original thread @ DonationCoder.com";
			this.originalThreadDonationCodercomToolStripMenuItem.Click += new System.EventHandler(this.OnOriginalThreadDonationCodercomToolStripMenuItemClick);
			// 
			// sourceCodeGithubcomToolStripMenuItem
			// 
			this.sourceCodeGithubcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceCodeGithubcomToolStripMenuItem.Image")));
			this.sourceCodeGithubcomToolStripMenuItem.Name = "sourceCodeGithubcomToolStripMenuItem";
			this.sourceCodeGithubcomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
			this.sourceCodeGithubcomToolStripMenuItem.Text = "Source code @ Github.com";
			this.sourceCodeGithubcomToolStripMenuItem.Click += new System.EventHandler(this.OnSourceCodeGithubcomToolStripMenuItemClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(275, 6);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
			this.aboutToolStripMenuItem.Text = "&About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
			// 
			// mainStatusStrip
			// 
			this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.termsTextToolStripStatusLabel,
									this.termsToolStripStatusLabel});
			this.mainStatusStrip.Location = new System.Drawing.Point(0, 140);
			this.mainStatusStrip.Name = "mainStatusStrip";
			this.mainStatusStrip.Size = new System.Drawing.Size(284, 22);
			this.mainStatusStrip.SizingGrip = false;
			this.mainStatusStrip.TabIndex = 34;
			// 
			// termsTextToolStripStatusLabel
			// 
			this.termsTextToolStripStatusLabel.Name = "termsTextToolStripStatusLabel";
			this.termsTextToolStripStatusLabel.Size = new System.Drawing.Size(57, 17);
			this.termsTextToolStripStatusLabel.Text = "Captures:";
			// 
			// termsToolStripStatusLabel
			// 
			this.termsToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.termsToolStripStatusLabel.Name = "termsToolStripStatusLabel";
			this.termsToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
			this.termsToolStripStatusLabel.Text = "0";
			// 
			// textFileSaveFileDialog
			// 
			this.textFileSaveFileDialog.DefaultExt = "txt";
			this.textFileSaveFileDialog.Filter = "TXT Files|*.txt|All files (*.*)|*.*";
			// 
			// mainTableLayoutPanel
			// 
			this.mainTableLayoutPanel.ColumnCount = 3;
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.mainTableLayoutPanel.Controls.Add(this.label1, 0, 0);
			this.mainTableLayoutPanel.Controls.Add(this.openFileButton, 2, 1);
			this.mainTableLayoutPanel.Controls.Add(this.targetFileTextBox, 0, 1);
			this.mainTableLayoutPanel.Controls.Add(this.startStopButton, 1, 2);
			this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
			this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
			this.mainTableLayoutPanel.RowCount = 3;
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.mainTableLayoutPanel.Size = new System.Drawing.Size(284, 116);
			this.mainTableLayoutPanel.TabIndex = 36;
			// 
			// label1
			// 
			this.mainTableLayoutPanel.SetColumnSpan(this.label1, 3);
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(278, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Target text file:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// openFileButton
			// 
			this.openFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.openFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.openFileButton.Image = ((System.Drawing.Image)(resources.GetObject("openFileButton.Image")));
			this.openFileButton.Location = new System.Drawing.Point(237, 33);
			this.openFileButton.Name = "openFileButton";
			this.openFileButton.Size = new System.Drawing.Size(44, 29);
			this.openFileButton.TabIndex = 1;
			this.openFileButton.UseVisualStyleBackColor = true;
			this.openFileButton.Click += new System.EventHandler(this.OnOpenFileButtonClick);
			// 
			// targetFileTextBox
			// 
			this.mainTableLayoutPanel.SetColumnSpan(this.targetFileTextBox, 2);
			this.targetFileTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.targetFileTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.targetFileTextBox.Location = new System.Drawing.Point(3, 33);
			this.targetFileTextBox.Name = "targetFileTextBox";
			this.targetFileTextBox.Size = new System.Drawing.Size(228, 26);
			this.targetFileTextBox.TabIndex = 2;
			this.targetFileTextBox.Text = "Cliptext.txt";
			// 
			// startStopButton
			// 
			this.startStopButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.startStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startStopButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.startStopButton.ImageIndex = 0;
			this.startStopButton.ImageList = this.mainImageList;
			this.startStopButton.Location = new System.Drawing.Point(53, 68);
			this.startStopButton.Name = "startStopButton";
			this.startStopButton.Size = new System.Drawing.Size(178, 45);
			this.startStopButton.TabIndex = 3;
			this.startStopButton.Text = "&Start";
			this.startStopButton.UseVisualStyleBackColor = true;
			this.startStopButton.Click += new System.EventHandler(this.OnStartStopButtonClick);
			// 
			// mainImageList
			// 
			this.mainImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mainImageList.ImageStream")));
			this.mainImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.mainImageList.Images.SetKeyName(0, "rec_32.png");
			this.mainImageList.Images.SetKeyName(1, "stop_32.png");
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 162);
			this.Controls.Add(this.mainTableLayoutPanel);
			this.Controls.Add(this.mainMenuStrip);
			this.Controls.Add(this.mainStatusStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ClipText";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnMainFormFormClosing);
			this.Load += new System.EventHandler(this.OnMainFormLoad);
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.mainStatusStrip.ResumeLayout(false);
			this.mainStatusStrip.PerformLayout();
			this.mainTableLayoutPanel.ResumeLayout(false);
			this.mainTableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ImageList mainImageList;
		private System.Windows.Forms.Button startStopButton;
		private System.Windows.Forms.TextBox targetFileTextBox;
		private System.Windows.Forms.Button openFileButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
		private System.Windows.Forms.SaveFileDialog textFileSaveFileDialog;
		private System.Windows.Forms.ToolStripMenuItem rememberTextFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel termsToolStripStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel termsTextToolStripStatusLabel;
		private System.Windows.Forms.StatusStrip mainStatusStrip;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem originalThreadDonationCodercomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem freeReleasesPublicDomainisToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.OpenFileDialog textFileOpenFileDialog;
	}
}
