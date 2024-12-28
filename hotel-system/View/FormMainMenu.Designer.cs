namespace hotel_system.View
{
    partial class FormMainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOTEL ADMINISTRATION SYSTEM";
            // 
            // btnRoom
            // 
            this.btnRoom.Location = new System.Drawing.Point(241, 113);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(140, 23);
            this.btnRoom.TabIndex = 1;
            this.btnRoom.Text = "Rooms";
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(241, 142);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(140, 23);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(241, 171);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(140, 23);
            this.btnOrders.TabIndex = 3;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(241, 200);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(140, 23);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "Transactions";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(12, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(241, 229);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(140, 23);
            this.btnLog.TabIndex = 6;
            this.btnLog.Text = "Order Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 332);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnRoom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLog;
    }
}