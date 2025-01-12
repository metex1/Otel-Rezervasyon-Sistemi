namespace HotelReservationSystem
{
    partial class RoomPage
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
            customerManagement = new Button();
            reservationManagement = new Button();
            roomPageLabel = new Label();
            roomsList = new ListView();
            createRoomGroup = new GroupBox();
            roomNameText = new TextBox();
            roomNameLabel = new Label();
            priceText = new TextBox();
            roomTypeText = new TextBox();
            createRoom = new Button();
            priceLabel = new Label();
            roomTypeLabel = new Label();
            editRoom = new Button();
            deleteRoom = new Button();
            editRoomGroup = new GroupBox();
            roomIDText = new TextBox();
            roomIDLabel = new Label();
            editRoomNameText = new TextBox();
            editRoomNameLabel = new Label();
            editPriceText = new TextBox();
            editRoomTypeText = new TextBox();
            editPriceLabel = new Label();
            editRoomTypeLabel = new Label();
            deleteRoomGroup = new GroupBox();
            deletedRoomIDText = new TextBox();
            deletedRoomIDLabel = new Label();
            enrtyExitGroup = new GroupBox();
            makeAnExit = new Button();
            entryExitRoomIDText = new TextBox();
            entryExitRoomIDLabel = new Label();
            makeAnEntrance = new Button();
            dateLabel = new Label();
            managerManagement = new Button();
            signOutButton = new Button();
            billManagement = new Button();
            signedAsLabel = new Label();
            createRoomGroup.SuspendLayout();
            editRoomGroup.SuspendLayout();
            deleteRoomGroup.SuspendLayout();
            enrtyExitGroup.SuspendLayout();
            SuspendLayout();
            // 
            // customerManagement
            // 
            customerManagement.BackColor = SystemColors.ActiveCaptionText;
            customerManagement.ForeColor = SystemColors.ControlLightLight;
            customerManagement.Location = new Point(12, 92);
            customerManagement.Name = "customerManagement";
            customerManagement.Size = new Size(161, 29);
            customerManagement.TabIndex = 4;
            customerManagement.Text = "Müşteri Yönetimi";
            customerManagement.UseVisualStyleBackColor = false;
            customerManagement.Click += customerManagement_Click;
            // 
            // reservationManagement
            // 
            reservationManagement.BackColor = SystemColors.ActiveCaptionText;
            reservationManagement.ForeColor = SystemColors.ControlLightLight;
            reservationManagement.Location = new Point(12, 52);
            reservationManagement.Name = "reservationManagement";
            reservationManagement.Size = new Size(161, 29);
            reservationManagement.TabIndex = 5;
            reservationManagement.Text = "Rezervasyon Yönetimi";
            reservationManagement.UseVisualStyleBackColor = false;
            reservationManagement.Click += reservationManagement_Click;
            // 
            // roomPageLabel
            // 
            roomPageLabel.AutoSize = true;
            roomPageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            roomPageLabel.Location = new Point(794, 9);
            roomPageLabel.Name = "roomPageLabel";
            roomPageLabel.Size = new Size(212, 28);
            roomPageLabel.TabIndex = 6;
            roomPageLabel.Text = "Oda Yönetimi Sayfası";
            // 
            // roomsList
            // 
            roomsList.GridLines = true;
            roomsList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            roomsList.Location = new Point(12, 377);
            roomsList.MultiSelect = false;
            roomsList.Name = "roomsList";
            roomsList.Size = new Size(1755, 164);
            roomsList.TabIndex = 7;
            roomsList.UseCompatibleStateImageBehavior = false;
            roomsList.View = View.Details;
            // 
            // createRoomGroup
            // 
            createRoomGroup.Controls.Add(roomNameText);
            createRoomGroup.Controls.Add(roomNameLabel);
            createRoomGroup.Controls.Add(priceText);
            createRoomGroup.Controls.Add(roomTypeText);
            createRoomGroup.Controls.Add(createRoom);
            createRoomGroup.Controls.Add(priceLabel);
            createRoomGroup.Controls.Add(roomTypeLabel);
            createRoomGroup.Location = new Point(179, 92);
            createRoomGroup.Name = "createRoomGroup";
            createRoomGroup.Size = new Size(250, 279);
            createRoomGroup.TabIndex = 8;
            createRoomGroup.TabStop = false;
            createRoomGroup.Text = "Oda Oluştur";
            // 
            // roomNameText
            // 
            roomNameText.Location = new Point(119, 60);
            roomNameText.Name = "roomNameText";
            roomNameText.Size = new Size(125, 27);
            roomNameText.TabIndex = 5;
            // 
            // roomNameLabel
            // 
            roomNameLabel.AutoSize = true;
            roomNameLabel.Location = new Point(22, 60);
            roomNameLabel.Name = "roomNameLabel";
            roomNameLabel.Size = new Size(64, 20);
            roomNameLabel.TabIndex = 4;
            roomNameLabel.Text = "Oda Adı";
            // 
            // priceText
            // 
            priceText.Location = new Point(119, 180);
            priceText.Name = "priceText";
            priceText.Size = new Size(125, 27);
            priceText.TabIndex = 3;
            // 
            // roomTypeText
            // 
            roomTypeText.Location = new Point(119, 120);
            roomTypeText.Name = "roomTypeText";
            roomTypeText.Size = new Size(125, 27);
            roomTypeText.TabIndex = 2;
            // 
            // createRoom
            // 
            createRoom.Location = new Point(0, 250);
            createRoom.Name = "createRoom";
            createRoom.Size = new Size(250, 29);
            createRoom.TabIndex = 9;
            createRoom.Text = "Oda Oluştur";
            createRoom.UseVisualStyleBackColor = true;
            createRoom.Click += createRoom_Click;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(22, 180);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(40, 20);
            priceLabel.TabIndex = 1;
            priceLabel.Text = "Fiyat";
            // 
            // roomTypeLabel
            // 
            roomTypeLabel.AutoSize = true;
            roomTypeLabel.Location = new Point(22, 120);
            roomTypeLabel.Name = "roomTypeLabel";
            roomTypeLabel.Size = new Size(66, 20);
            roomTypeLabel.TabIndex = 0;
            roomTypeLabel.Text = "Oda Tipi";
            // 
            // editRoom
            // 
            editRoom.Location = new Point(0, 250);
            editRoom.Name = "editRoom";
            editRoom.Size = new Size(250, 29);
            editRoom.TabIndex = 10;
            editRoom.Text = "Odayı Düzenle";
            editRoom.UseVisualStyleBackColor = true;
            editRoom.Click += editRoom_Click;
            // 
            // deleteRoom
            // 
            deleteRoom.Location = new Point(0, 90);
            deleteRoom.Name = "deleteRoom";
            deleteRoom.Size = new Size(250, 29);
            deleteRoom.TabIndex = 11;
            deleteRoom.Text = "Odayı Sil";
            deleteRoom.UseVisualStyleBackColor = true;
            deleteRoom.Click += deleteRoom_Click;
            // 
            // editRoomGroup
            // 
            editRoomGroup.Controls.Add(roomIDText);
            editRoomGroup.Controls.Add(roomIDLabel);
            editRoomGroup.Controls.Add(editRoomNameText);
            editRoomGroup.Controls.Add(editRoom);
            editRoomGroup.Controls.Add(editRoomNameLabel);
            editRoomGroup.Controls.Add(editPriceText);
            editRoomGroup.Controls.Add(editRoomTypeText);
            editRoomGroup.Controls.Add(editPriceLabel);
            editRoomGroup.Controls.Add(editRoomTypeLabel);
            editRoomGroup.Location = new Point(849, 92);
            editRoomGroup.Name = "editRoomGroup";
            editRoomGroup.Size = new Size(250, 279);
            editRoomGroup.TabIndex = 9;
            editRoomGroup.TabStop = false;
            editRoomGroup.Text = "Oda Düzenle";
            // 
            // roomIDText
            // 
            roomIDText.Location = new Point(119, 45);
            roomIDText.Name = "roomIDText";
            roomIDText.PlaceholderText = "Değiştirilemez";
            roomIDText.Size = new Size(125, 27);
            roomIDText.TabIndex = 9;
            // 
            // roomIDLabel
            // 
            roomIDLabel.AutoSize = true;
            roomIDLabel.Location = new Point(22, 45);
            roomIDLabel.Name = "roomIDLabel";
            roomIDLabel.Size = new Size(56, 20);
            roomIDLabel.TabIndex = 8;
            roomIDLabel.Text = "Oda ID";
            // 
            // editRoomNameText
            // 
            editRoomNameText.Location = new Point(119, 90);
            editRoomNameText.Name = "editRoomNameText";
            editRoomNameText.Size = new Size(125, 27);
            editRoomNameText.TabIndex = 7;
            // 
            // editRoomNameLabel
            // 
            editRoomNameLabel.AutoSize = true;
            editRoomNameLabel.Location = new Point(22, 90);
            editRoomNameLabel.Name = "editRoomNameLabel";
            editRoomNameLabel.Size = new Size(64, 20);
            editRoomNameLabel.TabIndex = 6;
            editRoomNameLabel.Text = "Oda Adı";
            // 
            // editPriceText
            // 
            editPriceText.Location = new Point(119, 180);
            editPriceText.Name = "editPriceText";
            editPriceText.Size = new Size(125, 27);
            editPriceText.TabIndex = 3;
            // 
            // editRoomTypeText
            // 
            editRoomTypeText.Location = new Point(119, 135);
            editRoomTypeText.Name = "editRoomTypeText";
            editRoomTypeText.Size = new Size(125, 27);
            editRoomTypeText.TabIndex = 2;
            // 
            // editPriceLabel
            // 
            editPriceLabel.AutoSize = true;
            editPriceLabel.Location = new Point(22, 180);
            editPriceLabel.Name = "editPriceLabel";
            editPriceLabel.Size = new Size(40, 20);
            editPriceLabel.TabIndex = 1;
            editPriceLabel.Text = "Fiyat";
            // 
            // editRoomTypeLabel
            // 
            editRoomTypeLabel.AutoSize = true;
            editRoomTypeLabel.Location = new Point(22, 135);
            editRoomTypeLabel.Name = "editRoomTypeLabel";
            editRoomTypeLabel.Size = new Size(66, 20);
            editRoomTypeLabel.TabIndex = 0;
            editRoomTypeLabel.Text = "Oda Tipi";
            // 
            // deleteRoomGroup
            // 
            deleteRoomGroup.Controls.Add(deletedRoomIDText);
            deleteRoomGroup.Controls.Add(deletedRoomIDLabel);
            deleteRoomGroup.Controls.Add(deleteRoom);
            deleteRoomGroup.Location = new Point(1520, 92);
            deleteRoomGroup.Name = "deleteRoomGroup";
            deleteRoomGroup.Size = new Size(250, 117);
            deleteRoomGroup.TabIndex = 12;
            deleteRoomGroup.TabStop = false;
            deleteRoomGroup.Text = "Oda Sil";
            // 
            // deletedRoomIDText
            // 
            deletedRoomIDText.Location = new Point(119, 45);
            deletedRoomIDText.Name = "deletedRoomIDText";
            deletedRoomIDText.Size = new Size(125, 27);
            deletedRoomIDText.TabIndex = 6;
            // 
            // deletedRoomIDLabel
            // 
            deletedRoomIDLabel.AutoSize = true;
            deletedRoomIDLabel.Location = new Point(22, 45);
            deletedRoomIDLabel.Name = "deletedRoomIDLabel";
            deletedRoomIDLabel.Size = new Size(56, 20);
            deletedRoomIDLabel.TabIndex = 6;
            deletedRoomIDLabel.Text = "Oda ID";
            // 
            // enrtyExitGroup
            // 
            enrtyExitGroup.Controls.Add(makeAnExit);
            enrtyExitGroup.Controls.Add(entryExitRoomIDText);
            enrtyExitGroup.Controls.Add(entryExitRoomIDLabel);
            enrtyExitGroup.Controls.Add(makeAnEntrance);
            enrtyExitGroup.Location = new Point(1520, 217);
            enrtyExitGroup.Name = "enrtyExitGroup";
            enrtyExitGroup.Size = new Size(250, 154);
            enrtyExitGroup.TabIndex = 13;
            enrtyExitGroup.TabStop = false;
            enrtyExitGroup.Text = "Giriş ve Çıkış ";
            // 
            // makeAnExit
            // 
            makeAnExit.Location = new Point(0, 125);
            makeAnExit.Name = "makeAnExit";
            makeAnExit.Size = new Size(250, 29);
            makeAnExit.TabIndex = 12;
            makeAnExit.Text = "Çıkış Yap";
            makeAnExit.UseVisualStyleBackColor = true;
            makeAnExit.Click += makeAnExit_Click;
            // 
            // entryExitRoomIDText
            // 
            entryExitRoomIDText.Location = new Point(119, 45);
            entryExitRoomIDText.Name = "entryExitRoomIDText";
            entryExitRoomIDText.Size = new Size(125, 27);
            entryExitRoomIDText.TabIndex = 6;
            // 
            // entryExitRoomIDLabel
            // 
            entryExitRoomIDLabel.AutoSize = true;
            entryExitRoomIDLabel.Location = new Point(22, 45);
            entryExitRoomIDLabel.Name = "entryExitRoomIDLabel";
            entryExitRoomIDLabel.Size = new Size(56, 20);
            entryExitRoomIDLabel.TabIndex = 6;
            entryExitRoomIDLabel.Text = "Oda ID";
            // 
            // makeAnEntrance
            // 
            makeAnEntrance.Location = new Point(0, 90);
            makeAnEntrance.Name = "makeAnEntrance";
            makeAnEntrance.Size = new Size(250, 29);
            makeAnEntrance.TabIndex = 11;
            makeAnEntrance.Text = "Giriş Yap";
            makeAnEntrance.UseVisualStyleBackColor = true;
            makeAnEntrance.Click += makeAnEntrance_Click;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(1685, 9);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(85, 20);
            dateLabel.TabIndex = 14;
            dateLabel.Text = "2012-12-12";
            // 
            // managerManagement
            // 
            managerManagement.BackColor = SystemColors.ActiveCaptionText;
            managerManagement.ForeColor = SystemColors.ControlLightLight;
            managerManagement.Location = new Point(12, 12);
            managerManagement.Name = "managerManagement";
            managerManagement.Size = new Size(161, 29);
            managerManagement.TabIndex = 15;
            managerManagement.Text = "Yönetici Yönetimi";
            managerManagement.UseVisualStyleBackColor = false;
            managerManagement.Click += managerManagement_Click;
            // 
            // signOutButton
            // 
            signOutButton.BackColor = SystemColors.ActiveCaptionText;
            signOutButton.ForeColor = SystemColors.ControlLightLight;
            signOutButton.Location = new Point(12, 172);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(161, 29);
            signOutButton.TabIndex = 26;
            signOutButton.Text = "Çıkış Yap";
            signOutButton.UseVisualStyleBackColor = false;
            signOutButton.Click += signOutButton_Click;
            // 
            // billManagement
            // 
            billManagement.BackColor = SystemColors.ActiveCaptionText;
            billManagement.ForeColor = SystemColors.ControlLightLight;
            billManagement.Location = new Point(12, 132);
            billManagement.Name = "billManagement";
            billManagement.Size = new Size(161, 29);
            billManagement.TabIndex = 25;
            billManagement.Text = "Fatura Yönetimi";
            billManagement.UseVisualStyleBackColor = false;
            billManagement.Click += billManagement_Click;
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
            // RoomPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1782, 553);
            Controls.Add(signedAsLabel);
            Controls.Add(signOutButton);
            Controls.Add(billManagement);
            Controls.Add(managerManagement);
            Controls.Add(dateLabel);
            Controls.Add(enrtyExitGroup);
            Controls.Add(deleteRoomGroup);
            Controls.Add(editRoomGroup);
            Controls.Add(createRoomGroup);
            Controls.Add(roomsList);
            Controls.Add(roomPageLabel);
            Controls.Add(reservationManagement);
            Controls.Add(customerManagement);
            Name = "RoomPage";
            Text = "RoomPage";
            Load += RoomPage_Load;
            createRoomGroup.ResumeLayout(false);
            createRoomGroup.PerformLayout();
            editRoomGroup.ResumeLayout(false);
            editRoomGroup.PerformLayout();
            deleteRoomGroup.ResumeLayout(false);
            deleteRoomGroup.PerformLayout();
            enrtyExitGroup.ResumeLayout(false);
            enrtyExitGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button customerManagement;
        private Button reservationManagement;
        private Label roomPageLabel;
        private ListView roomsList;
        private GroupBox createRoomGroup;
        private Label priceLabel;
        private Label roomTypeLabel;
        private TextBox roomTypeText;
        private TextBox priceText;
        private Button createRoom;
        private Button editRoom;
        private Button deleteRoom;
        private GroupBox editRoomGroup;
        private TextBox editPriceText;
        private TextBox editRoomTypeText;
        private Label editPriceLabel;
        private Label editRoomTypeLabel;
        private TextBox roomNameText;
        private Label roomNameLabel;
        private TextBox editRoomNameText;
        private Label editRoomNameLabel;
        private TextBox roomIDText;
        private Label roomIDLabel;
        private GroupBox deleteRoomGroup;
        private Label deletedRoomIDLabel;
        private TextBox deletedRoomIDText;
        private GroupBox enrtyExitGroup;
        private TextBox entryExitRoomIDText;
        private Label entryExitRoomIDLabel;
        private Button makeAnEntrance;
        private Button makeAnExit;
        private Label dateLabel;
        private Button managerManagement;
        private Button signOutButton;
        private Button billManagement;
        private Label signedAsLabel;
    }
}