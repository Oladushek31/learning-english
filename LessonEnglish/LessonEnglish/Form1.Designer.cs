namespace LessonEnglish
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.startLoginButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.logo2Label = new System.Windows.Forms.Label();
            this.logo1Label = new System.Windows.Forms.Label();
            this.authorizationLabel = new System.Windows.Forms.Label();
            this.closePasswordPictureBox = new System.Windows.Forms.PictureBox();
            this.openPasswordPictureBox = new System.Windows.Forms.PictureBox();
            this.logo1PictureBox = new System.Windows.Forms.PictureBox();
            this.recoveryLinkLabel = new System.Windows.Forms.LinkLabel();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePasswordPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openPasswordPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo1PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(24, 180);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(79, 26);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Логин:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(9, 218);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(96, 26);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Пароль:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(105, 181);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginTextBox.Multiline = true;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(161, 25);
            this.loginTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(105, 219);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(161, 25);
            this.passwordTextBox.TabIndex = 4;
            // 
            // startLoginButton
            // 
            this.startLoginButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLoginButton.Location = new System.Drawing.Point(105, 285);
            this.startLoginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startLoginButton.Name = "startLoginButton";
            this.startLoginButton.Size = new System.Drawing.Size(112, 41);
            this.startLoginButton.TabIndex = 5;
            this.startLoginButton.Text = "Войти";
            this.startLoginButton.UseVisualStyleBackColor = true;
            this.startLoginButton.Click += new System.EventHandler(this.startLoginButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.Controls.Add(this.logo2Label);
            this.logoPanel.Controls.Add(this.logo1Label);
            this.logoPanel.Location = new System.Drawing.Point(88, 19);
            this.logoPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(226, 85);
            this.logoPanel.TabIndex = 7;
            // 
            // logo2Label
            // 
            this.logo2Label.AutoSize = true;
            this.logo2Label.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logo2Label.Location = new System.Drawing.Point(3, 44);
            this.logo2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logo2Label.Name = "logo2Label";
            this.logo2Label.Size = new System.Drawing.Size(232, 38);
            this.logo2Label.TabIndex = 8;
            this.logo2Label.Text = "Английского языка";
            // 
            // logo1Label
            // 
            this.logo1Label.AutoSize = true;
            this.logo1Label.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logo1Label.Location = new System.Drawing.Point(2, 4);
            this.logo1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logo1Label.Name = "logo1Label";
            this.logo1Label.Size = new System.Drawing.Size(84, 38);
            this.logo1Label.TabIndex = 0;
            this.logo1Label.Text = "Уроки";
            this.logo1Label.Click += new System.EventHandler(this.logoLabel_Click);
            // 
            // authorizationLabel
            // 
            this.authorizationLabel.AutoSize = true;
            this.authorizationLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorizationLabel.Location = new System.Drawing.Point(75, 127);
            this.authorizationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.authorizationLabel.Name = "authorizationLabel";
            this.authorizationLabel.Size = new System.Drawing.Size(178, 32);
            this.authorizationLabel.TabIndex = 10;
            this.authorizationLabel.Text = "Авторизация";
            // 
            // closePasswordPictureBox
            // 
            this.closePasswordPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.closePasswordPictureBox.Image = global::LessonEnglish.Properties.Resources.visible_and_invisible_password_concept_eye_line_icon_set_open_closed_eyes_private_symbol_illustrations_free_vector__1_;
            this.closePasswordPictureBox.Location = new System.Drawing.Point(269, 219);
            this.closePasswordPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closePasswordPictureBox.Name = "closePasswordPictureBox";
            this.closePasswordPictureBox.Size = new System.Drawing.Size(22, 24);
            this.closePasswordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePasswordPictureBox.TabIndex = 9;
            this.closePasswordPictureBox.TabStop = false;
            this.closePasswordPictureBox.Click += new System.EventHandler(this.closePasswordPictureBox_Click);
            // 
            // openPasswordPictureBox
            // 
            this.openPasswordPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.openPasswordPictureBox.Image = global::LessonEnglish.Properties.Resources.visible_and_invisible_password_concept_eye_line_icon_set_open_closed_eyes_private_symbol_illustrations_free_vector;
            this.openPasswordPictureBox.Location = new System.Drawing.Point(269, 219);
            this.openPasswordPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.openPasswordPictureBox.Name = "openPasswordPictureBox";
            this.openPasswordPictureBox.Size = new System.Drawing.Size(22, 24);
            this.openPasswordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.openPasswordPictureBox.TabIndex = 8;
            this.openPasswordPictureBox.TabStop = false;
            this.openPasswordPictureBox.Click += new System.EventHandler(this.openPasswordPictureBox_Click);
            // 
            // logo1PictureBox
            // 
            this.logo1PictureBox.Image = global::LessonEnglish.Properties.Resources.a76c1d09_f59b_455e_970c_e616358c804b;
            this.logo1PictureBox.Location = new System.Drawing.Point(9, 23);
            this.logo1PictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logo1PictureBox.Name = "logo1PictureBox";
            this.logo1PictureBox.Size = new System.Drawing.Size(75, 81);
            this.logo1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo1PictureBox.TabIndex = 6;
            this.logo1PictureBox.TabStop = false;
            // 
            // recoveryLinkLabel
            // 
            this.recoveryLinkLabel.AutoSize = true;
            this.recoveryLinkLabel.DisabledLinkColor = System.Drawing.Color.Silver;
            this.recoveryLinkLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoveryLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.recoveryLinkLabel.Location = new System.Drawing.Point(132, 328);
            this.recoveryLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.recoveryLinkLabel.Name = "recoveryLinkLabel";
            this.recoveryLinkLabel.Size = new System.Drawing.Size(72, 14);
            this.recoveryLinkLabel.TabIndex = 22;
            this.recoveryLinkLabel.TabStop = true;
            this.recoveryLinkLabel.Text = "Регистрация";
            this.recoveryLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.recoveryLinkLabel_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(324, 368);
            this.Controls.Add(this.recoveryLinkLabel);
            this.Controls.Add(this.authorizationLabel);
            this.Controls.Add(this.closePasswordPictureBox);
            this.Controls.Add(this.openPasswordPictureBox);
            this.Controls.Add(this.logoPanel);
            this.Controls.Add(this.logo1PictureBox);
            this.Controls.Add(this.startLoginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePasswordPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openPasswordPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo1PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button startLoginButton;
        private System.Windows.Forms.PictureBox logo1PictureBox;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Label logo1Label;
        private System.Windows.Forms.Label logo2Label;
        private System.Windows.Forms.PictureBox openPasswordPictureBox;
        private System.Windows.Forms.PictureBox closePasswordPictureBox;
        private System.Windows.Forms.Label authorizationLabel;
        private System.Windows.Forms.LinkLabel recoveryLinkLabel;
    }
}

