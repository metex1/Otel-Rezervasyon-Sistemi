namespace HotelReservationSystem
{
    partial class ManagerPage
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
            createManagerGroup = new GroupBox();
            createManager = new Button();
            accessLevelText = new TextBox();
            keywordText = new TextBox();
            passwordText = new TextBox();
            positionText = new TextBox();
            accessLevelLabel = new Label();
            keywordLabel = new Label();
            passwordLabel = new Label();
            positionLabel = new Label();
            phoneNumberText = new TextBox();
            idText = new TextBox();
            surnameText = new TextBox();
            nameText = new TextBox();
            phoneNumberLabel = new Label();
            idLabel = new Label();
            surnameLabel = new Label();
            nameLabel = new Label();
            dateLabel = new Label();
            signedAsLabel = new Label();
            editManagerGroup = new GroupBox();
            editManager = new Button();
            editAccessLevelText = new TextBox();
            editKeywordText = new TextBox();
            editPasswordText = new TextBox();
            editPositionText = new TextBox();
            editAccessLevelLabel = new Label();
            editKeywordLabel = new Label();
            editPasswordLabel = new Label();
            editPositionLabel = new Label();
            editPhoneNumberText = new TextBox();
            editSurnameText = new TextBox();
            editNameText = new TextBox();
            managerIDText = new TextBox();
            editPhoneNumberLabel = new Label();
            editSurnameLabel = new Label();
            editNameLabel = new Label();
            managerIDLabel = new Label();
            reservationManagement = new Button();
            roomManagement = new Button();
            customerManagement = new Button();
            billManagement = new Button();
            deleteManagerGroup = new GroupBox();
            deleteManager = new Button();
            deleteManagerIDText = new TextBox();
            deleteManagerIDLabel = new Label();
            showManagerGroup = new GroupBox();
            getManagerSpesific = new Button();
            getManagerIDText = new TextBox();
            getManagerIDLabel = new Label();
            signOutButton = new Button();
            managersList = new ListView();
            createManagerGroup.SuspendLayout();
            editManagerGroup.SuspendLayout();
            deleteManagerGroup.SuspendLayout();
            showManagerGroup.SuspendLayout();
            SuspendLayout();
            // 
            // roomPageLabel
            // 
            roomPageLabel.AutoSize = true;
            roomPageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            roomPageLabel.Location = new Point(775, 9);
            roomPageLabel.Name = "roomPageLabel";
            roomPageLabel.Size = new Size(249, 28);
            roomPageLabel.TabIndex = 8;
            roomPageLabel.Text = "Yönetici Yönetimi Sayfası";
            roomPageLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // createManagerGroup
            // 
            createManagerGroup.Controls.Add(createManager);
            createManagerGroup.Controls.Add(accessLevelText);
            createManagerGroup.Controls.Add(keywordText);
            createManagerGroup.Controls.Add(passwordText);
            createManagerGroup.Controls.Add(positionText);
            createManagerGroup.Controls.Add(accessLevelLabel);
            createManagerGroup.Controls.Add(keywordLabel);
            createManagerGroup.Controls.Add(passwordLabel);
            createManagerGroup.Controls.Add(positionLabel);
            createManagerGroup.Controls.Add(phoneNumberText);
            createManagerGroup.Controls.Add(idText);
            createManagerGroup.Controls.Add(surnameText);
            createManagerGroup.Controls.Add(nameText);
            createManagerGroup.Controls.Add(phoneNumberLabel);
            createManagerGroup.Controls.Add(idLabel);
            createManagerGroup.Controls.Add(surnameLabel);
            createManagerGroup.Controls.Add(nameLabel);
            createManagerGroup.Location = new Point(179, 92);
            createManagerGroup.Name = "createManagerGroup";
            createManagerGroup.Size = new Size(532, 268);
            createManagerGroup.TabIndex = 9;
            createManagerGroup.TabStop = false;
            createManagerGroup.Text = "Yönetici Oluştur";
            // 
            // createManager
            // 
            createManager.Location = new Point(0, 239);
            createManager.Name = "createManager";
            createManager.Size = new Size(532, 29);
            createManager.TabIndex = 10;
            createManager.Text = "Yönetici Oluştur";
            createManager.UseVisualStyleBackColor = true;
            createManager.Click += createManager_Click;
            // 
            // accessLevelText
            // 
            accessLevelText.Location = new Point(385, 180);
            accessLevelText.Name = "accessLevelText";
            accessLevelText.Size = new Size(125, 27);
            accessLevelText.TabIndex = 15;
            // 
            // keywordText
            // 
            keywordText.Location = new Point(385, 135);
            keywordText.Name = "keywordText";
            keywordText.Size = new Size(125, 27);
            keywordText.TabIndex = 14;
            // 
            // passwordText
            // 
            passwordText.Location = new Point(385, 90);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(125, 27);
            passwordText.TabIndex = 13;
            // 
            // positionText
            // 
            positionText.Location = new Point(385, 45);
            positionText.Name = "positionText";
            positionText.Size = new Size(125, 27);
            positionText.TabIndex = 12;
            // 
            // accessLevelLabel
            // 
            accessLevelLabel.AutoSize = true;
            accessLevelLabel.Location = new Point(266, 180);
            accessLevelLabel.Name = "accessLevelLabel";
            accessLevelLabel.Size = new Size(98, 20);
            accessLevelLabel.TabIndex = 11;
            accessLevelLabel.Text = "Erişim Düzeyi";
            // 
            // keywordLabel
            // 
            keywordLabel.AutoSize = true;
            keywordLabel.Location = new Point(266, 135);
            keywordLabel.Name = "keywordLabel";
            keywordLabel.Size = new Size(111, 20);
            keywordLabel.TabIndex = 10;
            keywordLabel.Text = "Anahtar Kelime";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(266, 90);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(39, 20);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "Şifre";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new Point(266, 45);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(66, 20);
            positionLabel.TabIndex = 8;
            positionLabel.Text = "Pozisyon";
            // 
            // phoneNumberText
            // 
            phoneNumberText.Location = new Point(119, 180);
            phoneNumberText.Name = "phoneNumberText";
            phoneNumberText.Size = new Size(125, 27);
            phoneNumberText.TabIndex = 7;
            // 
            // idText
            // 
            idText.Location = new Point(119, 135);
            idText.Name = "idText";
            idText.Size = new Size(125, 27);
            idText.TabIndex = 6;
            // 
            // surnameText
            // 
            surnameText.Location = new Point(119, 90);
            surnameText.Name = "surnameText";
            surnameText.Size = new Size(125, 27);
            surnameText.TabIndex = 5;
            // 
            // nameText
            // 
            nameText.Location = new Point(119, 45);
            nameText.Name = "nameText";
            nameText.Size = new Size(125, 27);
            nameText.TabIndex = 4;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(22, 180);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(52, 20);
            phoneNumberLabel.TabIndex = 3;
            phoneNumberLabel.Text = "Tel No";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(22, 135);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(74, 20);
            idLabel.TabIndex = 2;
            idLabel.Text = "Kimlik No";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new Point(22, 90);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(50, 20);
            surnameLabel.TabIndex = 1;
            surnameLabel.Text = "Soyad";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(22, 45);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(28, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Ad";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(1685, 9);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(85, 20);
            dateLabel.TabIndex = 10;
            dateLabel.Text = "2012-12-12";
            // 
            // signedAsLabel
            // 
            signedAsLabel.AutoSize = true;
            signedAsLabel.Location = new Point(1427, 9);
            signedAsLabel.Name = "signedAsLabel";
            signedAsLabel.Size = new Size(202, 20);
            signedAsLabel.TabIndex = 11;
            signedAsLabel.Text = ".......... .......... olarak giriş yapıldı.";
            // 
            // editManagerGroup
            // 
            editManagerGroup.Controls.Add(editManager);
            editManagerGroup.Controls.Add(editAccessLevelText);
            editManagerGroup.Controls.Add(editKeywordText);
            editManagerGroup.Controls.Add(editPasswordText);
            editManagerGroup.Controls.Add(editPositionText);
            editManagerGroup.Controls.Add(editAccessLevelLabel);
            editManagerGroup.Controls.Add(editKeywordLabel);
            editManagerGroup.Controls.Add(editPasswordLabel);
            editManagerGroup.Controls.Add(editPositionLabel);
            editManagerGroup.Controls.Add(editPhoneNumberText);
            editManagerGroup.Controls.Add(editSurnameText);
            editManagerGroup.Controls.Add(editNameText);
            editManagerGroup.Controls.Add(managerIDText);
            editManagerGroup.Controls.Add(editPhoneNumberLabel);
            editManagerGroup.Controls.Add(editSurnameLabel);
            editManagerGroup.Controls.Add(editNameLabel);
            editManagerGroup.Controls.Add(managerIDLabel);
            editManagerGroup.Location = new Point(864, 92);
            editManagerGroup.Name = "editManagerGroup";
            editManagerGroup.Size = new Size(532, 268);
            editManagerGroup.TabIndex = 16;
            editManagerGroup.TabStop = false;
            editManagerGroup.Text = "Yönetici Düzenle";
            // 
            // editManager
            // 
            editManager.Location = new Point(0, 239);
            editManager.Name = "editManager";
            editManager.Size = new Size(532, 29);
            editManager.TabIndex = 10;
            editManager.Text = "Yöneticiyi Düzenle";
            editManager.UseVisualStyleBackColor = true;
            editManager.Click += editManager_Click;
            // 
            // editAccessLevelText
            // 
            editAccessLevelText.Location = new Point(385, 180);
            editAccessLevelText.Name = "editAccessLevelText";
            editAccessLevelText.Size = new Size(125, 27);
            editAccessLevelText.TabIndex = 15;
            // 
            // editKeywordText
            // 
            editKeywordText.Location = new Point(385, 135);
            editKeywordText.Name = "editKeywordText";
            editKeywordText.Size = new Size(125, 27);
            editKeywordText.TabIndex = 14;
            // 
            // editPasswordText
            // 
            editPasswordText.Location = new Point(385, 90);
            editPasswordText.Name = "editPasswordText";
            editPasswordText.Size = new Size(125, 27);
            editPasswordText.TabIndex = 13;
            // 
            // editPositionText
            // 
            editPositionText.Location = new Point(385, 45);
            editPositionText.Name = "editPositionText";
            editPositionText.Size = new Size(125, 27);
            editPositionText.TabIndex = 12;
            // 
            // editAccessLevelLabel
            // 
            editAccessLevelLabel.AutoSize = true;
            editAccessLevelLabel.Location = new Point(266, 180);
            editAccessLevelLabel.Name = "editAccessLevelLabel";
            editAccessLevelLabel.Size = new Size(98, 20);
            editAccessLevelLabel.TabIndex = 11;
            editAccessLevelLabel.Text = "Erişim Düzeyi";
            // 
            // editKeywordLabel
            // 
            editKeywordLabel.AutoSize = true;
            editKeywordLabel.Location = new Point(266, 135);
            editKeywordLabel.Name = "editKeywordLabel";
            editKeywordLabel.Size = new Size(111, 20);
            editKeywordLabel.TabIndex = 10;
            editKeywordLabel.Text = "Anahtar Kelime";
            // 
            // editPasswordLabel
            // 
            editPasswordLabel.AutoSize = true;
            editPasswordLabel.Location = new Point(266, 90);
            editPasswordLabel.Name = "editPasswordLabel";
            editPasswordLabel.Size = new Size(39, 20);
            editPasswordLabel.TabIndex = 9;
            editPasswordLabel.Text = "Şifre";
            // 
            // editPositionLabel
            // 
            editPositionLabel.AutoSize = true;
            editPositionLabel.Location = new Point(266, 45);
            editPositionLabel.Name = "editPositionLabel";
            editPositionLabel.Size = new Size(66, 20);
            editPositionLabel.TabIndex = 8;
            editPositionLabel.Text = "Pozisyon";
            // 
            // editPhoneNumberText
            // 
            editPhoneNumberText.Location = new Point(119, 180);
            editPhoneNumberText.Name = "editPhoneNumberText";
            editPhoneNumberText.Size = new Size(125, 27);
            editPhoneNumberText.TabIndex = 7;
            // 
            // editSurnameText
            // 
            editSurnameText.Location = new Point(119, 135);
            editSurnameText.Name = "editSurnameText";
            editSurnameText.Size = new Size(125, 27);
            editSurnameText.TabIndex = 6;
            // 
            // editNameText
            // 
            editNameText.Location = new Point(119, 90);
            editNameText.Name = "editNameText";
            editNameText.Size = new Size(125, 27);
            editNameText.TabIndex = 5;
            // 
            // managerIDText
            // 
            managerIDText.Location = new Point(119, 45);
            managerIDText.Name = "managerIDText";
            managerIDText.PlaceholderText = "Değiştirilemez";
            managerIDText.Size = new Size(125, 27);
            managerIDText.TabIndex = 4;
            // 
            // editPhoneNumberLabel
            // 
            editPhoneNumberLabel.AutoSize = true;
            editPhoneNumberLabel.Location = new Point(22, 180);
            editPhoneNumberLabel.Name = "editPhoneNumberLabel";
            editPhoneNumberLabel.Size = new Size(52, 20);
            editPhoneNumberLabel.TabIndex = 3;
            editPhoneNumberLabel.Text = "Tel No";
            // 
            // editSurnameLabel
            // 
            editSurnameLabel.AutoSize = true;
            editSurnameLabel.Location = new Point(22, 135);
            editSurnameLabel.Name = "editSurnameLabel";
            editSurnameLabel.Size = new Size(50, 20);
            editSurnameLabel.TabIndex = 2;
            editSurnameLabel.Text = "Soyad";
            // 
            // editNameLabel
            // 
            editNameLabel.AutoSize = true;
            editNameLabel.Location = new Point(22, 90);
            editNameLabel.Name = "editNameLabel";
            editNameLabel.Size = new Size(28, 20);
            editNameLabel.TabIndex = 1;
            editNameLabel.Text = "Ad";
            // 
            // managerIDLabel
            // 
            managerIDLabel.AutoSize = true;
            managerIDLabel.Location = new Point(22, 45);
            managerIDLabel.Name = "managerIDLabel";
            managerIDLabel.Size = new Size(80, 20);
            managerIDLabel.TabIndex = 0;
            managerIDLabel.Text = "Yönetici ID";
            // 
            // reservationManagement
            // 
            reservationManagement.BackColor = SystemColors.ActiveCaptionText;
            reservationManagement.ForeColor = SystemColors.ControlLightLight;
            reservationManagement.Location = new Point(12, 12);
            reservationManagement.Name = "reservationManagement";
            reservationManagement.Size = new Size(161, 29);
            reservationManagement.TabIndex = 17;
            reservationManagement.Text = "Rezervasyon Yönetimi";
            reservationManagement.UseVisualStyleBackColor = false;
            reservationManagement.Click += reservationManagement_Click;
            // 
            // roomManagement
            // 
            roomManagement.BackColor = SystemColors.ActiveCaptionText;
            roomManagement.ForeColor = SystemColors.ControlLightLight;
            roomManagement.Location = new Point(12, 52);
            roomManagement.Name = "roomManagement";
            roomManagement.Size = new Size(161, 29);
            roomManagement.TabIndex = 18;
            roomManagement.Text = "Oda Yönetimi";
            roomManagement.UseVisualStyleBackColor = false;
            roomManagement.Click += roomManagement_Click;
            // 
            // customerManagement
            // 
            customerManagement.BackColor = SystemColors.ActiveCaptionText;
            customerManagement.ForeColor = SystemColors.ControlLightLight;
            customerManagement.Location = new Point(12, 92);
            customerManagement.Name = "customerManagement";
            customerManagement.Size = new Size(161, 29);
            customerManagement.TabIndex = 19;
            customerManagement.Text = "Müşteri Yönetimi";
            customerManagement.UseVisualStyleBackColor = false;
            customerManagement.Click += customerManagement_Click;
            // 
            // billManagement
            // 
            billManagement.BackColor = SystemColors.ActiveCaptionText;
            billManagement.ForeColor = SystemColors.ControlLightLight;
            billManagement.Location = new Point(12, 132);
            billManagement.Name = "billManagement";
            billManagement.Size = new Size(161, 29);
            billManagement.TabIndex = 20;
            billManagement.Text = "Fatura Yönetimi";
            billManagement.UseVisualStyleBackColor = false;
            billManagement.Click += billManagement_Click;
            // 
            // deleteManagerGroup
            // 
            deleteManagerGroup.Controls.Add(deleteManager);
            deleteManagerGroup.Controls.Add(deleteManagerIDText);
            deleteManagerGroup.Controls.Add(deleteManagerIDLabel);
            deleteManagerGroup.Location = new Point(1520, 92);
            deleteManagerGroup.Name = "deleteManagerGroup";
            deleteManagerGroup.Size = new Size(250, 125);
            deleteManagerGroup.TabIndex = 22;
            deleteManagerGroup.TabStop = false;
            deleteManagerGroup.Text = "Yönetici Sil";
            // 
            // deleteManager
            // 
            deleteManager.Location = new Point(0, 96);
            deleteManager.Name = "deleteManager";
            deleteManager.Size = new Size(250, 29);
            deleteManager.TabIndex = 17;
            deleteManager.Text = "Yöneticiyi Sil";
            deleteManager.UseVisualStyleBackColor = true;
            deleteManager.Click += deleteManager_Click;
            // 
            // deleteManagerIDText
            // 
            deleteManagerIDText.Location = new Point(119, 45);
            deleteManagerIDText.Name = "deleteManagerIDText";
            deleteManagerIDText.Size = new Size(125, 27);
            deleteManagerIDText.TabIndex = 16;
            // 
            // deleteManagerIDLabel
            // 
            deleteManagerIDLabel.AutoSize = true;
            deleteManagerIDLabel.Location = new Point(22, 45);
            deleteManagerIDLabel.Name = "deleteManagerIDLabel";
            deleteManagerIDLabel.Size = new Size(80, 20);
            deleteManagerIDLabel.TabIndex = 16;
            deleteManagerIDLabel.Text = "Yönetici ID";
            // 
            // showManagerGroup
            // 
            showManagerGroup.Controls.Add(getManagerSpesific);
            showManagerGroup.Controls.Add(getManagerIDText);
            showManagerGroup.Controls.Add(getManagerIDLabel);
            showManagerGroup.Location = new Point(1520, 235);
            showManagerGroup.Name = "showManagerGroup";
            showManagerGroup.Size = new Size(250, 125);
            showManagerGroup.TabIndex = 23;
            showManagerGroup.TabStop = false;
            showManagerGroup.Text = "Yönetici Bul";
            // 
            // getManagerSpesific
            // 
            getManagerSpesific.Location = new Point(0, 96);
            getManagerSpesific.Name = "getManagerSpesific";
            getManagerSpesific.Size = new Size(250, 29);
            getManagerSpesific.TabIndex = 18;
            getManagerSpesific.Text = "Yöneticiyi Bul";
            getManagerSpesific.UseVisualStyleBackColor = true;
            getManagerSpesific.Click += getManagerSpesific_Click;
            // 
            // getManagerIDText
            // 
            getManagerIDText.Location = new Point(119, 45);
            getManagerIDText.Name = "getManagerIDText";
            getManagerIDText.Size = new Size(125, 27);
            getManagerIDText.TabIndex = 16;
            // 
            // getManagerIDLabel
            // 
            getManagerIDLabel.AutoSize = true;
            getManagerIDLabel.Location = new Point(22, 45);
            getManagerIDLabel.Name = "getManagerIDLabel";
            getManagerIDLabel.Size = new Size(80, 20);
            getManagerIDLabel.TabIndex = 16;
            getManagerIDLabel.Text = "Yönetici ID";
            // 
            // signOutButton
            // 
            signOutButton.BackColor = SystemColors.ActiveCaptionText;
            signOutButton.ForeColor = SystemColors.ControlLightLight;
            signOutButton.Location = new Point(12, 172);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(161, 29);
            signOutButton.TabIndex = 24;
            signOutButton.Text = "Çıkış Yap";
            signOutButton.UseVisualStyleBackColor = false;
            signOutButton.Click += signOutButton_Click;
            // 
            // managersList
            // 
            managersList.GridLines = true;
            managersList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            managersList.Location = new Point(12, 366);
            managersList.MultiSelect = false;
            managersList.Name = "managersList";
            managersList.Size = new Size(1752, 175);
            managersList.TabIndex = 25;
            managersList.UseCompatibleStateImageBehavior = false;
            managersList.View = View.Details;
            // 
            // ManagerPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1782, 553);
            Controls.Add(managersList);
            Controls.Add(signOutButton);
            Controls.Add(showManagerGroup);
            Controls.Add(deleteManagerGroup);
            Controls.Add(billManagement);
            Controls.Add(customerManagement);
            Controls.Add(roomManagement);
            Controls.Add(reservationManagement);
            Controls.Add(editManagerGroup);
            Controls.Add(signedAsLabel);
            Controls.Add(dateLabel);
            Controls.Add(createManagerGroup);
            Controls.Add(roomPageLabel);
            Name = "ManagerPage";
            Text = "ManagerPage";
            Load += ManagerPage_Load;
            createManagerGroup.ResumeLayout(false);
            createManagerGroup.PerformLayout();
            editManagerGroup.ResumeLayout(false);
            editManagerGroup.PerformLayout();
            deleteManagerGroup.ResumeLayout(false);
            deleteManagerGroup.PerformLayout();
            showManagerGroup.ResumeLayout(false);
            showManagerGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label roomPageLabel;
        private GroupBox createManagerGroup;
        private Label nameLabel;
        private Label idLabel;
        private Label surnameLabel;
        private Label keywordLabel;
        private Label passwordLabel;
        private Label positionLabel;
        private TextBox phoneNumberText;
        private TextBox idText;
        private TextBox surnameText;
        private TextBox nameText;
        private Label phoneNumberLabel;
        private Button createManager;
        private TextBox accessLevelText;
        private TextBox keywordText;
        private TextBox passwordText;
        private TextBox positionText;
        private Label accessLevelLabel;
        private Label dateLabel;
        private Label signedAsLabel;
        private GroupBox editManagerGroup;
        private Button editManager;
        private TextBox editAccessLevelText;
        private TextBox editKeywordText;
        private TextBox editPasswordText;
        private TextBox editPositionText;
        private Label editAccessLevelLabel;
        private Label editKeywordLabel;
        private Label editPasswordLabel;
        private Label editPositionLabel;
        private TextBox editPhoneNumberText;
        private TextBox editSurnameText;
        private TextBox editNameText;
        private TextBox managerIDText;
        private Label editPhoneNumberLabel;
        private Label editSurnameLabel;
        private Label editNameLabel;
        private Label managerIDLabel;
        private Button reservationManagement;
        private Button roomManagement;
        private Button customerManagement;
        private Button billManagement;
        private GroupBox deleteManagerGroup;
        private Label deleteManagerIDLabel;
        private Button deleteManager;
        private TextBox deleteManagerIDText;
        private GroupBox showManagerGroup;
        private Button getManagerSpesific;
        private TextBox getManagerIDText;
        private Label getManagerIDLabel;
        private Button signOutButton;
        private ListView managersList;
    }
}