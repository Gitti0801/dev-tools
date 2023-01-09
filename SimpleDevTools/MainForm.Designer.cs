
namespace SimpleDevTools
{
    partial class mainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tbpStringIncrement = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.rtxtOutputIncrement = new System.Windows.Forms.RichTextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblCharsToReplace = new System.Windows.Forms.Label();
            this.lblIncrement = new System.Windows.Forms.Label();
            this.lblEndingValue = new System.Windows.Forms.Label();
            this.lblStartingValue = new System.Windows.Forms.Label();
            this.txtCharToReplace = new System.Windows.Forms.TextBox();
            this.txtIncrement = new System.Windows.Forms.TextBox();
            this.txtEndingValue = new System.Windows.Forms.TextBox();
            this.txtStartingValue = new System.Windows.Forms.TextBox();
            this.txtInputIncrement = new System.Windows.Forms.TextBox();
            this.tbpUserSearch = new System.Windows.Forms.TabPage();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.btnOpenURL = new System.Windows.Forms.Button();
            this.lblURL = new System.Windows.Forms.Label();
            this.rtxtOutputUserSearch = new System.Windows.Forms.RichTextBox();
            this.btnEnterUserSearch = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbpTranslator = new System.Windows.Forms.TabPage();
            this.btnTranslatorClear = new System.Windows.Forms.Button();
            this.btnTranslatorUpdate = new System.Windows.Forms.Button();
            this.btnTranslatorOpenFolder = new System.Windows.Forms.Button();
            this.cbTranslatorType = new System.Windows.Forms.ComboBox();
            this.btnTranslatorExport = new System.Windows.Forms.Button();
            this.btnTranslatorImport = new System.Windows.Forms.Button();
            this.btnTranslatorTranslate = new System.Windows.Forms.Button();
            this.rtxtTranslatorOutput = new System.Windows.Forms.RichTextBox();
            this.rtxtTranslatorInput = new System.Windows.Forms.RichTextBox();
            this.lblTranslatorOutput = new System.Windows.Forms.Label();
            this.lblTranslatorInput = new System.Windows.Forms.Label();
            this.tbpSettings = new System.Windows.Forms.TabPage();
            this.btnSettingsDevKey = new System.Windows.Forms.Button();
            this.lblSettingsDev = new System.Windows.Forms.Label();
            this.txtSettingsDev = new System.Windows.Forms.TextBox();
            this.btnSettingsForeColor = new System.Windows.Forms.Button();
            this.btnSettingsReset = new System.Windows.Forms.Button();
            this.btnSettingsResetChanges = new System.Windows.Forms.Button();
            this.btnSettingsSave = new System.Windows.Forms.Button();
            this.btnSettingsColor = new System.Windows.Forms.Button();
            this.lblSettingsTheme = new System.Windows.Forms.Label();
            this.lblSettingsHeader = new System.Windows.Forms.Label();
            this.bwCheckURL = new System.ComponentModel.BackgroundWorker();
            this.cmsTranslatorExport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTranslatorImport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fromClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblOriginalString = new System.Windows.Forms.Label();
            this.tbcMain.SuspendLayout();
            this.tbpStringIncrement.SuspendLayout();
            this.tbpUserSearch.SuspendLayout();
            this.tbpTranslator.SuspendLayout();
            this.tbpSettings.SuspendLayout();
            this.cmsTranslatorExport.SuspendLayout();
            this.cmsTranslatorImport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcMain
            // 
            this.tbcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcMain.Controls.Add(this.tbpStringIncrement);
            this.tbcMain.Controls.Add(this.tbpUserSearch);
            this.tbcMain.Controls.Add(this.tbpTranslator);
            this.tbcMain.Controls.Add(this.tbpSettings);
            this.tbcMain.Location = new System.Drawing.Point(12, 12);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(776, 426);
            this.tbcMain.TabIndex = 0;
            this.tbcMain.SelectedIndexChanged += new System.EventHandler(this.tbcMain_SelectedIndexChanged);
            // 
            // tbpStringIncrement
            // 
            this.tbpStringIncrement.Controls.Add(this.lblOriginalString);
            this.tbpStringIncrement.Controls.Add(this.btnClear);
            this.tbpStringIncrement.Controls.Add(this.btnCopy);
            this.tbpStringIncrement.Controls.Add(this.rtxtOutputIncrement);
            this.tbpStringIncrement.Controls.Add(this.btnGenerate);
            this.tbpStringIncrement.Controls.Add(this.lblCharsToReplace);
            this.tbpStringIncrement.Controls.Add(this.lblIncrement);
            this.tbpStringIncrement.Controls.Add(this.lblEndingValue);
            this.tbpStringIncrement.Controls.Add(this.lblStartingValue);
            this.tbpStringIncrement.Controls.Add(this.txtCharToReplace);
            this.tbpStringIncrement.Controls.Add(this.txtIncrement);
            this.tbpStringIncrement.Controls.Add(this.txtEndingValue);
            this.tbpStringIncrement.Controls.Add(this.txtStartingValue);
            this.tbpStringIncrement.Controls.Add(this.txtInputIncrement);
            this.tbpStringIncrement.Location = new System.Drawing.Point(4, 25);
            this.tbpStringIncrement.Name = "tbpStringIncrement";
            this.tbpStringIncrement.Padding = new System.Windows.Forms.Padding(3);
            this.tbpStringIncrement.Size = new System.Drawing.Size(768, 397);
            this.tbpStringIncrement.TabIndex = 0;
            this.tbpStringIncrement.Text = "String Increment";
            this.tbpStringIncrement.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(325, 127);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 42);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(450, 127);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(312, 42);
            this.btnCopy.TabIndex = 11;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // rtxtOutputIncrement
            // 
            this.rtxtOutputIncrement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtOutputIncrement.Location = new System.Drawing.Point(7, 177);
            this.rtxtOutputIncrement.Name = "rtxtOutputIncrement";
            this.rtxtOutputIncrement.Size = new System.Drawing.Size(755, 214);
            this.rtxtOutputIncrement.TabIndex = 10;
            this.rtxtOutputIncrement.Text = "";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(7, 128);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(312, 42);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Generate Strings";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblCharsToReplace
            // 
            this.lblCharsToReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCharsToReplace.AutoSize = true;
            this.lblCharsToReplace.Location = new System.Drawing.Point(655, 19);
            this.lblCharsToReplace.Name = "lblCharsToReplace";
            this.lblCharsToReplace.Size = new System.Drawing.Size(91, 17);
            this.lblCharsToReplace.TabIndex = 8;
            this.lblCharsToReplace.Text = "Replacement";
            // 
            // lblIncrement
            // 
            this.lblIncrement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIncrement.AutoSize = true;
            this.lblIncrement.Location = new System.Drawing.Point(428, 19);
            this.lblIncrement.Name = "lblIncrement";
            this.lblIncrement.Size = new System.Drawing.Size(70, 17);
            this.lblIncrement.TabIndex = 7;
            this.lblIncrement.Text = "Increment";
            // 
            // lblEndingValue
            // 
            this.lblEndingValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndingValue.AutoSize = true;
            this.lblEndingValue.Location = new System.Drawing.Point(216, 19);
            this.lblEndingValue.Name = "lblEndingValue";
            this.lblEndingValue.Size = new System.Drawing.Size(92, 17);
            this.lblEndingValue.TabIndex = 6;
            this.lblEndingValue.Text = "Ending Value";
            // 
            // lblStartingValue
            // 
            this.lblStartingValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartingValue.AutoSize = true;
            this.lblStartingValue.Location = new System.Drawing.Point(7, 19);
            this.lblStartingValue.Name = "lblStartingValue";
            this.lblStartingValue.Size = new System.Drawing.Size(97, 17);
            this.lblStartingValue.TabIndex = 5;
            this.lblStartingValue.Text = "Starting Value";
            // 
            // txtCharToReplace
            // 
            this.txtCharToReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCharToReplace.Location = new System.Drawing.Point(658, 42);
            this.txtCharToReplace.Name = "txtCharToReplace";
            this.txtCharToReplace.Size = new System.Drawing.Size(100, 22);
            this.txtCharToReplace.TabIndex = 4;
            this.txtCharToReplace.Text = "[x]";
            // 
            // txtIncrement
            // 
            this.txtIncrement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIncrement.Location = new System.Drawing.Point(431, 42);
            this.txtIncrement.Name = "txtIncrement";
            this.txtIncrement.Size = new System.Drawing.Size(100, 22);
            this.txtIncrement.TabIndex = 3;
            // 
            // txtEndingValue
            // 
            this.txtEndingValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndingValue.Location = new System.Drawing.Point(219, 42);
            this.txtEndingValue.Name = "txtEndingValue";
            this.txtEndingValue.Size = new System.Drawing.Size(100, 22);
            this.txtEndingValue.TabIndex = 2;
            // 
            // txtStartingValue
            // 
            this.txtStartingValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartingValue.Location = new System.Drawing.Point(7, 42);
            this.txtStartingValue.Name = "txtStartingValue";
            this.txtStartingValue.Size = new System.Drawing.Size(100, 22);
            this.txtStartingValue.TabIndex = 1;
            // 
            // txtInputIncrement
            // 
            this.txtInputIncrement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInputIncrement.Location = new System.Drawing.Point(7, 99);
            this.txtInputIncrement.Name = "txtInputIncrement";
            this.txtInputIncrement.Size = new System.Drawing.Size(755, 22);
            this.txtInputIncrement.TabIndex = 0;
            // 
            // tbpUserSearch
            // 
            this.tbpUserSearch.Controls.Add(this.btnStats);
            this.tbpUserSearch.Controls.Add(this.btnCancel);
            this.tbpUserSearch.Controls.Add(this.btnReset);
            this.tbpUserSearch.Controls.Add(this.lblStatus);
            this.tbpUserSearch.Controls.Add(this.lblResults);
            this.tbpUserSearch.Controls.Add(this.lblCounter);
            this.tbpUserSearch.Controls.Add(this.btnOpenURL);
            this.tbpUserSearch.Controls.Add(this.lblURL);
            this.tbpUserSearch.Controls.Add(this.rtxtOutputUserSearch);
            this.tbpUserSearch.Controls.Add(this.btnEnterUserSearch);
            this.tbpUserSearch.Controls.Add(this.txtUsername);
            this.tbpUserSearch.Controls.Add(this.lblUsername);
            this.tbpUserSearch.Location = new System.Drawing.Point(4, 25);
            this.tbpUserSearch.Name = "tbpUserSearch";
            this.tbpUserSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUserSearch.Size = new System.Drawing.Size(768, 397);
            this.tbpUserSearch.TabIndex = 1;
            this.tbpUserSearch.Text = "UserSearch";
            this.tbpUserSearch.UseVisualStyleBackColor = true;
            // 
            // btnStats
            // 
            this.btnStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStats.Enabled = false;
            this.btnStats.Location = new System.Drawing.Point(436, 305);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(86, 65);
            this.btnStats.TabIndex = 11;
            this.btnStats.Text = "Stats";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(528, 305);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 65);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(648, 305);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 65);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(322, 373);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(108, 17);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status: Standby";
            // 
            // lblResults
            // 
            this.lblResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(146, 373);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(139, 17);
            this.lblResults.TabIndex = 7;
            this.lblResults.Text = "??? Working Results";
            // 
            // lblCounter
            // 
            this.lblCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(7, 373);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(103, 17);
            this.lblCounter.TabIndex = 6;
            this.lblCounter.Text = "0/??? Checked";
            // 
            // btnOpenURL
            // 
            this.btnOpenURL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenURL.Enabled = false;
            this.btnOpenURL.Location = new System.Drawing.Point(462, 114);
            this.btnOpenURL.Name = "btnOpenURL";
            this.btnOpenURL.Size = new System.Drawing.Size(300, 65);
            this.btnOpenURL.TabIndex = 5;
            this.btnOpenURL.Text = "Open URL";
            this.btnOpenURL.UseVisualStyleBackColor = true;
            this.btnOpenURL.Click += new System.EventHandler(this.btnOpenURL_Click);
            // 
            // lblURL
            // 
            this.lblURL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(459, 64);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(216, 17);
            this.lblURL.TabIndex = 4;
            this.lblURL.Text = "URL WILL BE DISPLAYED HERE";
            // 
            // rtxtOutputUserSearch
            // 
            this.rtxtOutputUserSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtOutputUserSearch.Location = new System.Drawing.Point(7, 64);
            this.rtxtOutputUserSearch.Name = "rtxtOutputUserSearch";
            this.rtxtOutputUserSearch.ReadOnly = true;
            this.rtxtOutputUserSearch.Size = new System.Drawing.Size(423, 306);
            this.rtxtOutputUserSearch.TabIndex = 3;
            this.rtxtOutputUserSearch.Text = "";
            // 
            // btnEnterUserSearch
            // 
            this.btnEnterUserSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnterUserSearch.Location = new System.Drawing.Point(138, 14);
            this.btnEnterUserSearch.Name = "btnEnterUserSearch";
            this.btnEnterUserSearch.Size = new System.Drawing.Size(75, 43);
            this.btnEnterUserSearch.TabIndex = 2;
            this.btnEnterUserSearch.Text = "Enter";
            this.btnEnterUserSearch.UseVisualStyleBackColor = true;
            this.btnEnterUserSearch.Click += new System.EventHandler(this.btnEnterUserSearch_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(6, 35);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(3, 14);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 17);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // tbpTranslator
            // 
            this.tbpTranslator.Controls.Add(this.btnTranslatorClear);
            this.tbpTranslator.Controls.Add(this.btnTranslatorUpdate);
            this.tbpTranslator.Controls.Add(this.btnTranslatorOpenFolder);
            this.tbpTranslator.Controls.Add(this.cbTranslatorType);
            this.tbpTranslator.Controls.Add(this.btnTranslatorExport);
            this.tbpTranslator.Controls.Add(this.btnTranslatorImport);
            this.tbpTranslator.Controls.Add(this.btnTranslatorTranslate);
            this.tbpTranslator.Controls.Add(this.rtxtTranslatorOutput);
            this.tbpTranslator.Controls.Add(this.rtxtTranslatorInput);
            this.tbpTranslator.Controls.Add(this.lblTranslatorOutput);
            this.tbpTranslator.Controls.Add(this.lblTranslatorInput);
            this.tbpTranslator.Location = new System.Drawing.Point(4, 25);
            this.tbpTranslator.Name = "tbpTranslator";
            this.tbpTranslator.Size = new System.Drawing.Size(768, 397);
            this.tbpTranslator.TabIndex = 2;
            this.tbpTranslator.Text = "Translator";
            this.tbpTranslator.UseVisualStyleBackColor = true;
            // 
            // btnTranslatorClear
            // 
            this.btnTranslatorClear.Location = new System.Drawing.Point(267, 202);
            this.btnTranslatorClear.Name = "btnTranslatorClear";
            this.btnTranslatorClear.Size = new System.Drawing.Size(235, 37);
            this.btnTranslatorClear.TabIndex = 10;
            this.btnTranslatorClear.Text = "Clear";
            this.btnTranslatorClear.UseVisualStyleBackColor = true;
            this.btnTranslatorClear.Click += new System.EventHandler(this.btnTranslatorClear_Click);
            // 
            // btnTranslatorUpdate
            // 
            this.btnTranslatorUpdate.Location = new System.Drawing.Point(388, 69);
            this.btnTranslatorUpdate.Name = "btnTranslatorUpdate";
            this.btnTranslatorUpdate.Size = new System.Drawing.Size(115, 31);
            this.btnTranslatorUpdate.TabIndex = 9;
            this.btnTranslatorUpdate.Text = "Update";
            this.btnTranslatorUpdate.UseVisualStyleBackColor = true;
            this.btnTranslatorUpdate.Click += new System.EventHandler(this.btnTranslatorUpdate_Click);
            // 
            // btnTranslatorOpenFolder
            // 
            this.btnTranslatorOpenFolder.Location = new System.Drawing.Point(269, 69);
            this.btnTranslatorOpenFolder.Name = "btnTranslatorOpenFolder";
            this.btnTranslatorOpenFolder.Size = new System.Drawing.Size(115, 31);
            this.btnTranslatorOpenFolder.TabIndex = 8;
            this.btnTranslatorOpenFolder.Text = "Open Folder";
            this.btnTranslatorOpenFolder.UseVisualStyleBackColor = true;
            this.btnTranslatorOpenFolder.Click += new System.EventHandler(this.btnTranslatorOpenFolder_Click);
            // 
            // cbTranslatorType
            // 
            this.cbTranslatorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTranslatorType.FormattingEnabled = true;
            this.cbTranslatorType.Items.AddRange(new object[] {
            "Morse Code"});
            this.cbTranslatorType.Location = new System.Drawing.Point(269, 39);
            this.cbTranslatorType.Name = "cbTranslatorType";
            this.cbTranslatorType.Size = new System.Drawing.Size(234, 24);
            this.cbTranslatorType.TabIndex = 7;
            // 
            // btnTranslatorExport
            // 
            this.btnTranslatorExport.Location = new System.Drawing.Point(388, 362);
            this.btnTranslatorExport.Name = "btnTranslatorExport";
            this.btnTranslatorExport.Size = new System.Drawing.Size(115, 31);
            this.btnTranslatorExport.TabIndex = 6;
            this.btnTranslatorExport.Text = "Export";
            this.btnTranslatorExport.UseVisualStyleBackColor = true;
            this.btnTranslatorExport.Click += new System.EventHandler(this.btnTranslatorExport_Click);
            // 
            // btnTranslatorImport
            // 
            this.btnTranslatorImport.Location = new System.Drawing.Point(267, 362);
            this.btnTranslatorImport.Name = "btnTranslatorImport";
            this.btnTranslatorImport.Size = new System.Drawing.Size(115, 31);
            this.btnTranslatorImport.TabIndex = 5;
            this.btnTranslatorImport.Text = "Import";
            this.btnTranslatorImport.UseVisualStyleBackColor = true;
            this.btnTranslatorImport.Click += new System.EventHandler(this.btnTranslatorImport_Click);
            // 
            // btnTranslatorTranslate
            // 
            this.btnTranslatorTranslate.Location = new System.Drawing.Point(269, 159);
            this.btnTranslatorTranslate.Name = "btnTranslatorTranslate";
            this.btnTranslatorTranslate.Size = new System.Drawing.Size(235, 37);
            this.btnTranslatorTranslate.TabIndex = 4;
            this.btnTranslatorTranslate.Text = "Translate";
            this.btnTranslatorTranslate.UseVisualStyleBackColor = true;
            this.btnTranslatorTranslate.Click += new System.EventHandler(this.btnTranslatorTranslate_Click);
            // 
            // rtxtTranslatorOutput
            // 
            this.rtxtTranslatorOutput.Location = new System.Drawing.Point(509, 39);
            this.rtxtTranslatorOutput.Name = "rtxtTranslatorOutput";
            this.rtxtTranslatorOutput.Size = new System.Drawing.Size(256, 355);
            this.rtxtTranslatorOutput.TabIndex = 3;
            this.rtxtTranslatorOutput.Text = "";
            // 
            // rtxtTranslatorInput
            // 
            this.rtxtTranslatorInput.Location = new System.Drawing.Point(6, 39);
            this.rtxtTranslatorInput.Name = "rtxtTranslatorInput";
            this.rtxtTranslatorInput.Size = new System.Drawing.Size(256, 355);
            this.rtxtTranslatorInput.TabIndex = 2;
            this.rtxtTranslatorInput.Text = "";
            // 
            // lblTranslatorOutput
            // 
            this.lblTranslatorOutput.AutoSize = true;
            this.lblTranslatorOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTranslatorOutput.Location = new System.Drawing.Point(504, 11);
            this.lblTranslatorOutput.Name = "lblTranslatorOutput";
            this.lblTranslatorOutput.Size = new System.Drawing.Size(71, 25);
            this.lblTranslatorOutput.TabIndex = 1;
            this.lblTranslatorOutput.Text = "Output";
            // 
            // lblTranslatorInput
            // 
            this.lblTranslatorInput.AutoSize = true;
            this.lblTranslatorInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTranslatorInput.Location = new System.Drawing.Point(3, 11);
            this.lblTranslatorInput.Name = "lblTranslatorInput";
            this.lblTranslatorInput.Size = new System.Drawing.Size(55, 25);
            this.lblTranslatorInput.TabIndex = 0;
            this.lblTranslatorInput.Text = "Input";
            // 
            // tbpSettings
            // 
            this.tbpSettings.Controls.Add(this.btnSettingsDevKey);
            this.tbpSettings.Controls.Add(this.lblSettingsDev);
            this.tbpSettings.Controls.Add(this.txtSettingsDev);
            this.tbpSettings.Controls.Add(this.btnSettingsForeColor);
            this.tbpSettings.Controls.Add(this.btnSettingsReset);
            this.tbpSettings.Controls.Add(this.btnSettingsResetChanges);
            this.tbpSettings.Controls.Add(this.btnSettingsSave);
            this.tbpSettings.Controls.Add(this.btnSettingsColor);
            this.tbpSettings.Controls.Add(this.lblSettingsTheme);
            this.tbpSettings.Controls.Add(this.lblSettingsHeader);
            this.tbpSettings.Location = new System.Drawing.Point(4, 25);
            this.tbpSettings.Name = "tbpSettings";
            this.tbpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSettings.Size = new System.Drawing.Size(768, 397);
            this.tbpSettings.TabIndex = 4;
            this.tbpSettings.Text = "Settings";
            this.tbpSettings.UseVisualStyleBackColor = true;
            // 
            // btnSettingsDevKey
            // 
            this.btnSettingsDevKey.Location = new System.Drawing.Point(632, 76);
            this.btnSettingsDevKey.Name = "btnSettingsDevKey";
            this.btnSettingsDevKey.Size = new System.Drawing.Size(130, 23);
            this.btnSettingsDevKey.TabIndex = 9;
            this.btnSettingsDevKey.Text = "Enter Key";
            this.btnSettingsDevKey.UseVisualStyleBackColor = true;
            this.btnSettingsDevKey.Click += new System.EventHandler(this.btnSettingsDevKey_Click);
            // 
            // lblSettingsDev
            // 
            this.lblSettingsDev.AutoSize = true;
            this.lblSettingsDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsDev.Location = new System.Drawing.Point(628, 25);
            this.lblSettingsDev.Name = "lblSettingsDev";
            this.lblSettingsDev.Size = new System.Drawing.Size(42, 20);
            this.lblSettingsDev.TabIndex = 8;
            this.lblSettingsDev.Text = "Dev";
            // 
            // txtSettingsDev
            // 
            this.txtSettingsDev.Location = new System.Drawing.Point(632, 48);
            this.txtSettingsDev.Name = "txtSettingsDev";
            this.txtSettingsDev.PasswordChar = '*';
            this.txtSettingsDev.Size = new System.Drawing.Size(130, 22);
            this.txtSettingsDev.TabIndex = 7;
            // 
            // btnSettingsForeColor
            // 
            this.btnSettingsForeColor.Location = new System.Drawing.Point(10, 76);
            this.btnSettingsForeColor.Name = "btnSettingsForeColor";
            this.btnSettingsForeColor.Size = new System.Drawing.Size(92, 23);
            this.btnSettingsForeColor.TabIndex = 6;
            this.btnSettingsForeColor.Text = "ForeColor";
            this.btnSettingsForeColor.UseVisualStyleBackColor = true;
            this.btnSettingsForeColor.Click += new System.EventHandler(this.btnSettingsForeColor_Click);
            // 
            // btnSettingsReset
            // 
            this.btnSettingsReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingsReset.Location = new System.Drawing.Point(702, 331);
            this.btnSettingsReset.Name = "btnSettingsReset";
            this.btnSettingsReset.Size = new System.Drawing.Size(60, 60);
            this.btnSettingsReset.TabIndex = 5;
            this.btnSettingsReset.Text = "Reset";
            this.btnSettingsReset.UseVisualStyleBackColor = true;
            this.btnSettingsReset.Click += new System.EventHandler(this.btnSettingsReset_Click);
            // 
            // btnSettingsResetChanges
            // 
            this.btnSettingsResetChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingsResetChanges.Location = new System.Drawing.Point(355, 331);
            this.btnSettingsResetChanges.Name = "btnSettingsResetChanges";
            this.btnSettingsResetChanges.Size = new System.Drawing.Size(341, 60);
            this.btnSettingsResetChanges.TabIndex = 4;
            this.btnSettingsResetChanges.Text = "Reset Changes";
            this.btnSettingsResetChanges.UseVisualStyleBackColor = true;
            this.btnSettingsResetChanges.Click += new System.EventHandler(this.btnSettingsResetChanges_Click);
            // 
            // btnSettingsSave
            // 
            this.btnSettingsSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingsSave.Location = new System.Drawing.Point(6, 331);
            this.btnSettingsSave.Name = "btnSettingsSave";
            this.btnSettingsSave.Size = new System.Drawing.Size(341, 60);
            this.btnSettingsSave.TabIndex = 3;
            this.btnSettingsSave.Text = "Save";
            this.btnSettingsSave.UseVisualStyleBackColor = true;
            this.btnSettingsSave.Click += new System.EventHandler(this.btnSettingsSave_Click);
            // 
            // btnSettingsColor
            // 
            this.btnSettingsColor.Location = new System.Drawing.Point(9, 47);
            this.btnSettingsColor.Name = "btnSettingsColor";
            this.btnSettingsColor.Size = new System.Drawing.Size(92, 23);
            this.btnSettingsColor.TabIndex = 2;
            this.btnSettingsColor.Text = "BackColor";
            this.btnSettingsColor.UseVisualStyleBackColor = true;
            this.btnSettingsColor.Click += new System.EventHandler(this.btnSettingsColor_Click);
            // 
            // lblSettingsTheme
            // 
            this.lblSettingsTheme.AutoSize = true;
            this.lblSettingsTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsTheme.Location = new System.Drawing.Point(6, 25);
            this.lblSettingsTheme.Name = "lblSettingsTheme";
            this.lblSettingsTheme.Size = new System.Drawing.Size(65, 20);
            this.lblSettingsTheme.TabIndex = 1;
            this.lblSettingsTheme.Text = "Theme";
            // 
            // lblSettingsHeader
            // 
            this.lblSettingsHeader.AutoSize = true;
            this.lblSettingsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsHeader.Location = new System.Drawing.Point(347, 0);
            this.lblSettingsHeader.Name = "lblSettingsHeader";
            this.lblSettingsHeader.Size = new System.Drawing.Size(83, 25);
            this.lblSettingsHeader.TabIndex = 0;
            this.lblSettingsHeader.Text = "Settings";
            // 
            // bwCheckURL
            // 
            this.bwCheckURL.WorkerSupportsCancellation = true;
            this.bwCheckURL.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwCheckURL_DoWork);
            // 
            // cmsTranslatorExport
            // 
            this.cmsTranslatorExport.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsTranslatorExport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToClipboardToolStripMenuItem,
            this.asFileToolStripMenuItem});
            this.cmsTranslatorExport.Name = "contextMenuStrip1";
            this.cmsTranslatorExport.Size = new System.Drawing.Size(199, 52);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.copyToClipboardToolStripMenuItem.Text = "Copy to clipboard";
            this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click);
            // 
            // asFileToolStripMenuItem
            // 
            this.asFileToolStripMenuItem.Name = "asFileToolStripMenuItem";
            this.asFileToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.asFileToolStripMenuItem.Text = "Save to file...";
            this.asFileToolStripMenuItem.Click += new System.EventHandler(this.asFileToolStripMenuItem_Click);
            // 
            // cmsTranslatorImport
            // 
            this.cmsTranslatorImport.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsTranslatorImport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromClipboardToolStripMenuItem,
            this.fromFileToolStripMenuItem});
            this.cmsTranslatorImport.Name = "cmsTranslatorImport";
            this.cmsTranslatorImport.Size = new System.Drawing.Size(181, 52);
            // 
            // fromClipboardToolStripMenuItem
            // 
            this.fromClipboardToolStripMenuItem.Name = "fromClipboardToolStripMenuItem";
            this.fromClipboardToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.fromClipboardToolStripMenuItem.Text = "From clipboard";
            this.fromClipboardToolStripMenuItem.Click += new System.EventHandler(this.fromClipboardToolStripMenuItem_Click);
            // 
            // fromFileToolStripMenuItem
            // 
            this.fromFileToolStripMenuItem.Name = "fromFileToolStripMenuItem";
            this.fromFileToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.fromFileToolStripMenuItem.Text = "From file...";
            this.fromFileToolStripMenuItem.Click += new System.EventHandler(this.fromFileToolStripMenuItem_Click);
            // 
            // lblOriginalString
            // 
            this.lblOriginalString.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOriginalString.AutoSize = true;
            this.lblOriginalString.Location = new System.Drawing.Point(10, 79);
            this.lblOriginalString.Name = "lblOriginalString";
            this.lblOriginalString.Size = new System.Drawing.Size(45, 17);
            this.lblOriginalString.TabIndex = 13;
            this.lblOriginalString.Text = "String";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcMain);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleDevTools";
            this.tbcMain.ResumeLayout(false);
            this.tbpStringIncrement.ResumeLayout(false);
            this.tbpStringIncrement.PerformLayout();
            this.tbpUserSearch.ResumeLayout(false);
            this.tbpUserSearch.PerformLayout();
            this.tbpTranslator.ResumeLayout(false);
            this.tbpTranslator.PerformLayout();
            this.tbpSettings.ResumeLayout(false);
            this.tbpSettings.PerformLayout();
            this.cmsTranslatorExport.ResumeLayout(false);
            this.cmsTranslatorImport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpStringIncrement;
        private System.Windows.Forms.TextBox txtInputIncrement;
        private System.Windows.Forms.TabPage tbpUserSearch;
        private System.Windows.Forms.RichTextBox rtxtOutputIncrement;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblCharsToReplace;
        private System.Windows.Forms.Label lblIncrement;
        private System.Windows.Forms.Label lblEndingValue;
        private System.Windows.Forms.Label lblStartingValue;
        private System.Windows.Forms.TextBox txtCharToReplace;
        private System.Windows.Forms.TextBox txtIncrement;
        private System.Windows.Forms.TextBox txtEndingValue;
        private System.Windows.Forms.TextBox txtStartingValue;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOpenURL;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.RichTextBox rtxtOutputUserSearch;
        private System.Windows.Forms.Button btnEnterUserSearch;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblResults;
        private System.ComponentModel.BackgroundWorker bwCheckURL;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.TabPage tbpTranslator;
        private System.Windows.Forms.Button btnTranslatorTranslate;
        private System.Windows.Forms.RichTextBox rtxtTranslatorOutput;
        private System.Windows.Forms.RichTextBox rtxtTranslatorInput;
        private System.Windows.Forms.Label lblTranslatorOutput;
        private System.Windows.Forms.Label lblTranslatorInput;
        private System.Windows.Forms.ContextMenuStrip cmsTranslatorExport;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asFileToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbTranslatorType;
        private System.Windows.Forms.Button btnTranslatorExport;
        private System.Windows.Forms.Button btnTranslatorImport;
        private System.Windows.Forms.ContextMenuStrip cmsTranslatorImport;
        private System.Windows.Forms.ToolStripMenuItem fromClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromFileToolStripMenuItem;
        private System.Windows.Forms.TabPage tbpSettings;
        private System.Windows.Forms.Button btnTranslatorUpdate;
        private System.Windows.Forms.Button btnTranslatorOpenFolder;
        private System.Windows.Forms.Button btnTranslatorClear;
        private System.Windows.Forms.Label lblSettingsHeader;
        private System.Windows.Forms.Button btnSettingsColor;
        private System.Windows.Forms.Label lblSettingsTheme;
        private System.Windows.Forms.Button btnSettingsReset;
        private System.Windows.Forms.Button btnSettingsResetChanges;
        private System.Windows.Forms.Button btnSettingsSave;
        private System.Windows.Forms.Button btnSettingsForeColor;
        private System.Windows.Forms.TextBox txtSettingsDev;
        private System.Windows.Forms.Label lblSettingsDev;
        private System.Windows.Forms.Button btnSettingsDevKey;
        private System.Windows.Forms.Label lblOriginalString;
    }
}

