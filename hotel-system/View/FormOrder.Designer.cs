namespace hotel_system.View
{
    partial class FormOrder
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
            this.lvwCustomer = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchCus = new System.Windows.Forms.TextBox();
            this.btnFindCus = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvwRoom = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFindRoom = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTypeRoom = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCusId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCusBirth = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCusGender = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCusAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCusPhone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRoomPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRoomCap = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRoomId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBathRoom = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtOutRoom = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtInRoom = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDot = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwCustomer
            // 
            this.lvwCustomer.HideSelection = false;
            this.lvwCustomer.Location = new System.Drawing.Point(6, 49);
            this.lvwCustomer.Name = "lvwCustomer";
            this.lvwCustomer.Size = new System.Drawing.Size(598, 244);
            this.lvwCustomer.TabIndex = 0;
            this.lvwCustomer.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Customer";
            // 
            // txtSearchCus
            // 
            this.txtSearchCus.Location = new System.Drawing.Point(128, 22);
            this.txtSearchCus.Name = "txtSearchCus";
            this.txtSearchCus.Size = new System.Drawing.Size(395, 20);
            this.txtSearchCus.TabIndex = 2;
            // 
            // btnFindCus
            // 
            this.btnFindCus.Location = new System.Drawing.Point(529, 20);
            this.btnFindCus.Name = "btnFindCus";
            this.btnFindCus.Size = new System.Drawing.Size(75, 23);
            this.btnFindCus.TabIndex = 3;
            this.btnFindCus.Text = "Find";
            this.btnFindCus.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lvwCustomer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearchCus);
            this.groupBox1.Controls.Add(this.btnFindCus);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 328);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Customer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxTypeRoom);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.lvwRoom);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnFindRoom);
            this.groupBox2.Location = new System.Drawing.Point(633, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 328);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose Room";
            // 
            // lvwRoom
            // 
            this.lvwRoom.HideSelection = false;
            this.lvwRoom.Location = new System.Drawing.Point(6, 100);
            this.lvwRoom.Name = "lvwRoom";
            this.lvwRoom.Size = new System.Drawing.Size(600, 222);
            this.lvwRoom.TabIndex = 0;
            this.lvwRoom.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search Room";
            // 
            // btnFindRoom
            // 
            this.btnFindRoom.Location = new System.Drawing.Point(529, 19);
            this.btnFindRoom.Name = "btnFindRoom";
            this.btnFindRoom.Size = new System.Drawing.Size(75, 73);
            this.btnFindRoom.TabIndex = 3;
            this.btnFindRoom.Text = "Find";
            this.btnFindRoom.UseVisualStyleBackColor = true;
            this.btnFindRoom.Click += new System.EventHandler(this.btnFindRoom_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(128, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(395, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(128, 74);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(395, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Check In";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Check Out";
            // 
            // cbxTypeRoom
            // 
            this.cbxTypeRoom.FormattingEnabled = true;
            this.cbxTypeRoom.Items.AddRange(new object[] {
            " ",
            "Single",
            "Twin",
            "Queen",
            "King"});
            this.cbxTypeRoom.Location = new System.Drawing.Point(128, 21);
            this.cbxTypeRoom.Name = "cbxTypeRoom";
            this.cbxTypeRoom.Size = new System.Drawing.Size(395, 21);
            this.cbxTypeRoom.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(87, 299);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txtDot);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txtDin);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtBathRoom);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtOutRoom);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtInRoom);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtRoomPrice);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtRoomCap);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtRoomType);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtRoomId);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtCusPhone);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtCusAddress);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtCusGender);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtCusBirth);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtCusName);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtCusId);
            this.groupBox3.Location = new System.Drawing.Point(12, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1231, 199);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Customer\'s ID";
            // 
            // txtCusId
            // 
            this.txtCusId.Location = new System.Drawing.Point(128, 19);
            this.txtCusId.Name = "txtCusId";
            this.txtCusId.Size = new System.Drawing.Size(166, 20);
            this.txtCusId.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Customer\'s Name";
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(128, 43);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(166, 20);
            this.txtCusName.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Customer\'s Birth Date";
            // 
            // txtCusBirth
            // 
            this.txtCusBirth.Location = new System.Drawing.Point(128, 69);
            this.txtCusBirth.Name = "txtCusBirth";
            this.txtCusBirth.Size = new System.Drawing.Size(166, 20);
            this.txtCusBirth.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Customer\'s Gender";
            // 
            // txtCusGender
            // 
            this.txtCusGender.Location = new System.Drawing.Point(128, 95);
            this.txtCusGender.Name = "txtCusGender";
            this.txtCusGender.Size = new System.Drawing.Size(166, 20);
            this.txtCusGender.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Customer\'s Address";
            // 
            // txtCusAddress
            // 
            this.txtCusAddress.Location = new System.Drawing.Point(128, 121);
            this.txtCusAddress.Multiline = true;
            this.txtCusAddress.Name = "txtCusAddress";
            this.txtCusAddress.Size = new System.Drawing.Size(166, 46);
            this.txtCusAddress.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Customer\'s Phone";
            // 
            // txtCusPhone
            // 
            this.txtCusPhone.Location = new System.Drawing.Point(128, 173);
            this.txtCusPhone.Name = "txtCusPhone";
            this.txtCusPhone.Size = new System.Drawing.Size(166, 20);
            this.txtCusPhone.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(316, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Room\'s Price";
            // 
            // txtRoomPrice
            // 
            this.txtRoomPrice.Location = new System.Drawing.Point(438, 97);
            this.txtRoomPrice.Name = "txtRoomPrice";
            this.txtRoomPrice.Size = new System.Drawing.Size(166, 20);
            this.txtRoomPrice.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(316, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Room\'s Capacity";
            // 
            // txtRoomCap
            // 
            this.txtRoomCap.Location = new System.Drawing.Point(438, 71);
            this.txtRoomCap.Name = "txtRoomCap";
            this.txtRoomCap.Size = new System.Drawing.Size(166, 20);
            this.txtRoomCap.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(316, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Room\'s Type";
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(438, 45);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(166, 20);
            this.txtRoomType.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(316, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Room\'s Number";
            // 
            // txtRoomId
            // 
            this.txtRoomId.Location = new System.Drawing.Point(438, 21);
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.Size = new System.Drawing.Size(166, 20);
            this.txtRoomId.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(316, 176);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Bathroom Amenities";
            // 
            // txtBathRoom
            // 
            this.txtBathRoom.Location = new System.Drawing.Point(438, 173);
            this.txtBathRoom.Name = "txtBathRoom";
            this.txtBathRoom.Size = new System.Drawing.Size(166, 20);
            this.txtBathRoom.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(316, 150);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Out-Room Amenities";
            // 
            // txtOutRoom
            // 
            this.txtOutRoom.Location = new System.Drawing.Point(438, 147);
            this.txtOutRoom.Name = "txtOutRoom";
            this.txtOutRoom.Size = new System.Drawing.Size(166, 20);
            this.txtOutRoom.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(316, 124);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "In-Room Amenities";
            // 
            // txtInRoom
            // 
            this.txtInRoom.Location = new System.Drawing.Point(438, 121);
            this.txtInRoom.Name = "txtInRoom";
            this.txtInRoom.Size = new System.Drawing.Size(166, 20);
            this.txtInRoom.TabIndex = 29;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(624, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Check Out Date";
            // 
            // txtDot
            // 
            this.txtDot.Location = new System.Drawing.Point(746, 45);
            this.txtDot.Name = "txtDot";
            this.txtDot.Size = new System.Drawing.Size(166, 20);
            this.txtDot.TabIndex = 37;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(624, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 13);
            this.label19.TabIndex = 34;
            this.label19.Text = "Check In Date";
            // 
            // txtDin
            // 
            this.txtDin.Location = new System.Drawing.Point(746, 21);
            this.txtDin.Name = "txtDin";
            this.txtDin.Size = new System.Drawing.Size(166, 20);
            this.txtDin.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1150, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 170);
            this.button1.TabIndex = 9;
            this.button1.Text = "Place Order";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 553);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Order";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchCus;
        private System.Windows.Forms.Button btnFindCus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListView lvwRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFindRoom;
        private System.Windows.Forms.ComboBox cbxTypeRoom;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCusAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCusGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCusBirth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCusId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCusPhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRoomPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRoomCap;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtRoomId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBathRoom;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtOutRoom;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtInRoom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDot;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDin;
    }
}