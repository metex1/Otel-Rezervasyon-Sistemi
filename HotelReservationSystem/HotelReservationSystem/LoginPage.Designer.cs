namespace HotelReservationSystem
{
    partial class LoginPage
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
            roomPageLabel = new Label();
            loginAsManagerGroup = new GroupBox();
            loginCheckBox = new CheckBox();
            loginAsManager = new Button();
            idText = new TextBox();
            idLabel = new Label();
            passwordText = new TextBox();
            passwordLabel = new Label();
            resetPasswordGroup = new GroupBox();
            resetCheckBox = new CheckBox();
            keywordText = new TextBox();
            keywordLabel = new Label();
            resetIDText = new TextBox();
            resetIDLabel = new Label();
            newPasswordText = new TextBox();
            resetPassword = new Button();
            newPasswordLabel = new Label();
            dateLabel = new Label();
            loginAsManagerGroup.SuspendLayout();
            resetPasswordGroup.SuspendLayout();
            SuspendLayout();
            // 
            // roomPageLabel
            // 
            roomPageLabel.AutoSize = true;
            roomPageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            roomPageLabel.Location = new Point(795, 9);
            roomPageLabel.Name = "roomPageLabel";
            roomPageLabel.Size = new Size(209, 28);
            roomPageLabel.TabIndex = 7;
            roomPageLabel.Text = "Yönetici Giriş Sayfası";
            roomPageLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // loginAsManagerGroup
            // 
            loginAsManagerGroup.Controls.Add(loginCheckBox);
            loginAsManagerGroup.Controls.Add(loginAsManager);
            loginAsManagerGroup.Controls.Add(idText);
            loginAsManagerGroup.Controls.Add(idLabel);
            loginAsManagerGroup.Controls.Add(passwordText);
            loginAsManagerGroup.Controls.Add(passwordLabel);
            loginAsManagerGroup.Location = new Point(450, 165);
            loginAsManagerGroup.Name = "loginAsManagerGroup";
            loginAsManagerGroup.Size = new Size(250, 269);
            loginAsManagerGroup.TabIndex = 9;
            loginAsManagerGroup.TabStop = false;
            loginAsManagerGroup.Text = "Yönetici Girişi Yap";
            // 
            // loginCheckBox
            // 
            loginCheckBox.AutoSize = true;
            loginCheckBox.Location = new Point(66, 204);
            loginCheckBox.Name = "loginCheckBox";
            loginCheckBox.Size = new Size(168, 24);
            loginCheckBox.TabIndex = 12;
            loginCheckBox.Text = "Hassas Bilgileri Gizle";
            loginCheckBox.UseVisualStyleBackColor = true;
            loginCheckBox.CheckedChanged += loginCheckBox_CheckedChanged;
            // 
            // loginAsManager
            // 
            loginAsManager.Location = new Point(0, 234);
            loginAsManager.Name = "loginAsManager";
            loginAsManager.Size = new Size(250, 35);
            loginAsManager.TabIndex = 6;
            loginAsManager.Text = "Giriş Yap";
            loginAsManager.UseVisualStyleBackColor = true;
            loginAsManager.Click += loginAsManager_Click;
            // 
            // idText
            // 
            idText.Location = new Point(119, 75);
            idText.Name = "idText";
            idText.Size = new Size(125, 27);
            idText.TabIndex = 5;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(22, 75);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(74, 20);
            idLabel.TabIndex = 4;
            idLabel.Text = "Kimlik No";
            // 
            // passwordText
            // 
            passwordText.Location = new Point(119, 165);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(125, 27);
            passwordText.TabIndex = 2;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(22, 165);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(39, 20);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "Şifre";
            // 
            // resetPasswordGroup
            // 
            resetPasswordGroup.Controls.Add(resetCheckBox);
            resetPasswordGroup.Controls.Add(keywordText);
            resetPasswordGroup.Controls.Add(keywordLabel);
            resetPasswordGroup.Controls.Add(resetIDText);
            resetPasswordGroup.Controls.Add(resetIDLabel);
            resetPasswordGroup.Controls.Add(newPasswordText);
            resetPasswordGroup.Controls.Add(resetPassword);
            resetPasswordGroup.Controls.Add(newPasswordLabel);
            resetPasswordGroup.Location = new Point(1100, 165);
            resetPasswordGroup.Name = "resetPasswordGroup";
            resetPasswordGroup.Size = new Size(291, 269);
            resetPasswordGroup.TabIndex = 10;
            resetPasswordGroup.TabStop = false;
            resetPasswordGroup.Text = "Yönetici Şifresi Sıfırlama";
            // 
            // resetCheckBox
            // 
            resetCheckBox.AutoSize = true;
            resetCheckBox.Location = new Point(107, 210);
            resetCheckBox.Name = "resetCheckBox";
            resetCheckBox.Size = new Size(168, 24);
            resetCheckBox.TabIndex = 13;
            resetCheckBox.Text = "Hassas Bilgileri Gizle";
            resetCheckBox.UseVisualStyleBackColor = true;
            resetCheckBox.CheckedChanged += resetCheckBox_CheckedChanged;
            // 
            // keywordText
            // 
            keywordText.Location = new Point(160, 120);
            keywordText.Name = "keywordText";
            keywordText.Size = new Size(125, 27);
            keywordText.TabIndex = 11;
            // 
            // keywordLabel
            // 
            keywordLabel.AutoSize = true;
            keywordLabel.Location = new Point(22, 120);
            keywordLabel.Name = "keywordLabel";
            keywordLabel.Size = new Size(111, 20);
            keywordLabel.TabIndex = 10;
            keywordLabel.Text = "Anahtar Kelime";
            // 
            // resetIDText
            // 
            resetIDText.Location = new Point(160, 60);
            resetIDText.Name = "resetIDText";
            resetIDText.Size = new Size(125, 27);
            resetIDText.TabIndex = 5;
            // 
            // resetIDLabel
            // 
            resetIDLabel.AutoSize = true;
            resetIDLabel.Location = new Point(22, 60);
            resetIDLabel.Name = "resetIDLabel";
            resetIDLabel.Size = new Size(74, 20);
            resetIDLabel.TabIndex = 4;
            resetIDLabel.Text = "Kimlik No";
            // 
            // newPasswordText
            // 
            newPasswordText.Location = new Point(160, 180);
            newPasswordText.Name = "newPasswordText";
            newPasswordText.Size = new Size(125, 27);
            newPasswordText.TabIndex = 2;
            // 
            // resetPassword
            // 
            resetPassword.Location = new Point(0, 240);
            resetPassword.Name = "resetPassword";
            resetPassword.Size = new Size(291, 29);
            resetPassword.TabIndex = 9;
            resetPassword.Text = "Şifre Sıfırla";
            resetPassword.UseVisualStyleBackColor = true;
            resetPassword.Click += resetPassword_Click;
            // 
            // newPasswordLabel
            // 
            newPasswordLabel.AutoSize = true;
            newPasswordLabel.Location = new Point(22, 180);
            newPasswordLabel.Name = "newPasswordLabel";
            newPasswordLabel.Size = new Size(70, 20);
            newPasswordLabel.TabIndex = 0;
            newPasswordLabel.Text = "Yeni Şifre";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(1685, 9);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(85, 20);
            dateLabel.TabIndex = 11;
            dateLabel.Text = "2012-12-12";
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1782, 553);
            Controls.Add(dateLabel);
            Controls.Add(resetPasswordGroup);
            Controls.Add(loginAsManagerGroup);
            Controls.Add(roomPageLabel);
            Name = "LoginPage";
            Text = "LoginPage";
            Load += LoginPage_Load;
            loginAsManagerGroup.ResumeLayout(false);
            loginAsManagerGroup.PerformLayout();
            resetPasswordGroup.ResumeLayout(false);
            resetPasswordGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label roomPageLabel;
        private GroupBox loginAsManagerGroup;
        private TextBox idText;
        private Label idLabel;
        private TextBox priceText;
        private TextBox passwordText;
        private Button createRoom;
        private Label priceLabel;
        private Label passwordLabel;
        private GroupBox resetPasswordGroup;
        private TextBox resetIDText;
        private Label resetIDLabel;
        private TextBox newPasswordText;
        private Button resetPassword;
        private Label newPasswordLabel;
        private TextBox keywordText;
        private Label keywordLabel;
        private Label dateLabel;
        private Button loginAsManager;
        private CheckBox loginCheckBox;
        private CheckBox resetCheckBox;
    }
}