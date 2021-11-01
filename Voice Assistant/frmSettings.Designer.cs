
namespace Voice_Assistant
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.frmElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.grpAddCommand = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtAssistantReply = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddCommand = new Guna.UI2.WinForms.Guna2Button();
            this.btnBrowse = new Guna.UI2.WinForms.Guna2Button();
            this.checkVerification = new Guna.UI2.WinForms.Guna2CheckBox();
            this.comboCommandType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtCommandString = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtVoiceCommand = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblVoice = new System.Windows.Forms.Label();
            this.grpConfig = new Guna.UI2.WinForms.Guna2GroupBox();
            this.trackTransparency = new Guna.UI2.WinForms.Guna2TrackBar();
            this.trackSound = new Guna.UI2.WinForms.Guna2TrackBar();
            this.picSoundIcon = new System.Windows.Forms.PictureBox();
            this.picAssistantIcon = new System.Windows.Forms.PictureBox();
            this.btnBrowseStyleJson = new Guna.UI2.WinForms.Guna2Button();
            this.txtStylesJson = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBrowseCmdJson = new Guna.UI2.WinForms.Guna2Button();
            this.comboVoice = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtCommandsJson = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlTransparency = new Guna.UI2.WinForms.Guna2Panel();
            this.picTransparencyIcon = new System.Windows.Forms.PictureBox();
            this.frmShadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.frmDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.picDrag = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ElipseLabel = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.grpAddCommand.SuspendLayout();
            this.grpConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSoundIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAssistantIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTransparencyIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDrag)).BeginInit();
            this.SuspendLayout();
            // 
            // frmElipse
            // 
            this.frmElipse.TargetControl = this;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 6;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.btnClose.Location = new System.Drawing.Point(439, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(45, 33);
            this.btnClose.TabIndex = 10;
            this.btnClose.UseTransparentBackground = true;
            // 
            // grpAddCommand
            // 
            this.grpAddCommand.BackColor = System.Drawing.Color.Transparent;
            this.grpAddCommand.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.grpAddCommand.BorderRadius = 6;
            this.grpAddCommand.Controls.Add(this.txtAssistantReply);
            this.grpAddCommand.Controls.Add(this.btnAddCommand);
            this.grpAddCommand.Controls.Add(this.btnBrowse);
            this.grpAddCommand.Controls.Add(this.checkVerification);
            this.grpAddCommand.Controls.Add(this.comboCommandType);
            this.grpAddCommand.Controls.Add(this.txtCommandString);
            this.grpAddCommand.Controls.Add(this.txtVoiceCommand);
            this.grpAddCommand.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.grpAddCommand.FillColor = System.Drawing.Color.Transparent;
            this.grpAddCommand.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(73)))), ((int)(((byte)(99)))));
            this.grpAddCommand.Location = new System.Drawing.Point(12, 42);
            this.grpAddCommand.Name = "grpAddCommand";
            this.grpAddCommand.ShadowDecoration.Parent = this.grpAddCommand;
            this.grpAddCommand.Size = new System.Drawing.Size(459, 232);
            this.grpAddCommand.TabIndex = 11;
            this.grpAddCommand.Text = "Add Command";
            this.grpAddCommand.UseTransparentBackground = true;
            // 
            // txtAssistantReply
            // 
            this.txtAssistantReply.Animated = true;
            this.txtAssistantReply.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.txtAssistantReply.BorderRadius = 6;
            this.txtAssistantReply.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAssistantReply.DefaultText = "";
            this.txtAssistantReply.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAssistantReply.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAssistantReply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAssistantReply.DisabledState.Parent = this.txtAssistantReply;
            this.txtAssistantReply.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAssistantReply.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(89)))), ((int)(((byte)(115)))));
            this.txtAssistantReply.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.txtAssistantReply.FocusedState.Parent = this.txtAssistantReply;
            this.txtAssistantReply.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssistantReply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.txtAssistantReply.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.txtAssistantReply.HoverState.Parent = this.txtAssistantReply;
            this.txtAssistantReply.Location = new System.Drawing.Point(19, 99);
            this.txtAssistantReply.Name = "txtAssistantReply";
            this.txtAssistantReply.PasswordChar = '\0';
            this.txtAssistantReply.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtAssistantReply.PlaceholderText = "Assistant Reply";
            this.txtAssistantReply.SelectedText = "";
            this.txtAssistantReply.ShadowDecoration.Parent = this.txtAssistantReply;
            this.txtAssistantReply.Size = new System.Drawing.Size(421, 34);
            this.txtAssistantReply.TabIndex = 6;
            // 
            // btnAddCommand
            // 
            this.btnAddCommand.BorderRadius = 6;
            this.btnAddCommand.CheckedState.Parent = this.btnAddCommand;
            this.btnAddCommand.CustomImages.Parent = this.btnAddCommand;
            this.btnAddCommand.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCommand.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCommand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCommand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddCommand.DisabledState.Parent = this.btnAddCommand;
            this.btnAddCommand.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(73)))), ((int)(((byte)(99)))));
            this.btnAddCommand.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.btnAddCommand.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.btnAddCommand.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(73)))), ((int)(((byte)(99)))));
            this.btnAddCommand.HoverState.Parent = this.btnAddCommand;
            this.btnAddCommand.Location = new System.Drawing.Point(379, 192);
            this.btnAddCommand.Name = "btnAddCommand";
            this.btnAddCommand.ShadowDecoration.Parent = this.btnAddCommand;
            this.btnAddCommand.Size = new System.Drawing.Size(61, 32);
            this.btnAddCommand.TabIndex = 5;
            this.btnAddCommand.Text = "ADD";
            this.btnAddCommand.Click += new System.EventHandler(this.btnAddCommand_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BorderRadius = 6;
            this.btnBrowse.CheckedState.Parent = this.btnBrowse;
            this.btnBrowse.CustomImages.Parent = this.btnBrowse;
            this.btnBrowse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBrowse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBrowse.DisabledState.Parent = this.btnBrowse;
            this.btnBrowse.FillColor = System.Drawing.Color.Empty;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.btnBrowse.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.btnBrowse.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(73)))), ((int)(((byte)(99)))));
            this.btnBrowse.HoverState.Parent = this.btnBrowse;
            this.btnBrowse.Location = new System.Drawing.Point(397, 148);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.ShadowDecoration.Parent = this.btnBrowse;
            this.btnBrowse.Size = new System.Drawing.Size(40, 28);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "...";
            this.btnBrowse.TextOffset = new System.Drawing.Point(0, -4);
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // checkVerification
            // 
            this.checkVerification.Animated = true;
            this.checkVerification.AutoSize = true;
            this.checkVerification.CheckedState.BorderRadius = 2;
            this.checkVerification.CheckedState.BorderThickness = 0;
            this.checkVerification.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.checkVerification.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(89)))), ((int)(((byte)(115)))));
            this.checkVerification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.checkVerification.Location = new System.Drawing.Point(19, 194);
            this.checkVerification.Name = "checkVerification";
            this.checkVerification.Size = new System.Drawing.Size(152, 19);
            this.checkVerification.TabIndex = 3;
            this.checkVerification.Text = "Should be verified";
            this.checkVerification.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.checkVerification.UncheckedState.BorderRadius = 2;
            this.checkVerification.UncheckedState.BorderThickness = 1;
            this.checkVerification.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(89)))), ((int)(((byte)(115)))));
            // 
            // comboCommandType
            // 
            this.comboCommandType.BackColor = System.Drawing.Color.Transparent;
            this.comboCommandType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.comboCommandType.BorderRadius = 6;
            this.comboCommandType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboCommandType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCommandType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(89)))), ((int)(((byte)(115)))));
            this.comboCommandType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.comboCommandType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.comboCommandType.FocusedState.Parent = this.comboCommandType;
            this.comboCommandType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboCommandType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.comboCommandType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.comboCommandType.HoverState.Parent = this.comboCommandType;
            this.comboCommandType.ItemHeight = 30;
            this.comboCommandType.Items.AddRange(new object[] {
            "Application",
            "Web Browser",
            "Terminal Command"});
            this.comboCommandType.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(73)))), ((int)(((byte)(99)))));
            this.comboCommandType.ItemsAppearance.Parent = this.comboCommandType;
            this.comboCommandType.Location = new System.Drawing.Point(275, 52);
            this.comboCommandType.Name = "comboCommandType";
            this.comboCommandType.ShadowDecoration.Parent = this.comboCommandType;
            this.comboCommandType.Size = new System.Drawing.Size(165, 36);
            this.comboCommandType.StartIndex = 0;
            this.comboCommandType.TabIndex = 2;
            this.comboCommandType.SelectedIndexChanged += new System.EventHandler(this.comboCommandType_SelectedIndexChanged);
            // 
            // txtCommandString
            // 
            this.txtCommandString.Animated = true;
            this.txtCommandString.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.txtCommandString.BorderRadius = 6;
            this.txtCommandString.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCommandString.DefaultText = "";
            this.txtCommandString.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCommandString.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCommandString.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCommandString.DisabledState.Parent = this.txtCommandString;
            this.txtCommandString.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCommandString.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(89)))), ((int)(((byte)(115)))));
            this.txtCommandString.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.txtCommandString.FocusedState.Parent = this.txtCommandString;
            this.txtCommandString.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommandString.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.txtCommandString.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.txtCommandString.HoverState.Parent = this.txtCommandString;
            this.txtCommandString.Location = new System.Drawing.Point(19, 145);
            this.txtCommandString.Name = "txtCommandString";
            this.txtCommandString.PasswordChar = '\0';
            this.txtCommandString.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtCommandString.PlaceholderText = "Application Location";
            this.txtCommandString.SelectedText = "";
            this.txtCommandString.ShadowDecoration.Parent = this.txtCommandString;
            this.txtCommandString.Size = new System.Drawing.Size(421, 34);
            this.txtCommandString.TabIndex = 1;
            // 
            // txtVoiceCommand
            // 
            this.txtVoiceCommand.Animated = true;
            this.txtVoiceCommand.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.txtVoiceCommand.BorderRadius = 6;
            this.txtVoiceCommand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVoiceCommand.DefaultText = "";
            this.txtVoiceCommand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVoiceCommand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVoiceCommand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVoiceCommand.DisabledState.Parent = this.txtVoiceCommand;
            this.txtVoiceCommand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVoiceCommand.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(89)))), ((int)(((byte)(115)))));
            this.txtVoiceCommand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.txtVoiceCommand.FocusedState.Parent = this.txtVoiceCommand;
            this.txtVoiceCommand.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoiceCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.txtVoiceCommand.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.txtVoiceCommand.HoverState.Parent = this.txtVoiceCommand;
            this.txtVoiceCommand.Location = new System.Drawing.Point(19, 54);
            this.txtVoiceCommand.Name = "txtVoiceCommand";
            this.txtVoiceCommand.PasswordChar = '\0';
            this.txtVoiceCommand.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtVoiceCommand.PlaceholderText = "Voice Command";
            this.txtVoiceCommand.SelectedText = "";
            this.txtVoiceCommand.ShadowDecoration.Parent = this.txtVoiceCommand;
            this.txtVoiceCommand.Size = new System.Drawing.Size(243, 34);
            this.txtVoiceCommand.TabIndex = 0;
            // 
            // lblVoice
            // 
            this.lblVoice.AutoSize = true;
            this.lblVoice.BackColor = System.Drawing.Color.Transparent;
            this.lblVoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVoice.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.lblVoice.Location = new System.Drawing.Point(13, 7);
            this.lblVoice.Name = "lblVoice";
            this.lblVoice.Size = new System.Drawing.Size(90, 22);
            this.lblVoice.TabIndex = 15;
            this.lblVoice.Text = "Settings";
            // 
            // grpConfig
            // 
            this.grpConfig.BackColor = System.Drawing.Color.Transparent;
            this.grpConfig.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.grpConfig.BorderRadius = 6;
            this.grpConfig.Controls.Add(this.trackTransparency);
            this.grpConfig.Controls.Add(this.trackSound);
            this.grpConfig.Controls.Add(this.picSoundIcon);
            this.grpConfig.Controls.Add(this.picAssistantIcon);
            this.grpConfig.Controls.Add(this.btnBrowseStyleJson);
            this.grpConfig.Controls.Add(this.txtStylesJson);
            this.grpConfig.Controls.Add(this.btnBrowseCmdJson);
            this.grpConfig.Controls.Add(this.comboVoice);
            this.grpConfig.Controls.Add(this.txtCommandsJson);
            this.grpConfig.Controls.Add(this.pnlTransparency);
            this.grpConfig.Controls.Add(this.picTransparencyIcon);
            this.grpConfig.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.grpConfig.FillColor = System.Drawing.Color.Transparent;
            this.grpConfig.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(73)))), ((int)(((byte)(99)))));
            this.grpConfig.Location = new System.Drawing.Point(12, 291);
            this.grpConfig.Name = "grpConfig";
            this.grpConfig.ShadowDecoration.Parent = this.grpConfig;
            this.grpConfig.Size = new System.Drawing.Size(459, 253);
            this.grpConfig.TabIndex = 12;
            this.grpConfig.Text = "Configuration";
            this.grpConfig.UseTransparentBackground = true;
            // 
            // trackTransparency
            // 
            this.trackTransparency.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(117)))), ((int)(((byte)(136)))));
            this.trackTransparency.HoverState.Parent = this.trackTransparency;
            this.trackTransparency.Location = new System.Drawing.Point(274, 111);
            this.trackTransparency.Maximum = 255;
            this.trackTransparency.Name = "trackTransparency";
            this.trackTransparency.Size = new System.Drawing.Size(166, 23);
            this.trackTransparency.TabIndex = 8;
            this.trackTransparency.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.trackTransparency.ValueChanged += new System.EventHandler(this.trackTransparency_ValueChanged);
            // 
            // trackSound
            // 
            this.trackSound.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(117)))), ((int)(((byte)(136)))));
            this.trackSound.HoverState.Parent = this.trackSound;
            this.trackSound.Location = new System.Drawing.Point(53, 111);
            this.trackSound.Name = "trackSound";
            this.trackSound.Size = new System.Drawing.Size(166, 23);
            this.trackSound.TabIndex = 8;
            this.trackSound.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.trackSound.ValueChanged += new System.EventHandler(this.trackSound_ValueChanged);
            // 
            // picSoundIcon
            // 
            this.picSoundIcon.BackgroundImage = global::Voice_Assistant.Properties.Resources.sound_48px_3;
            this.picSoundIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSoundIcon.Location = new System.Drawing.Point(19, 111);
            this.picSoundIcon.Name = "picSoundIcon";
            this.picSoundIcon.Size = new System.Drawing.Size(28, 28);
            this.picSoundIcon.TabIndex = 7;
            this.picSoundIcon.TabStop = false;
            // 
            // picAssistantIcon
            // 
            this.picAssistantIcon.BackgroundImage = global::Voice_Assistant.Properties.Resources.technical_support_48px;
            this.picAssistantIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAssistantIcon.Location = new System.Drawing.Point(19, 58);
            this.picAssistantIcon.Name = "picAssistantIcon";
            this.picAssistantIcon.Size = new System.Drawing.Size(28, 28);
            this.picAssistantIcon.TabIndex = 7;
            this.picAssistantIcon.TabStop = false;
            // 
            // btnBrowseStyleJson
            // 
            this.btnBrowseStyleJson.BorderRadius = 6;
            this.btnBrowseStyleJson.CheckedState.Parent = this.btnBrowseStyleJson;
            this.btnBrowseStyleJson.CustomImages.Parent = this.btnBrowseStyleJson;
            this.btnBrowseStyleJson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowseStyleJson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowseStyleJson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBrowseStyleJson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBrowseStyleJson.DisabledState.Parent = this.btnBrowseStyleJson;
            this.btnBrowseStyleJson.FillColor = System.Drawing.Color.Empty;
            this.btnBrowseStyleJson.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseStyleJson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.btnBrowseStyleJson.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.btnBrowseStyleJson.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(73)))), ((int)(((byte)(99)))));
            this.btnBrowseStyleJson.HoverState.Parent = this.btnBrowseStyleJson;
            this.btnBrowseStyleJson.Location = new System.Drawing.Point(397, 204);
            this.btnBrowseStyleJson.Name = "btnBrowseStyleJson";
            this.btnBrowseStyleJson.ShadowDecoration.Parent = this.btnBrowseStyleJson;
            this.btnBrowseStyleJson.Size = new System.Drawing.Size(40, 28);
            this.btnBrowseStyleJson.TabIndex = 6;
            this.btnBrowseStyleJson.Text = "...";
            this.btnBrowseStyleJson.TextOffset = new System.Drawing.Point(0, -4);
            // 
            // txtStylesJson
            // 
            this.txtStylesJson.Animated = true;
            this.txtStylesJson.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.txtStylesJson.BorderRadius = 6;
            this.txtStylesJson.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStylesJson.DefaultText = "";
            this.txtStylesJson.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStylesJson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStylesJson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStylesJson.DisabledState.Parent = this.txtStylesJson;
            this.txtStylesJson.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStylesJson.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(89)))), ((int)(((byte)(115)))));
            this.txtStylesJson.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.txtStylesJson.FocusedState.Parent = this.txtStylesJson;
            this.txtStylesJson.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStylesJson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.txtStylesJson.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.txtStylesJson.HoverState.Parent = this.txtStylesJson;
            this.txtStylesJson.Location = new System.Drawing.Point(19, 201);
            this.txtStylesJson.Name = "txtStylesJson";
            this.txtStylesJson.PasswordChar = '\0';
            this.txtStylesJson.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtStylesJson.PlaceholderText = "Styles.json Location";
            this.txtStylesJson.SelectedText = "";
            this.txtStylesJson.ShadowDecoration.Parent = this.txtStylesJson;
            this.txtStylesJson.Size = new System.Drawing.Size(421, 34);
            this.txtStylesJson.TabIndex = 5;
            // 
            // btnBrowseCmdJson
            // 
            this.btnBrowseCmdJson.BorderRadius = 6;
            this.btnBrowseCmdJson.CheckedState.Parent = this.btnBrowseCmdJson;
            this.btnBrowseCmdJson.CustomImages.Parent = this.btnBrowseCmdJson;
            this.btnBrowseCmdJson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowseCmdJson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowseCmdJson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBrowseCmdJson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBrowseCmdJson.DisabledState.Parent = this.btnBrowseCmdJson;
            this.btnBrowseCmdJson.FillColor = System.Drawing.Color.Empty;
            this.btnBrowseCmdJson.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseCmdJson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.btnBrowseCmdJson.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.btnBrowseCmdJson.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(73)))), ((int)(((byte)(99)))));
            this.btnBrowseCmdJson.HoverState.Parent = this.btnBrowseCmdJson;
            this.btnBrowseCmdJson.Location = new System.Drawing.Point(397, 154);
            this.btnBrowseCmdJson.Name = "btnBrowseCmdJson";
            this.btnBrowseCmdJson.ShadowDecoration.Parent = this.btnBrowseCmdJson;
            this.btnBrowseCmdJson.Size = new System.Drawing.Size(40, 28);
            this.btnBrowseCmdJson.TabIndex = 4;
            this.btnBrowseCmdJson.Text = "...";
            this.btnBrowseCmdJson.TextOffset = new System.Drawing.Point(0, -4);
            // 
            // comboVoice
            // 
            this.comboVoice.BackColor = System.Drawing.Color.Transparent;
            this.comboVoice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.comboVoice.BorderRadius = 6;
            this.comboVoice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVoice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(89)))), ((int)(((byte)(115)))));
            this.comboVoice.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.comboVoice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.comboVoice.FocusedState.Parent = this.comboVoice;
            this.comboVoice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboVoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.comboVoice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.comboVoice.HoverState.Parent = this.comboVoice;
            this.comboVoice.ItemHeight = 30;
            this.comboVoice.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(73)))), ((int)(((byte)(99)))));
            this.comboVoice.ItemsAppearance.Parent = this.comboVoice;
            this.comboVoice.Location = new System.Drawing.Point(57, 55);
            this.comboVoice.Name = "comboVoice";
            this.comboVoice.ShadowDecoration.Parent = this.comboVoice;
            this.comboVoice.Size = new System.Drawing.Size(383, 36);
            this.comboVoice.TabIndex = 2;
            this.comboVoice.SelectedIndexChanged += new System.EventHandler(this.ComboVoice_SelectedIndexChanged);
            // 
            // txtCommandsJson
            // 
            this.txtCommandsJson.Animated = true;
            this.txtCommandsJson.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.txtCommandsJson.BorderRadius = 6;
            this.txtCommandsJson.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCommandsJson.DefaultText = "";
            this.txtCommandsJson.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCommandsJson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCommandsJson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCommandsJson.DisabledState.Parent = this.txtCommandsJson;
            this.txtCommandsJson.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCommandsJson.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(89)))), ((int)(((byte)(115)))));
            this.txtCommandsJson.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.txtCommandsJson.FocusedState.Parent = this.txtCommandsJson;
            this.txtCommandsJson.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommandsJson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.txtCommandsJson.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.txtCommandsJson.HoverState.Parent = this.txtCommandsJson;
            this.txtCommandsJson.Location = new System.Drawing.Point(19, 151);
            this.txtCommandsJson.Name = "txtCommandsJson";
            this.txtCommandsJson.PasswordChar = '\0';
            this.txtCommandsJson.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtCommandsJson.PlaceholderText = "Commands.json Location";
            this.txtCommandsJson.SelectedText = "";
            this.txtCommandsJson.ShadowDecoration.Parent = this.txtCommandsJson;
            this.txtCommandsJson.Size = new System.Drawing.Size(421, 34);
            this.txtCommandsJson.TabIndex = 1;
            // 
            // pnlTransparency
            // 
            this.pnlTransparency.BackColor = System.Drawing.Color.Transparent;
            this.pnlTransparency.BorderRadius = 6;
            this.pnlTransparency.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.pnlTransparency.Location = new System.Drawing.Point(240, 110);
            this.pnlTransparency.Name = "pnlTransparency";
            this.pnlTransparency.ShadowDecoration.Parent = this.pnlTransparency;
            this.pnlTransparency.Size = new System.Drawing.Size(28, 29);
            this.pnlTransparency.TabIndex = 9;
            this.pnlTransparency.UseTransparentBackground = true;
            // 
            // picTransparencyIcon
            // 
            this.picTransparencyIcon.BackgroundImage = global::Voice_Assistant.Properties.Resources.diagonal_lines_48px;
            this.picTransparencyIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTransparencyIcon.Location = new System.Drawing.Point(240, 110);
            this.picTransparencyIcon.Name = "picTransparencyIcon";
            this.picTransparencyIcon.Size = new System.Drawing.Size(28, 28);
            this.picTransparencyIcon.TabIndex = 7;
            this.picTransparencyIcon.TabStop = false;
            // 
            // frmShadow
            // 
            this.frmShadow.TargetForm = this;
            // 
            // frmDrag
            // 
            this.frmDrag.TargetControl = this.picDrag;
            // 
            // picDrag
            // 
            this.picDrag.BackgroundImage = global::Voice_Assistant.Properties.Resources.horizontal_line_48px;
            this.picDrag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDrag.Location = new System.Drawing.Point(204, 0);
            this.picDrag.Name = "picDrag";
            this.picDrag.Size = new System.Drawing.Size(77, 35);
            this.picDrag.TabIndex = 7;
            this.picDrag.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.label1.Location = new System.Drawing.Point(129, 558);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "<Made with ♥️ in Sri Lanka/>";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ElipseLabel
            // 
            this.ElipseLabel.BorderRadius = 3;
            this.ElipseLabel.TargetControl = this.label1;
            // 
            // ofd
            // 
            this.ofd.DefaultExt = "exe";
            this.ofd.Filter = "Application (*.exe)|*.exe";
            this.ofd.InitialDirectory = "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(89)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(484, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpConfig);
            this.Controls.Add(this.lblVoice);
            this.Controls.Add(this.picDrag);
            this.Controls.Add(this.grpAddCommand);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSettings_FormClosing);
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.grpAddCommand.ResumeLayout(false);
            this.grpAddCommand.PerformLayout();
            this.grpConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSoundIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAssistantIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTransparencyIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDrag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse frmElipse;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2GroupBox grpAddCommand;
        private System.Windows.Forms.Label lblVoice;
        private Guna.UI2.WinForms.Guna2ComboBox comboCommandType;
        private Guna.UI2.WinForms.Guna2TextBox txtCommandString;
        private Guna.UI2.WinForms.Guna2TextBox txtVoiceCommand;
        private Guna.UI2.WinForms.Guna2CheckBox checkVerification;
        private Guna.UI2.WinForms.Guna2Button btnBrowse;
        private Guna.UI2.WinForms.Guna2GroupBox grpConfig;
        private System.Windows.Forms.PictureBox picAssistantIcon;
        private Guna.UI2.WinForms.Guna2Button btnBrowseStyleJson;
        private Guna.UI2.WinForms.Guna2TextBox txtStylesJson;
        private Guna.UI2.WinForms.Guna2Button btnBrowseCmdJson;
        private Guna.UI2.WinForms.Guna2ComboBox comboVoice;
        private Guna.UI2.WinForms.Guna2TextBox txtCommandsJson;
        private Guna.UI2.WinForms.Guna2ShadowForm frmShadow;
        private Guna.UI2.WinForms.Guna2TrackBar trackSound;
        private System.Windows.Forms.PictureBox picSoundIcon;
        private System.Windows.Forms.PictureBox picDrag;
        private Guna.UI2.WinForms.Guna2DragControl frmDrag;
        private Guna.UI2.WinForms.Guna2TrackBar trackTransparency;
        private System.Windows.Forms.PictureBox picTransparencyIcon;
        private Guna.UI2.WinForms.Guna2Panel pnlTransparency;
        private Guna.UI2.WinForms.Guna2Button btnAddCommand;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse ElipseLabel;
        private Guna.UI2.WinForms.Guna2TextBox txtAssistantReply;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}