
namespace Voice_Assistant
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.frmElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.frmShadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblVoice = new System.Windows.Forms.Label();
            this.lblMic = new System.Windows.Forms.Label();
            this.timerReset = new System.Windows.Forms.Timer(this.components);
            this.pnlElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.picIconVoice = new System.Windows.Forms.PictureBox();
            this.btnMic = new Guna.UI2.WinForms.Guna2CircleButton();
            this.soundWave = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnPin = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.picIconVoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundWave)).BeginInit();
            this.SuspendLayout();
            // 
            // frmElipse
            // 
            this.frmElipse.BorderRadius = 7;
            this.frmElipse.TargetControl = this;
            // 
            // frmShadow
            // 
            this.frmShadow.BorderRadius = 6;
            this.frmShadow.TargetForm = this;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 6;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.btnClose.Location = new System.Drawing.Point(317, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(45, 33);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseTransparentBackground = true;
            // 
            // lblVoice
            // 
            this.lblVoice.AutoSize = true;
            this.lblVoice.BackColor = System.Drawing.Color.Transparent;
            this.lblVoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVoice.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.lblVoice.Location = new System.Drawing.Point(126, 205);
            this.lblVoice.Name = "lblVoice";
            this.lblVoice.Size = new System.Drawing.Size(120, 22);
            this.lblVoice.TabIndex = 14;
            this.lblVoice.Text = "Hello there";
            this.lblVoice.TextChanged += new System.EventHandler(this.lblVoice_TextChanged);
            // 
            // lblMic
            // 
            this.lblMic.AutoEllipsis = true;
            this.lblMic.BackColor = System.Drawing.Color.Transparent;
            this.lblMic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMic.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMic.ForeColor = System.Drawing.Color.White;
            this.lblMic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMic.Location = new System.Drawing.Point(231, 78);
            this.lblMic.Name = "lblMic";
            this.lblMic.Size = new System.Drawing.Size(114, 75);
            this.lblMic.TabIndex = 16;
            this.lblMic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMic.TextChanged += new System.EventHandler(this.lblVoice_TextChanged);
            // 
            // timerReset
            // 
            this.timerReset.Interval = 1250;
            this.timerReset.Tick += new System.EventHandler(this.timerReset_Tick);
            // 
            // picIconVoice
            // 
            this.picIconVoice.BackColor = System.Drawing.Color.Transparent;
            this.picIconVoice.BackgroundImage = global::Voice_Assistant.Properties.Resources.so_so_48px;
            this.picIconVoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picIconVoice.Location = new System.Drawing.Point(90, 202);
            this.picIconVoice.Name = "picIconVoice";
            this.picIconVoice.Size = new System.Drawing.Size(28, 28);
            this.picIconVoice.TabIndex = 16;
            this.picIconVoice.TabStop = false;
            // 
            // btnMic
            // 
            this.btnMic.BackColor = System.Drawing.Color.Transparent;
            this.btnMic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.btnMic.BorderThickness = 3;
            this.btnMic.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnMic.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.btnMic.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.btnMic.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnMic.CheckedState.Parent = this.btnMic;
            this.btnMic.CustomImages.Parent = this.btnMic;
            this.btnMic.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMic.DisabledState.Parent = this.btnMic;
            this.btnMic.FillColor = System.Drawing.Color.Transparent;
            this.btnMic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMic.ForeColor = System.Drawing.Color.White;
            this.btnMic.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnMic.HoverState.Parent = this.btnMic;
            this.btnMic.Image = ((System.Drawing.Image)(resources.GetObject("btnMic.Image")));
            this.btnMic.ImageOffset = new System.Drawing.Point(0, 2);
            this.btnMic.ImageSize = new System.Drawing.Size(38, 38);
            this.btnMic.Location = new System.Drawing.Point(133, 70);
            this.btnMic.Name = "btnMic";
            this.btnMic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMic.ShadowDecoration.Parent = this.btnMic;
            this.btnMic.Size = new System.Drawing.Size(89, 89);
            this.btnMic.TabIndex = 15;
            this.btnMic.UseTransparentBackground = true;
            this.btnMic.CheckedChanged += new System.EventHandler(this.btnMic_CheckedChanged);
            this.btnMic.Click += new System.EventHandler(this.btnMic_Click);
            // 
            // soundWave
            // 
            this.soundWave.BackColor = System.Drawing.Color.Transparent;
            this.soundWave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.soundWave.Image = ((System.Drawing.Image)(resources.GetObject("soundWave.Image")));
            this.soundWave.ImageRotate = 0F;
            this.soundWave.Location = new System.Drawing.Point(-21, 61);
            this.soundWave.Name = "soundWave";
            this.soundWave.ShadowDecoration.Parent = this.soundWave;
            this.soundWave.Size = new System.Drawing.Size(185, 104);
            this.soundWave.TabIndex = 11;
            this.soundWave.TabStop = false;
            this.soundWave.UseTransparentBackground = true;
            this.soundWave.Visible = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BorderRadius = 6;
            this.btnSettings.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            this.btnSettings.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnSettings.CheckedState.Parent = this.btnSettings;
            this.btnSettings.CustomImages.Parent = this.btnSettings;
            this.btnSettings.CustomizableEdges.BottomLeft = false;
            this.btnSettings.CustomizableEdges.TopLeft = false;
            this.btnSettings.CustomizableEdges.TopRight = false;
            this.btnSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSettings.DisabledState.Parent = this.btnSettings;
            this.btnSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(189)))), ((int)(((byte)(203)))));
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.HoverState.Parent = this.btnSettings;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(181, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.ShadowDecoration.Depth = 6;
            this.btnSettings.ShadowDecoration.Enabled = true;
            this.btnSettings.ShadowDecoration.Parent = this.btnSettings;
            this.btnSettings.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(6);
            this.btnSettings.Size = new System.Drawing.Size(45, 33);
            this.btnSettings.TabIndex = 13;
            this.btnSettings.UseTransparentBackground = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnPin
            // 
            this.btnPin.BackColor = System.Drawing.Color.Transparent;
            this.btnPin.BorderRadius = 6;
            this.btnPin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            this.btnPin.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnPin.CheckedState.Parent = this.btnPin;
            this.btnPin.CustomImages.Parent = this.btnPin;
            this.btnPin.CustomizableEdges.BottomRight = false;
            this.btnPin.CustomizableEdges.TopLeft = false;
            this.btnPin.CustomizableEdges.TopRight = false;
            this.btnPin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPin.DisabledState.Parent = this.btnPin;
            this.btnPin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(189)))), ((int)(((byte)(203)))));
            this.btnPin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPin.ForeColor = System.Drawing.Color.White;
            this.btnPin.HoverState.Parent = this.btnPin;
            this.btnPin.Image = ((System.Drawing.Image)(resources.GetObject("btnPin.Image")));
            this.btnPin.Location = new System.Drawing.Point(137, 0);
            this.btnPin.Name = "btnPin";
            this.btnPin.ShadowDecoration.Depth = 6;
            this.btnPin.ShadowDecoration.Enabled = true;
            this.btnPin.ShadowDecoration.Parent = this.btnPin;
            this.btnPin.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(6);
            this.btnPin.Size = new System.Drawing.Size(45, 33);
            this.btnPin.TabIndex = 12;
            this.btnPin.UseTransparentBackground = true;
            this.btnPin.Click += new System.EventHandler(this.btnPin_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(363, 253);
            this.Controls.Add(this.btnMic);
            this.Controls.Add(this.picIconVoice);
            this.Controls.Add(this.lblMic);
            this.Controls.Add(this.lblVoice);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPin);
            this.Controls.Add(this.soundWave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1000, 500);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIconVoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundWave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse frmElipse;
        private Guna.UI2.WinForms.Guna2ShadowForm frmShadow;
        private Guna.UI2.WinForms.Guna2Button btnPin;
        private Guna.UI2.WinForms.Guna2PictureBox soundWave;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private System.Windows.Forms.Label lblVoice;
        private Guna.UI2.WinForms.Guna2CircleButton btnMic;
        private System.Windows.Forms.Label lblMic;
        private System.Windows.Forms.Timer timerReset;
        private Guna.UI2.WinForms.Guna2Elipse pnlElipse;
        private System.Windows.Forms.PictureBox picIconVoice;
    }
}

