namespace HotelReservationSystem
{
    partial class CustomerPage
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
            roomManagement = new Button();
            reservationManagement = new Button();
            customerPageLabel = new Label();
            createCustomerGroup = new GroupBox();
            phoneNumberText = new TextBox();
            idText = new TextBox();
            surnameText = new TextBox();
            createCustomer = new Button();
            nameText = new TextBox();
            phoneNumberLabel = new Label();
            idLabel = new Label();
            surnameLabel = new Label();
            nameLabel = new Label();
            editCustomerGroup = new GroupBox();
            editPhoneNumberText = new TextBox();
            editCustomerIDText = new TextBox();
            editSurnameText = new TextBox();
            editCustomer = new Button();
            editNameText = new TextBox();
            editPhoneNumberLabel = new Label();
            editIDLabel = new Label();
            editSurnameLabel = new Label();
            editNameLabel = new Label();
            deleteCustomerGroup = new GroupBox();
            deletedCustomerIDText = new TextBox();
            deleteCustomer = new Button();
            deletedCustomerIDLabel = new Label();
            label1 = new Label();
            customersList = new ListView();
            getCustomerGroup = new GroupBox();
            getCustomerIDText = new TextBox();
            getCustomerSpesific = new Button();
            getCustomerIDLabel = new Label();
            label3 = new Label();
            dateLabel = new Label();
            managerManagement = new Button();
            billManagement = new Button();
            signOutButton = new Button();
            signedAsLabel = new Label();
            createCustomerGroup.SuspendLayout();
            editCustomerGroup.SuspendLayout();
            deleteCustomerGroup.SuspendLayout();
            getCustomerGroup.SuspendLayout();
            SuspendLayout();
            // 
            // roomManagement
            // 
            roomManagement.BackColor = SystemColors.ActiveCaptionText;
            roomManagement.ForeColor = SystemColors.ControlLightLight;
            roomManagement.Location = new Point(12, 92);
            roomManagement.Name = "roomManagement";
            roomManagement.Size = new Size(161, 29);
            roomManagement.TabIndex = 3;
            roomManagement.Text = "Oda Yönetimi";
            roomManagement.UseVisualStyleBackColor = false;
            roomManagement.Click += roomManagement_Click;
            // 
            // reservationManagement
            // 
            reservationManagement.BackColor = SystemColors.ActiveCaptionText;
            reservationManagement.ForeColor = SystemColors.ControlLightLight;
            reservationManagement.Location = new Point(12, 52);
            reservationManagement.Name = "reservationManagement";
            reservationManagement.Size = new Size(161, 29);
            reservationManagement.TabIndex = 4;
            reservationManagement.Text = "Rezervasyon Yönetimi";
            reservationManagement.UseVisualStyleBackColor = false;
            reservationManagement.Click += reservationManagement_Click;
            // 
            // customerPageLabel
            // 
            customerPageLabel.AutoSize = true;
            customerPageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            customerPageLabel.Location = new Point(776, 9);
            customerPageLabel.Name = "customerPageLabel";
            customerPageLabel.Size = new Size(247, 28);
            customerPageLabel.TabIndex = 5;
            customerPageLabel.Text = "Müşteri Yönetimi Sayfası";
            // 
            // createCustomerGroup
            // 
            createCustomerGroup.Controls.Add(phoneNumberText);
            createCustomerGroup.Controls.Add(idText);
            createCustomerGroup.Controls.Add(surnameText);
            createCustomerGroup.Controls.Add(createCustomer);
            createCustomerGroup.Controls.Add(nameText);
            createCustomerGroup.Controls.Add(phoneNumberLabel);
            createCustomerGroup.Controls.Add(idLabel);
            createCustomerGroup.Controls.Add(surnameLabel);
            createCustomerGroup.Controls.Add(nameLabel);
            createCustomerGroup.Location = new Point(179, 92);
            createCustomerGroup.Name = "createCustomerGroup";
            createCustomerGroup.Size = new Size(250, 268);
            createCustomerGroup.TabIndex = 6;
            createCustomerGroup.TabStop = false;
            createCustomerGroup.Text = "Müşteri Oluştur";
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
            // createCustomer
            // 
            createCustomer.Location = new Point(0, 239);
            createCustomer.Name = "createCustomer";
            createCustomer.Size = new Size(250, 29);
            createCustomer.TabIndex = 10;
            createCustomer.Text = "Müşteri Oluştur";
            createCustomer.UseVisualStyleBackColor = true;
            createCustomer.Click += createCustomer_Click;
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
            // editCustomerGroup
            // 
            editCustomerGroup.Controls.Add(editPhoneNumberText);
            editCustomerGroup.Controls.Add(editCustomerIDText);
            editCustomerGroup.Controls.Add(editSurnameText);
            editCustomerGroup.Controls.Add(editCustomer);
            editCustomerGroup.Controls.Add(editNameText);
            editCustomerGroup.Controls.Add(editPhoneNumberLabel);
            editCustomerGroup.Controls.Add(editIDLabel);
            editCustomerGroup.Controls.Add(editSurnameLabel);
            editCustomerGroup.Controls.Add(editNameLabel);
            editCustomerGroup.Location = new Point(849, 92);
            editCustomerGroup.Name = "editCustomerGroup";
            editCustomerGroup.Size = new Size(250, 268);
            editCustomerGroup.TabIndex = 8;
            editCustomerGroup.TabStop = false;
            editCustomerGroup.Text = "Müşteri Düzenle";
            // 
            // editPhoneNumberText
            // 
            editPhoneNumberText.Location = new Point(119, 180);
            editPhoneNumberText.Name = "editPhoneNumberText";
            editPhoneNumberText.Size = new Size(125, 27);
            editPhoneNumberText.TabIndex = 7;
            // 
            // editCustomerIDText
            // 
            editCustomerIDText.Location = new Point(119, 45);
            editCustomerIDText.Name = "editCustomerIDText";
            editCustomerIDText.PlaceholderText = "Değiştirilemez";
            editCustomerIDText.Size = new Size(125, 27);
            editCustomerIDText.TabIndex = 6;
            // 
            // editSurnameText
            // 
            editSurnameText.Location = new Point(119, 135);
            editSurnameText.Name = "editSurnameText";
            editSurnameText.Size = new Size(125, 27);
            editSurnameText.TabIndex = 5;
            // 
            // editCustomer
            // 
            editCustomer.Location = new Point(0, 239);
            editCustomer.Name = "editCustomer";
            editCustomer.Size = new Size(250, 29);
            editCustomer.TabIndex = 11;
            editCustomer.Text = "Müşteri Düzenle";
            editCustomer.UseVisualStyleBackColor = true;
            editCustomer.Click += editCustomer_Click;
            // 
            // editNameText
            // 
            editNameText.Location = new Point(119, 90);
            editNameText.Name = "editNameText";
            editNameText.Size = new Size(125, 27);
            editNameText.TabIndex = 4;
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
            // editIDLabel
            // 
            editIDLabel.AutoSize = true;
            editIDLabel.Location = new Point(22, 45);
            editIDLabel.Name = "editIDLabel";
            editIDLabel.Size = new Size(77, 20);
            editIDLabel.TabIndex = 2;
            editIDLabel.Text = "Müşteri ID";
            // 
            // editSurnameLabel
            // 
            editSurnameLabel.AutoSize = true;
            editSurnameLabel.Location = new Point(22, 135);
            editSurnameLabel.Name = "editSurnameLabel";
            editSurnameLabel.Size = new Size(50, 20);
            editSurnameLabel.TabIndex = 1;
            editSurnameLabel.Text = "Soyad";
            // 
            // editNameLabel
            // 
            editNameLabel.AutoSize = true;
            editNameLabel.Location = new Point(22, 90);
            editNameLabel.Name = "editNameLabel";
            editNameLabel.Size = new Size(28, 20);
            editNameLabel.TabIndex = 0;
            editNameLabel.Text = "Ad";
            // 
            // deleteCustomerGroup
            // 
            deleteCustomerGroup.Controls.Add(deletedCustomerIDText);
            deleteCustomerGroup.Controls.Add(deleteCustomer);
            deleteCustomerGroup.Controls.Add(deletedCustomerIDLabel);
            deleteCustomerGroup.Controls.Add(label1);
            deleteCustomerGroup.Location = new Point(1520, 92);
            deleteCustomerGroup.Name = "deleteCustomerGroup";
            deleteCustomerGroup.Size = new Size(250, 117);
            deleteCustomerGroup.TabIndex = 12;
            deleteCustomerGroup.TabStop = false;
            deleteCustomerGroup.Text = "Müşteri Sil";
            // 
            // deletedCustomerIDText
            // 
            deletedCustomerIDText.Location = new Point(119, 45);
            deletedCustomerIDText.Name = "deletedCustomerIDText";
            deletedCustomerIDText.Size = new Size(125, 27);
            deletedCustomerIDText.TabIndex = 8;
            // 
            // deleteCustomer
            // 
            deleteCustomer.Location = new Point(0, 88);
            deleteCustomer.Name = "deleteCustomer";
            deleteCustomer.Size = new Size(250, 29);
            deleteCustomer.TabIndex = 13;
            deleteCustomer.Text = "Müşteri Sil";
            deleteCustomer.UseVisualStyleBackColor = true;
            deleteCustomer.Click += deleteCustomer_Click;
            // 
            // deletedCustomerIDLabel
            // 
            deletedCustomerIDLabel.AutoSize = true;
            deletedCustomerIDLabel.Location = new Point(22, 45);
            deletedCustomerIDLabel.Name = "deletedCustomerIDLabel";
            deletedCustomerIDLabel.Size = new Size(77, 20);
            deletedCustomerIDLabel.TabIndex = 8;
            deletedCustomerIDLabel.Text = "Müşteri ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 48);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 8;
            // 
            // customersList
            // 
            customersList.GridLines = true;
            customersList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            customersList.Location = new Point(12, 366);
            customersList.MultiSelect = false;
            customersList.Name = "customersList";
            customersList.Size = new Size(1756, 175);
            customersList.TabIndex = 14;
            customersList.UseCompatibleStateImageBehavior = false;
            customersList.View = View.Details;
            // 
            // getCustomerGroup
            // 
            getCustomerGroup.Controls.Add(getCustomerIDText);
            getCustomerGroup.Controls.Add(getCustomerSpesific);
            getCustomerGroup.Controls.Add(getCustomerIDLabel);
            getCustomerGroup.Controls.Add(label3);
            getCustomerGroup.Location = new Point(1520, 243);
            getCustomerGroup.Name = "getCustomerGroup";
            getCustomerGroup.Size = new Size(250, 117);
            getCustomerGroup.TabIndex = 14;
            getCustomerGroup.TabStop = false;
            getCustomerGroup.Text = "Müşteri Bul";
            // 
            // getCustomerIDText
            // 
            getCustomerIDText.Location = new Point(119, 45);
            getCustomerIDText.Name = "getCustomerIDText";
            getCustomerIDText.Size = new Size(125, 27);
            getCustomerIDText.TabIndex = 8;
            // 
            // getCustomerSpesific
            // 
            getCustomerSpesific.Location = new Point(0, 88);
            getCustomerSpesific.Name = "getCustomerSpesific";
            getCustomerSpesific.Size = new Size(250, 29);
            getCustomerSpesific.TabIndex = 13;
            getCustomerSpesific.Text = "Müşteriyi Bul";
            getCustomerSpesific.UseVisualStyleBackColor = true;
            getCustomerSpesific.Click += getCustomerSpesific_Click;
            // 
            // getCustomerIDLabel
            // 
            getCustomerIDLabel.AutoSize = true;
            getCustomerIDLabel.Location = new Point(22, 45);
            getCustomerIDLabel.Name = "getCustomerIDLabel";
            getCustomerIDLabel.Size = new Size(77, 20);
            getCustomerIDLabel.TabIndex = 8;
            getCustomerIDLabel.Text = "Müşteri ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 48);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 8;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(1685, 9);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(85, 20);
            dateLabel.TabIndex = 15;
            dateLabel.Text = "2012-12-12";
            // 
            // managerManagement
            // 
            managerManagement.BackColor = SystemColors.ActiveCaptionText;
            managerManagement.ForeColor = SystemColors.ControlLightLight;
            managerManagement.Location = new Point(12, 12);
            managerManagement.Name = "managerManagement";
            managerManagement.Size = new Size(161, 29);
            managerManagement.TabIndex = 16;
            managerManagement.Text = "Yönetici Yönetimi";
            managerManagement.UseVisualStyleBackColor = false;
            managerManagement.Click += managerManagement_Click;
            // 
            // billManagement
            // 
            billManagement.BackColor = SystemColors.ActiveCaptionText;
            billManagement.ForeColor = SystemColors.ControlLightLight;
            billManagement.Location = new Point(12, 132);
            billManagement.Name = "billManagement";
            billManagement.Size = new Size(161, 29);
            billManagement.TabIndex = 21;
            billManagement.Text = "Fatura Yönetimi";
            billManagement.UseVisualStyleBackColor = false;
            billManagement.Click += billManagement_Click;
            // 
            // signOutButton
            // 
            signOutButton.BackColor = SystemColors.ActiveCaptionText;
            signOutButton.ForeColor = SystemColors.ControlLightLight;
            signOutButton.Location = new Point(12, 172);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(161, 29);
            signOutButton.TabIndex = 27;
            signOutButton.Text = "Çıkış Yap";
            signOutButton.UseVisualStyleBackColor = false;
            signOutButton.Click += signOutButton_Click;
            // 
            // signedAsLabel
            // 
            signedAsLabel.AutoSize = true;
            signedAsLabel.Location = new Point(1427, 9);
            signedAsLabel.Name = "signedAsLabel";
            signedAsLabel.Size = new Size(202, 20);
            signedAsLabel.TabIndex = 28;
            signedAsLabel.Text = ".......... .......... olarak giriş yapıldı.";
            // 
            // CustomerPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1782, 553);
            Controls.Add(signedAsLabel);
            Controls.Add(signOutButton);
            Controls.Add(billManagement);
            Controls.Add(managerManagement);
            Controls.Add(dateLabel);
            Controls.Add(getCustomerGroup);
            Controls.Add(customersList);
            Controls.Add(deleteCustomerGroup);
            Controls.Add(editCustomerGroup);
            Controls.Add(createCustomerGroup);
            Controls.Add(customerPageLabel);
            Controls.Add(reservationManagement);
            Controls.Add(roomManagement);
            Name = "CustomerPage";
            Text = "CustomerPage";
            Load += CustomerPage_Load;
            createCustomerGroup.ResumeLayout(false);
            createCustomerGroup.PerformLayout();
            editCustomerGroup.ResumeLayout(false);
            editCustomerGroup.PerformLayout();
            deleteCustomerGroup.ResumeLayout(false);
            deleteCustomerGroup.PerformLayout();
            getCustomerGroup.ResumeLayout(false);
            getCustomerGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button roomManagement;
        private Button reservationManagement;
        private Label customerPageLabel;
        private GroupBox createCustomerGroup;
        private TextBox phoneNumberText;
        private TextBox idText;
        private TextBox surnameText;
        private TextBox nameText;
        private Label phoneNumberLabel;
        private Label idLabel;
        private Label surnameLabel;
        private Label nameLabel;
        private GroupBox editCustomerGroup;
        private TextBox editPhoneNumberText;
        private TextBox editCustomerIDText;
        private TextBox editSurnameText;
        private TextBox editNameText;
        private Label editPhoneNumberLabel;
        private Label editIDLabel;
        private Label editSurnameLabel;
        private Label editNameLabel;
        private Button createCustomer;
        private Button editCustomer;
        private GroupBox deleteCustomerGroup;
        private TextBox deletedCustomerIDText;
        private Label deletedCustomerIDLabel;
        private Label label1;
        private Button deleteCustomer;
        private ListView customersList;
        private GroupBox getCustomerGroup;
        private TextBox getCustomerIDText;
        private Button getCustomerSpesific;
        private Label getCustomerIDLabel;
        private Label label3;
        private Label dateLabel;
        private Button managerManagement;
        private Button billManagement;
        private Button signOutButton;
        private Label signedAsLabel;
    }
}