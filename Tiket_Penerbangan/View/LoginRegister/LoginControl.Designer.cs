namespace Tiket_Penerbangan.LoginRegister
{
    partial class LoginControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.signUplink = new System.Windows.Forms.LinkLabel();
            this.loginButton = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            this.revealPassword = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.emailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.signUplink);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(40, 363);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(268, 19);
            this.flowLayoutPanel1.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Don\'t have an account";
            // 
            // signUplink
            // 
            this.signUplink.ActiveLinkColor = System.Drawing.Color.Red;
            this.signUplink.AutoSize = true;
            this.signUplink.Location = new System.Drawing.Point(140, 0);
            this.signUplink.Name = "signUplink";
            this.signUplink.Size = new System.Drawing.Size(55, 16);
            this.signUplink.TabIndex = 1;
            this.signUplink.TabStop = true;
            this.signUplink.Text = "Sign Up";
            this.signUplink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUplink_LinkClicked);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BorderRadius = 10;
            this.loginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.loginButton.Location = new System.Drawing.Point(40, 415);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(438, 46);
            this.loginButton.TabIndex = 38;
            this.loginButton.Text = "Login";
            this.loginButton.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(120, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 44);
            this.label1.TabIndex = 35;
            this.label1.Text = "Welcome Back!";
            // 
            // cuiPictureBox1
            // 
            this.cuiPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox1.Content = global::Tiket_Penerbangan.Properties.Resources.Desain_tanpa_judul;
            this.cuiPictureBox1.CornerRadius = 0;
            this.cuiPictureBox1.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox1.Location = new System.Drawing.Point(158, 16);
            this.cuiPictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cuiPictureBox1.Name = "cuiPictureBox1";
            this.cuiPictureBox1.OutlineThickness = 1F;
            this.cuiPictureBox1.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox1.Rotation = 0;
            this.cuiPictureBox1.Size = new System.Drawing.Size(193, 164);
            this.cuiPictureBox1.TabIndex = 42;
            // 
            // revealPassword
            // 
            this.revealPassword.BackColor = System.Drawing.Color.Transparent;
            this.revealPassword.CheckedState.Image = global::Tiket_Penerbangan.Properties.Resources.icons8_eye_50;
            this.revealPassword.Image = global::Tiket_Penerbangan.Properties.Resources.icons8_closed_eye_30;
            this.revealPassword.ImageOffset = new System.Drawing.Point(0, 0);
            this.revealPassword.ImageRotate = 0F;
            this.revealPassword.Location = new System.Drawing.Point(454, 296);
            this.revealPassword.Name = "revealPassword";
            this.revealPassword.Size = new System.Drawing.Size(24, 24);
            this.revealPassword.TabIndex = 40;
            this.revealPassword.UseTransparentBackground = true;
            this.revealPassword.CheckedChanged += new System.EventHandler(this.revealPasswordS);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Animated = true;
            this.emailTextBox.BackColor = System.Drawing.Color.Transparent;
            this.emailTextBox.BorderRadius = 8;
            this.emailTextBox.BorderThickness = 0;
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.DefaultText = "";
            this.emailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.emailTextBox.FocusedState.FillColor = System.Drawing.Color.Transparent;
            this.emailTextBox.FocusedState.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailTextBox.ForeColor = System.Drawing.Color.Black;
            this.emailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.IconLeft = global::Tiket_Penerbangan.Properties.Resources.icons8_email_30;
            this.emailTextBox.Location = new System.Drawing.Point(40, 205);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 5);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.emailTextBox.PlaceholderText = "Email";
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.Size = new System.Drawing.Size(438, 47);
            this.emailTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.emailTextBox.TabIndex = 37;
            this.emailTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextEmailValidate);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Animated = true;
            this.passwordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.passwordTextBox.BorderRadius = 8;
            this.passwordTextBox.BorderThickness = 0;
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.DefaultText = "";
            this.passwordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox.IconLeft = global::Tiket_Penerbangan.Properties.Resources.icons8_lock_30;
            this.passwordTextBox.Location = new System.Drawing.Point(40, 285);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 5);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.passwordTextBox.PlaceholderText = "Password";
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.Size = new System.Drawing.Size(438, 47);
            this.passwordTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.passwordTextBox.TabIndex = 36;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextPasswordValidate);
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cuiPictureBox1);
            this.Controls.Add(this.revealPassword);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginButton);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(518, 522);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel signUplink;
        private Guna.UI2.WinForms.Guna2ImageCheckBox revealPassword;
        private Guna.UI2.WinForms.Guna2Button loginButton;
        private Guna.UI2.WinForms.Guna2TextBox emailTextBox;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
    }
}
