namespace HotelReservationSystem
{
    partial class BillPage
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
            managerManagement = new Button();
            reservationManagement = new Button();
            roomManagement = new Button();
            customerManagement = new Button();
            signOutButton = new Button();
            dateLabel = new Label();
            signedAsLabel = new Label();
            billPageLabel = new Label();
            getByCustomerGroup = new GroupBox();
            getCustomerIDText = new TextBox();
            getBillByCustomer = new Button();
            getCustomerIDLabel = new Label();
            label1 = new Label();
            getByManagerGroup = new GroupBox();
            getManagerIDText = new TextBox();
            getBillByManager = new Button();
            getManagerIDLabel = new Label();
            label3 = new Label();
            billsList = new ListView();
            getByRoomGroup = new GroupBox();
            getRoomIDText = new TextBox();
            getBillByRoom = new Button();
            getRoomIDLabel = new Label();
            label5 = new Label();
            getByPriceGroup = new GroupBox();
            getPriceText = new TextBox();
            getBillByPrice = new Button();
            getPriceLabel = new Label();
            label7 = new Label();
            getByDateGroup = new GroupBox();
            getDateText = new TextBox();
            getBillByDate = new Button();
            getDateLabel = new Label();
            label9 = new Label();
            getByBillIDGroup = new GroupBox();
            getBillIDText = new TextBox();
            getBillByBilID = new Button();
            getBillIDLabel = new Label();
            label4 = new Label();
            getByCustomerGroup.SuspendLayout();
            getByManagerGroup.SuspendLayout();
            getByRoomGroup.SuspendLayout();
            getByPriceGroup.SuspendLayout();
            getByDateGroup.SuspendLayout();
            getByBillIDGroup.SuspendLayout();
            SuspendLayout();
            // 
            // managerManagement
            // 
            managerManagement.BackColor = SystemColors.ActiveCaptionText;
            managerManagement.ForeColor = SystemColors.ControlLightLight;
            managerManagement.Location = new Point(12, 12);
            managerManagement.Name = "managerManagement";
            managerManagement.Size = new Size(161, 29);
            managerManagement.TabIndex = 17;
            managerManagement.Text = "Yönetici Yönetimi";
            managerManagement.UseVisualStyleBackColor = false;
            managerManagement.Click += managerManagement_Click;
            // 
            // reservationManagement
            // 
            reservationManagement.BackColor = SystemColors.ActiveCaptionText;
            reservationManagement.ForeColor = SystemColors.ControlLightLight;
            reservationManagement.Location = new Point(12, 52);
            reservationManagement.Name = "reservationManagement";
            reservationManagement.Size = new Size(161, 29);
            reservationManagement.TabIndex = 18;
            reservationManagement.Text = "Rezervasyon Yönetimi";
            reservationManagement.UseVisualStyleBackColor = false;
            reservationManagement.Click += reservationManagement_Click;
            // 
            // roomManagement
            // 
            roomManagement.BackColor = SystemColors.ActiveCaptionText;
            roomManagement.ForeColor = SystemColors.ControlLightLight;
            roomManagement.Location = new Point(12, 92);
            roomManagement.Name = "roomManagement";
            roomManagement.Size = new Size(161, 29);
            roomManagement.TabIndex = 19;
            roomManagement.Text = "Oda Yönetimi";
            roomManagement.UseVisualStyleBackColor = false;
            roomManagement.Click += roomManagement_Click;
            // 
            // customerManagement
            // 
            customerManagement.BackColor = SystemColors.ActiveCaptionText;
            customerManagement.ForeColor = SystemColors.ControlLightLight;
            customerManagement.Location = new Point(12, 132);
            customerManagement.Name = "customerManagement";
            customerManagement.Size = new Size(161, 29);
            customerManagement.TabIndex = 20;
            customerManagement.Text = "Müşteri Yönetimi";
            customerManagement.UseVisualStyleBackColor = false;
            customerManagement.Click += customerManagement_Click;
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
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(1685, 9);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(85, 20);
            dateLabel.TabIndex = 26;
            dateLabel.Text = "2012-12-12";
            // 
            // signedAsLabel
            // 
            signedAsLabel.AutoSize = true;
            signedAsLabel.Location = new Point(1427, 9);
            signedAsLabel.Name = "signedAsLabel";
            signedAsLabel.Size = new Size(202, 20);
            signedAsLabel.TabIndex = 29;
            signedAsLabel.Text = ".......... .......... olarak giriş yapıldı.";
            // 
            // billPageLabel
            // 
            billPageLabel.AutoSize = true;
            billPageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            billPageLabel.Location = new Point(783, 9);
            billPageLabel.Name = "billPageLabel";
            billPageLabel.Size = new Size(233, 28);
            billPageLabel.TabIndex = 30;
            billPageLabel.Text = "Fatura Yönetimi Sayfası";
            // 
            // getByCustomerGroup
            // 
            getByCustomerGroup.Controls.Add(getCustomerIDText);
            getByCustomerGroup.Controls.Add(getBillByCustomer);
            getByCustomerGroup.Controls.Add(getCustomerIDLabel);
            getByCustomerGroup.Controls.Add(label1);
            getByCustomerGroup.Location = new Point(179, 92);
            getByCustomerGroup.Name = "getByCustomerGroup";
            getByCustomerGroup.Size = new Size(250, 117);
            getByCustomerGroup.TabIndex = 31;
            getByCustomerGroup.TabStop = false;
            getByCustomerGroup.Text = "Müşteriye Göre Fatura Bul";
            // 
            // getCustomerIDText
            // 
            getCustomerIDText.Location = new Point(119, 45);
            getCustomerIDText.Name = "getCustomerIDText";
            getCustomerIDText.Size = new Size(125, 27);
            getCustomerIDText.TabIndex = 8;
            // 
            // getBillByCustomer
            // 
            getBillByCustomer.Location = new Point(0, 88);
            getBillByCustomer.Name = "getBillByCustomer";
            getBillByCustomer.Size = new Size(250, 29);
            getBillByCustomer.TabIndex = 13;
            getBillByCustomer.Text = "Fatura Bul";
            getBillByCustomer.UseVisualStyleBackColor = true;
            getBillByCustomer.Click += getBillByCustomer_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 48);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 8;
            // 
            // getByManagerGroup
            // 
            getByManagerGroup.Controls.Add(getManagerIDText);
            getByManagerGroup.Controls.Add(getBillByManager);
            getByManagerGroup.Controls.Add(getManagerIDLabel);
            getByManagerGroup.Controls.Add(label3);
            getByManagerGroup.Location = new Point(179, 243);
            getByManagerGroup.Name = "getByManagerGroup";
            getByManagerGroup.Size = new Size(250, 117);
            getByManagerGroup.TabIndex = 32;
            getByManagerGroup.TabStop = false;
            getByManagerGroup.Text = "Yöneticiye Göre Fatura Bul";
            // 
            // getManagerIDText
            // 
            getManagerIDText.Location = new Point(119, 45);
            getManagerIDText.Name = "getManagerIDText";
            getManagerIDText.Size = new Size(125, 27);
            getManagerIDText.TabIndex = 8;
            // 
            // getBillByManager
            // 
            getBillByManager.Location = new Point(0, 88);
            getBillByManager.Name = "getBillByManager";
            getBillByManager.Size = new Size(250, 29);
            getBillByManager.TabIndex = 13;
            getBillByManager.Text = "Fatura Bul";
            getBillByManager.UseVisualStyleBackColor = true;
            getBillByManager.Click += getBillByManager_Click;
            // 
            // getManagerIDLabel
            // 
            getManagerIDLabel.AutoSize = true;
            getManagerIDLabel.Location = new Point(22, 45);
            getManagerIDLabel.Name = "getManagerIDLabel";
            getManagerIDLabel.Size = new Size(80, 20);
            getManagerIDLabel.TabIndex = 8;
            getManagerIDLabel.Text = "Yönetici ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 48);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 8;
            // 
            // billsList
            // 
            billsList.GridLines = true;
            billsList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            billsList.Location = new Point(12, 366);
            billsList.MultiSelect = false;
            billsList.Name = "billsList";
            billsList.Size = new Size(1752, 175);
            billsList.TabIndex = 33;
            billsList.UseCompatibleStateImageBehavior = false;
            billsList.View = View.Details;
            // 
            // getByRoomGroup
            // 
            getByRoomGroup.Controls.Add(getRoomIDText);
            getByRoomGroup.Controls.Add(getBillByRoom);
            getByRoomGroup.Controls.Add(getRoomIDLabel);
            getByRoomGroup.Controls.Add(label5);
            getByRoomGroup.Location = new Point(849, 92);
            getByRoomGroup.Name = "getByRoomGroup";
            getByRoomGroup.Size = new Size(250, 117);
            getByRoomGroup.TabIndex = 32;
            getByRoomGroup.TabStop = false;
            getByRoomGroup.Text = "Odaya Göre Fatura Bul";
            // 
            // getRoomIDText
            // 
            getRoomIDText.Location = new Point(119, 45);
            getRoomIDText.Name = "getRoomIDText";
            getRoomIDText.Size = new Size(125, 27);
            getRoomIDText.TabIndex = 8;
            // 
            // getBillByRoom
            // 
            getBillByRoom.Location = new Point(0, 88);
            getBillByRoom.Name = "getBillByRoom";
            getBillByRoom.Size = new Size(250, 29);
            getBillByRoom.TabIndex = 13;
            getBillByRoom.Text = "Fatura Bul";
            getBillByRoom.UseVisualStyleBackColor = true;
            getBillByRoom.Click += getBillByRoom_Click;
            // 
            // getRoomIDLabel
            // 
            getRoomIDLabel.AutoSize = true;
            getRoomIDLabel.Location = new Point(22, 45);
            getRoomIDLabel.Name = "getRoomIDLabel";
            getRoomIDLabel.Size = new Size(56, 20);
            getRoomIDLabel.TabIndex = 8;
            getRoomIDLabel.Text = "Oda ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 48);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 8;
            // 
            // getByPriceGroup
            // 
            getByPriceGroup.Controls.Add(getPriceText);
            getByPriceGroup.Controls.Add(getBillByPrice);
            getByPriceGroup.Controls.Add(getPriceLabel);
            getByPriceGroup.Controls.Add(label7);
            getByPriceGroup.Location = new Point(849, 243);
            getByPriceGroup.Name = "getByPriceGroup";
            getByPriceGroup.Size = new Size(250, 117);
            getByPriceGroup.TabIndex = 32;
            getByPriceGroup.TabStop = false;
            getByPriceGroup.Text = "Fiyata Göre Fatura Bul";
            // 
            // getPriceText
            // 
            getPriceText.Location = new Point(119, 45);
            getPriceText.Name = "getPriceText";
            getPriceText.Size = new Size(125, 27);
            getPriceText.TabIndex = 8;
            // 
            // getBillByPrice
            // 
            getBillByPrice.Location = new Point(0, 88);
            getBillByPrice.Name = "getBillByPrice";
            getBillByPrice.Size = new Size(250, 29);
            getBillByPrice.TabIndex = 13;
            getBillByPrice.Text = "Fatura Bul";
            getBillByPrice.UseVisualStyleBackColor = true;
            getBillByPrice.Click += getBillByPrice_Click;
            // 
            // getPriceLabel
            // 
            getPriceLabel.AutoSize = true;
            getPriceLabel.Location = new Point(22, 45);
            getPriceLabel.Name = "getPriceLabel";
            getPriceLabel.Size = new Size(40, 20);
            getPriceLabel.TabIndex = 8;
            getPriceLabel.Text = "Fiyat";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 48);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 8;
            // 
            // getByDateGroup
            // 
            getByDateGroup.Controls.Add(getDateText);
            getByDateGroup.Controls.Add(getBillByDate);
            getByDateGroup.Controls.Add(getDateLabel);
            getByDateGroup.Controls.Add(label9);
            getByDateGroup.Location = new Point(1520, 92);
            getByDateGroup.Name = "getByDateGroup";
            getByDateGroup.Size = new Size(250, 117);
            getByDateGroup.TabIndex = 32;
            getByDateGroup.TabStop = false;
            getByDateGroup.Text = "Tarihe Göre Fatura Bul";
            // 
            // getDateText
            // 
            getDateText.Location = new Point(119, 45);
            getDateText.Name = "getDateText";
            getDateText.PlaceholderText = "yıl-ay-gün";
            getDateText.Size = new Size(125, 27);
            getDateText.TabIndex = 8;
            // 
            // getBillByDate
            // 
            getBillByDate.Location = new Point(0, 88);
            getBillByDate.Name = "getBillByDate";
            getBillByDate.Size = new Size(250, 29);
            getBillByDate.TabIndex = 13;
            getBillByDate.Text = "Fatura Bul";
            getBillByDate.UseVisualStyleBackColor = true;
            getBillByDate.Click += getBillByDate_Click;
            // 
            // getDateLabel
            // 
            getDateLabel.AutoSize = true;
            getDateLabel.Location = new Point(22, 45);
            getDateLabel.Name = "getDateLabel";
            getDateLabel.Size = new Size(40, 20);
            getDateLabel.TabIndex = 8;
            getDateLabel.Text = "Tarih";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 48);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 8;
            // 
            // getByBillIDGroup
            // 
            getByBillIDGroup.Controls.Add(getBillIDText);
            getByBillIDGroup.Controls.Add(getBillByBilID);
            getByBillIDGroup.Controls.Add(getBillIDLabel);
            getByBillIDGroup.Controls.Add(label4);
            getByBillIDGroup.Location = new Point(1520, 243);
            getByBillIDGroup.Name = "getByBillIDGroup";
            getByBillIDGroup.Size = new Size(250, 117);
            getByBillIDGroup.TabIndex = 33;
            getByBillIDGroup.TabStop = false;
            getByBillIDGroup.Text = "Fatura ID'ye Göre Fatura Bul";
            // 
            // getBillIDText
            // 
            getBillIDText.Location = new Point(119, 45);
            getBillIDText.Name = "getBillIDText";
            getBillIDText.Size = new Size(125, 27);
            getBillIDText.TabIndex = 8;
            // 
            // getBillByBilID
            // 
            getBillByBilID.Location = new Point(0, 88);
            getBillByBilID.Name = "getBillByBilID";
            getBillByBilID.Size = new Size(250, 29);
            getBillByBilID.TabIndex = 13;
            getBillByBilID.Text = "Fatura Bul";
            getBillByBilID.UseVisualStyleBackColor = true;
            getBillByBilID.Click += getBillByBilID_Click;
            // 
            // getBillIDLabel
            // 
            getBillIDLabel.AutoSize = true;
            getBillIDLabel.Location = new Point(22, 45);
            getBillIDLabel.Name = "getBillIDLabel";
            getBillIDLabel.Size = new Size(68, 20);
            getBillIDLabel.TabIndex = 8;
            getBillIDLabel.Text = "Fatura ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 48);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 8;
            // 
            // BillPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1782, 553);
            Controls.Add(getByBillIDGroup);
            Controls.Add(getByDateGroup);
            Controls.Add(getByPriceGroup);
            Controls.Add(getByRoomGroup);
            Controls.Add(billsList);
            Controls.Add(getByManagerGroup);
            Controls.Add(getByCustomerGroup);
            Controls.Add(billPageLabel);
            Controls.Add(signedAsLabel);
            Controls.Add(dateLabel);
            Controls.Add(signOutButton);
            Controls.Add(customerManagement);
            Controls.Add(roomManagement);
            Controls.Add(reservationManagement);
            Controls.Add(managerManagement);
            Name = "BillPage";
            Text = "BillPage";
            Load += BillPage_Load;
            getByCustomerGroup.ResumeLayout(false);
            getByCustomerGroup.PerformLayout();
            getByManagerGroup.ResumeLayout(false);
            getByManagerGroup.PerformLayout();
            getByRoomGroup.ResumeLayout(false);
            getByRoomGroup.PerformLayout();
            getByPriceGroup.ResumeLayout(false);
            getByPriceGroup.PerformLayout();
            getByDateGroup.ResumeLayout(false);
            getByDateGroup.PerformLayout();
            getByBillIDGroup.ResumeLayout(false);
            getByBillIDGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button managerManagement;
        private Button reservationManagement;
        private Button roomManagement;
        private Button customerManagement;
        private Button signOutButton;
        private Label dateLabel;
        private Label signedAsLabel;
        private Label billPageLabel;
        private GroupBox getByCustomerGroup;
        private TextBox getCustomerIDText;
        private Button getBillByCustomer;
        private Label getCustomerIDLabel;
        private Label label1;
        private GroupBox getByManagerGroup;
        private TextBox getManagerIDText;
        private Button getBillByManager;
        private Label getManagerIDLabel;
        private Label label3;
        private ListView billsList;
        private GroupBox getByRoomGroup;
        private TextBox getRoomIDText;
        private Button getBillByRoom;
        private Label getRoomIDLabel;
        private Label label5;
        private GroupBox getByPriceGroup;
        private TextBox getPriceText;
        private Button getBillByPrice;
        private Label getPriceLabel;
        private Label label7;
        private GroupBox getByDateGroup;
        private TextBox getDateText;
        private Button getBillByDate;
        private Label getDateLabel;
        private Label label9;
        private GroupBox getByBillIDGroup;
        private TextBox getBillIDText;
        private Button getBillByBilID;
        private Label getBillIDLabel;
        private Label label4;
    }
}