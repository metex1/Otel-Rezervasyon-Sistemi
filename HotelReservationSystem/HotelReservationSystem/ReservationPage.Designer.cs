namespace HotelReservationSystem
{
    partial class ReservationPage
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
            reservationPageLabel = new Label();
            customerManagement = new Button();
            roomManagement = new Button();
            endDatePicker = new DateTimePicker();
            startDatePicker = new DateTimePicker();
            endingDateLabel = new Label();
            startingDateLabel = new Label();
            newReservation = new Button();
            createReservationGroup = new GroupBox();
            roomIDText = new TextBox();
            idText = new TextBox();
            roomIDLabel = new Label();
            idLabel = new Label();
            reservationsList = new ListView();
            editReservationGroup = new GroupBox();
            editEndDatePicker = new DateTimePicker();
            editReservation = new Button();
            reservationIDText = new TextBox();
            editStartDatePicker = new DateTimePicker();
            reservationIDLabel = new Label();
            editEndingDateLabel = new Label();
            editStartingDateLabel = new Label();
            deleteReservationGroup = new GroupBox();
            deleteReservation = new Button();
            deleteReservationIDText = new TextBox();
            deleteReservationIDLabel = new Label();
            getReservationGroup = new GroupBox();
            getReservationSpesific = new Button();
            getCustomerIDText = new TextBox();
            getReservationIDLabel = new Label();
            getRoomGroup = new GroupBox();
            getRooms = new Button();
            roomTypeText = new TextBox();
            label1 = new Label();
            roomsList = new ListView();
            dateLabel = new Label();
            billManagement = new Button();
            signOutButton = new Button();
            managerManagement = new Button();
            signedAsLabel = new Label();
            transactionByLabel = new Label();
            reservedRoomPriceLabel = new Label();
            createReservationGroup.SuspendLayout();
            editReservationGroup.SuspendLayout();
            deleteReservationGroup.SuspendLayout();
            getReservationGroup.SuspendLayout();
            getRoomGroup.SuspendLayout();
            SuspendLayout();
            // 
            // reservationPageLabel
            // 
            reservationPageLabel.AutoSize = true;
            reservationPageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            reservationPageLabel.ImageAlign = ContentAlignment.TopCenter;
            reservationPageLabel.Location = new Point(797, 9);
            reservationPageLabel.Name = "reservationPageLabel";
            reservationPageLabel.Size = new Size(205, 28);
            reservationPageLabel.TabIndex = 1;
            reservationPageLabel.Text = "Rezervasyon Sayfası";
            // 
            // customerManagement
            // 
            customerManagement.BackColor = SystemColors.ActiveCaptionText;
            customerManagement.ForeColor = SystemColors.ControlLightLight;
            customerManagement.Location = new Point(12, 92);
            customerManagement.Name = "customerManagement";
            customerManagement.Size = new Size(161, 29);
            customerManagement.TabIndex = 2;
            customerManagement.Text = "Müşteri Yönetimi";
            customerManagement.UseVisualStyleBackColor = false;
            customerManagement.Click += customerManagement_Click;
            // 
            // roomManagement
            // 
            roomManagement.BackColor = SystemColors.ActiveCaptionText;
            roomManagement.ForeColor = SystemColors.ControlLightLight;
            roomManagement.Location = new Point(12, 52);
            roomManagement.Name = "roomManagement";
            roomManagement.Size = new Size(161, 29);
            roomManagement.TabIndex = 3;
            roomManagement.Text = "Oda Yönetimi";
            roomManagement.UseVisualStyleBackColor = false;
            roomManagement.Click += roomManagement_Click;
            // 
            // endDatePicker
            // 
            endDatePicker.Location = new Point(139, 180);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(95, 27);
            endDatePicker.TabIndex = 8;
            // 
            // startDatePicker
            // 
            startDatePicker.Location = new Point(139, 135);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(95, 27);
            startDatePicker.TabIndex = 7;
            // 
            // endingDateLabel
            // 
            endingDateLabel.AutoSize = true;
            endingDateLabel.Location = new Point(22, 180);
            endingDateLabel.Name = "endingDateLabel";
            endingDateLabel.Size = new Size(76, 20);
            endingDateLabel.TabIndex = 5;
            endingDateLabel.Text = "Bitiş Tarihi";
            // 
            // startingDateLabel
            // 
            startingDateLabel.AutoSize = true;
            startingDateLabel.Location = new Point(22, 135);
            startingDateLabel.Name = "startingDateLabel";
            startingDateLabel.Size = new Size(111, 20);
            startingDateLabel.TabIndex = 4;
            startingDateLabel.Text = "Başlangıç ​​Tarihi";
            // 
            // newReservation
            // 
            newReservation.Location = new Point(0, 239);
            newReservation.Name = "newReservation";
            newReservation.Size = new Size(250, 29);
            newReservation.TabIndex = 7;
            newReservation.Text = "Yeni Rezervasyon";
            newReservation.UseVisualStyleBackColor = true;
            newReservation.Click += newReservation_Click;
            // 
            // createReservationGroup
            // 
            createReservationGroup.Controls.Add(roomIDText);
            createReservationGroup.Controls.Add(idText);
            createReservationGroup.Controls.Add(endDatePicker);
            createReservationGroup.Controls.Add(roomIDLabel);
            createReservationGroup.Controls.Add(newReservation);
            createReservationGroup.Controls.Add(startDatePicker);
            createReservationGroup.Controls.Add(idLabel);
            createReservationGroup.Controls.Add(endingDateLabel);
            createReservationGroup.Controls.Add(startingDateLabel);
            createReservationGroup.Location = new Point(179, 92);
            createReservationGroup.Name = "createReservationGroup";
            createReservationGroup.Size = new Size(250, 268);
            createReservationGroup.TabIndex = 8;
            createReservationGroup.TabStop = false;
            createReservationGroup.Text = "Yeni Rezervasyon";
            // 
            // roomIDText
            // 
            roomIDText.Location = new Point(119, 90);
            roomIDText.Name = "roomIDText";
            roomIDText.Size = new Size(125, 27);
            roomIDText.TabIndex = 12;
            // 
            // idText
            // 
            idText.Location = new Point(119, 45);
            idText.Name = "idText";
            idText.Size = new Size(125, 27);
            idText.TabIndex = 11;
            // 
            // roomIDLabel
            // 
            roomIDLabel.AutoSize = true;
            roomIDLabel.Location = new Point(22, 90);
            roomIDLabel.Name = "roomIDLabel";
            roomIDLabel.Size = new Size(56, 20);
            roomIDLabel.TabIndex = 10;
            roomIDLabel.Text = "Oda ID";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(22, 45);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(77, 20);
            idLabel.TabIndex = 9;
            idLabel.Text = "Müşteri ID";
            // 
            // reservationsList
            // 
            reservationsList.GridLines = true;
            reservationsList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            reservationsList.Location = new Point(12, 367);
            reservationsList.MultiSelect = false;
            reservationsList.Name = "reservationsList";
            reservationsList.Size = new Size(1482, 175);
            reservationsList.TabIndex = 9;
            reservationsList.UseCompatibleStateImageBehavior = false;
            reservationsList.View = View.Details;
            // 
            // editReservationGroup
            // 
            editReservationGroup.Controls.Add(editEndDatePicker);
            editReservationGroup.Controls.Add(editReservation);
            editReservationGroup.Controls.Add(reservationIDText);
            editReservationGroup.Controls.Add(editStartDatePicker);
            editReservationGroup.Controls.Add(reservationIDLabel);
            editReservationGroup.Controls.Add(editEndingDateLabel);
            editReservationGroup.Controls.Add(editStartingDateLabel);
            editReservationGroup.Location = new Point(610, 93);
            editReservationGroup.Name = "editReservationGroup";
            editReservationGroup.Size = new Size(266, 268);
            editReservationGroup.TabIndex = 10;
            editReservationGroup.TabStop = false;
            editReservationGroup.Text = "Rezervasyon Düzenle";
            // 
            // editEndDatePicker
            // 
            editEndDatePicker.Location = new Point(156, 180);
            editEndDatePicker.Name = "editEndDatePicker";
            editEndDatePicker.Size = new Size(95, 27);
            editEndDatePicker.TabIndex = 16;
            // 
            // editReservation
            // 
            editReservation.Location = new Point(0, 239);
            editReservation.Name = "editReservation";
            editReservation.Size = new Size(266, 29);
            editReservation.TabIndex = 11;
            editReservation.Text = "Rezervasyonu Düzenle";
            editReservation.UseVisualStyleBackColor = true;
            editReservation.Click += editReservation_Click;
            // 
            // reservationIDText
            // 
            reservationIDText.Location = new Point(135, 60);
            reservationIDText.Name = "reservationIDText";
            reservationIDText.PlaceholderText = "Değiştirilemez";
            reservationIDText.Size = new Size(125, 27);
            reservationIDText.TabIndex = 13;
            // 
            // editStartDatePicker
            // 
            editStartDatePicker.Location = new Point(156, 120);
            editStartDatePicker.Name = "editStartDatePicker";
            editStartDatePicker.Size = new Size(95, 27);
            editStartDatePicker.TabIndex = 15;
            // 
            // reservationIDLabel
            // 
            reservationIDLabel.AutoSize = true;
            reservationIDLabel.Location = new Point(22, 60);
            reservationIDLabel.Name = "reservationIDLabel";
            reservationIDLabel.Size = new Size(110, 20);
            reservationIDLabel.TabIndex = 10;
            reservationIDLabel.Text = "Rezervasyon ID";
            // 
            // editEndingDateLabel
            // 
            editEndingDateLabel.AutoSize = true;
            editEndingDateLabel.Location = new Point(22, 180);
            editEndingDateLabel.Name = "editEndingDateLabel";
            editEndingDateLabel.Size = new Size(76, 20);
            editEndingDateLabel.TabIndex = 14;
            editEndingDateLabel.Text = "Bitiş Tarihi";
            // 
            // editStartingDateLabel
            // 
            editStartingDateLabel.AutoSize = true;
            editStartingDateLabel.Location = new Point(22, 120);
            editStartingDateLabel.Name = "editStartingDateLabel";
            editStartingDateLabel.Size = new Size(111, 20);
            editStartingDateLabel.TabIndex = 13;
            editStartingDateLabel.Text = "Başlangıç ​​Tarihi";
            // 
            // deleteReservationGroup
            // 
            deleteReservationGroup.Controls.Add(deleteReservation);
            deleteReservationGroup.Controls.Add(deleteReservationIDText);
            deleteReservationGroup.Controls.Add(deleteReservationIDLabel);
            deleteReservationGroup.Location = new Point(1057, 243);
            deleteReservationGroup.Name = "deleteReservationGroup";
            deleteReservationGroup.Size = new Size(266, 117);
            deleteReservationGroup.TabIndex = 12;
            deleteReservationGroup.TabStop = false;
            deleteReservationGroup.Text = "Rezervasyon Sil";
            // 
            // deleteReservation
            // 
            deleteReservation.Location = new Point(0, 89);
            deleteReservation.Name = "deleteReservation";
            deleteReservation.Size = new Size(266, 29);
            deleteReservation.TabIndex = 13;
            deleteReservation.Text = "Rezervasyonu Sil";
            deleteReservation.UseVisualStyleBackColor = true;
            deleteReservation.Click += deleteReservation_Click;
            // 
            // deleteReservationIDText
            // 
            deleteReservationIDText.Location = new Point(135, 45);
            deleteReservationIDText.Name = "deleteReservationIDText";
            deleteReservationIDText.Size = new Size(125, 27);
            deleteReservationIDText.TabIndex = 13;
            // 
            // deleteReservationIDLabel
            // 
            deleteReservationIDLabel.AutoSize = true;
            deleteReservationIDLabel.Location = new Point(22, 45);
            deleteReservationIDLabel.Name = "deleteReservationIDLabel";
            deleteReservationIDLabel.Size = new Size(110, 20);
            deleteReservationIDLabel.TabIndex = 13;
            deleteReservationIDLabel.Text = "Rezervasyon ID";
            // 
            // getReservationGroup
            // 
            getReservationGroup.Controls.Add(getReservationSpesific);
            getReservationGroup.Controls.Add(getCustomerIDText);
            getReservationGroup.Controls.Add(getReservationIDLabel);
            getReservationGroup.Location = new Point(1057, 92);
            getReservationGroup.Name = "getReservationGroup";
            getReservationGroup.Size = new Size(266, 117);
            getReservationGroup.TabIndex = 14;
            getReservationGroup.TabStop = false;
            getReservationGroup.Text = "Rezervasyon Bul";
            // 
            // getReservationSpesific
            // 
            getReservationSpesific.Location = new Point(0, 89);
            getReservationSpesific.Name = "getReservationSpesific";
            getReservationSpesific.Size = new Size(266, 29);
            getReservationSpesific.TabIndex = 13;
            getReservationSpesific.Text = "Rezervasyonu Bul";
            getReservationSpesific.UseVisualStyleBackColor = true;
            getReservationSpesific.Click += getReservationSpesific_Click;
            // 
            // getCustomerIDText
            // 
            getCustomerIDText.Location = new Point(135, 45);
            getCustomerIDText.Name = "getCustomerIDText";
            getCustomerIDText.Size = new Size(125, 27);
            getCustomerIDText.TabIndex = 13;
            // 
            // getReservationIDLabel
            // 
            getReservationIDLabel.AutoSize = true;
            getReservationIDLabel.Location = new Point(22, 45);
            getReservationIDLabel.Name = "getReservationIDLabel";
            getReservationIDLabel.Size = new Size(77, 20);
            getReservationIDLabel.TabIndex = 13;
            getReservationIDLabel.Text = "Müşteri ID";
            // 
            // getRoomGroup
            // 
            getRoomGroup.Controls.Add(getRooms);
            getRoomGroup.Controls.Add(roomTypeText);
            getRoomGroup.Controls.Add(label1);
            getRoomGroup.Location = new Point(1504, 167);
            getRoomGroup.Name = "getRoomGroup";
            getRoomGroup.Size = new Size(266, 117);
            getRoomGroup.TabIndex = 15;
            getRoomGroup.TabStop = false;
            getRoomGroup.Text = "Oda Tipine Göre Oda Bul";
            // 
            // getRooms
            // 
            getRooms.Location = new Point(0, 89);
            getRooms.Name = "getRooms";
            getRooms.Size = new Size(266, 29);
            getRooms.TabIndex = 14;
            getRooms.Text = "Odaları Bul";
            getRooms.UseVisualStyleBackColor = true;
            getRooms.Click += getRooms_Click;
            // 
            // roomTypeText
            // 
            roomTypeText.Location = new Point(119, 45);
            roomTypeText.Name = "roomTypeText";
            roomTypeText.Size = new Size(125, 27);
            roomTypeText.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 45);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 13;
            label1.Text = "Oda Tipi";
            // 
            // roomsList
            // 
            roomsList.GridLines = true;
            roomsList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            roomsList.Location = new Point(1504, 367);
            roomsList.MultiSelect = false;
            roomsList.Name = "roomsList";
            roomsList.Size = new Size(264, 174);
            roomsList.TabIndex = 16;
            roomsList.UseCompatibleStateImageBehavior = false;
            roomsList.View = View.Details;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(1685, 9);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(85, 20);
            dateLabel.TabIndex = 17;
            dateLabel.Text = "2012-12-12";
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
            signOutButton.TabIndex = 25;
            signOutButton.Text = "Çıkış Yap";
            signOutButton.UseVisualStyleBackColor = false;
            signOutButton.Click += signOutButton_Click;
            // 
            // managerManagement
            // 
            managerManagement.BackColor = SystemColors.ActiveCaptionText;
            managerManagement.ForeColor = SystemColors.ControlLightLight;
            managerManagement.Location = new Point(12, 12);
            managerManagement.Name = "managerManagement";
            managerManagement.Size = new Size(161, 29);
            managerManagement.TabIndex = 26;
            managerManagement.Text = "Yönetici Yönetimi";
            managerManagement.UseVisualStyleBackColor = false;
            managerManagement.Click += managerManagement_Click;
            // 
            // signedAsLabel
            // 
            signedAsLabel.AutoSize = true;
            signedAsLabel.Location = new Point(1427, 9);
            signedAsLabel.Name = "signedAsLabel";
            signedAsLabel.Size = new Size(202, 20);
            signedAsLabel.TabIndex = 27;
            signedAsLabel.Text = ".......... .......... olarak giriş yapıldı.";
            // 
            // transactionByLabel
            // 
            transactionByLabel.AutoSize = true;
            transactionByLabel.Location = new Point(12, 344);
            transactionByLabel.Name = "transactionByLabel";
            transactionByLabel.Size = new Size(98, 20);
            transactionByLabel.TabIndex = 28;
            transactionByLabel.Text = "transactionBy";
            transactionByLabel.Visible = false;
            // 
            // reservedRoomPriceLabel
            // 
            reservedRoomPriceLabel.AutoSize = true;
            reservedRoomPriceLabel.Location = new Point(12, 324);
            reservedRoomPriceLabel.Name = "reservedRoomPriceLabel";
            reservedRoomPriceLabel.Size = new Size(137, 20);
            reservedRoomPriceLabel.TabIndex = 29;
            reservedRoomPriceLabel.Text = "reservedRoomPrice";
            reservedRoomPriceLabel.Visible = false;
            // 
            // ReservationPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1782, 553);
            Controls.Add(reservedRoomPriceLabel);
            Controls.Add(transactionByLabel);
            Controls.Add(signedAsLabel);
            Controls.Add(managerManagement);
            Controls.Add(signOutButton);
            Controls.Add(billManagement);
            Controls.Add(dateLabel);
            Controls.Add(roomsList);
            Controls.Add(getRoomGroup);
            Controls.Add(getReservationGroup);
            Controls.Add(deleteReservationGroup);
            Controls.Add(editReservationGroup);
            Controls.Add(reservationsList);
            Controls.Add(createReservationGroup);
            Controls.Add(roomManagement);
            Controls.Add(customerManagement);
            Controls.Add(reservationPageLabel);
            Name = "ReservationPage";
            Text = "ReservationPage";
            Load += ReservationPage_Load;
            createReservationGroup.ResumeLayout(false);
            createReservationGroup.PerformLayout();
            editReservationGroup.ResumeLayout(false);
            editReservationGroup.PerformLayout();
            deleteReservationGroup.ResumeLayout(false);
            deleteReservationGroup.PerformLayout();
            getReservationGroup.ResumeLayout(false);
            getReservationGroup.PerformLayout();
            getRoomGroup.ResumeLayout(false);
            getRoomGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label reservationPageLabel;
        private Button customerManagement;
        private Button roomManagement;
        private Label startingDateLabel;
        private DateTimePicker endDatePicker;
        private DateTimePicker startDatePicker;
        private Label endingDateLabel;
        private Button newReservation;
        private GroupBox createReservationGroup;
        private Label idLabel;
        private Label roomIDLabel;
        private TextBox roomIDText;
        private TextBox idText;
        private ListView reservationsList;
        private GroupBox editReservationGroup;
        private DateTimePicker editEndDatePicker;
        private TextBox reservationIDText;
        private DateTimePicker editStartDatePicker;
        private Label reservationIDLabel;
        private Label editEndingDateLabel;
        private Label editStartingDateLabel;
        private Button editReservation;
        private GroupBox deleteReservationGroup;
        private TextBox deleteReservationIDText;
        private Label deleteReservationIDLabel;
        private Button deleteReservation;
        private GroupBox getReservationGroup;
        private Button getReservationSpesific;
        private TextBox getCustomerIDText;
        private Label getReservationIDLabel;
        private GroupBox getRoomGroup;
        private Label label1;
        private Button getRooms;
        private TextBox roomTypeText;
        private ListView roomsList;
        private Label dateLabel;
        private Button billManagement;
        private Button signOutButton;
        private Button managerManagement;
        private Label signedAsLabel;
        private Label transactionByLabel;
        private Label reservedRoomPriceLabel;
    }
}