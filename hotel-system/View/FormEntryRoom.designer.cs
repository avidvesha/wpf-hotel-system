namespace hotel_system.View
{
    partial class FormEntryRoom
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtCapacity = new System.Windows.Forms.NumericUpDown();
            this.cbxInroom = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxBathroom = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxOutroom = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(102, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(231, 20);
            this.txtId.TabIndex = 1;
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(258, 209);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(75, 23);
            this.btnSelesai.TabIndex = 2;
            this.btnSelesai.Text = "Done";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Capacity";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(177, 209);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 7;
            this.btnSimpan.Text = "Save";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(102, 90);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(231, 20);
            this.txtPrice.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Single",
            "Twin",
            "Queen",
            "King"});
            this.cmbType.Location = new System.Drawing.Point(102, 38);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(231, 21);
            this.cmbType.TabIndex = 10;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(102, 67);
            this.txtCapacity.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.txtCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(231, 20);
            this.txtCapacity.TabIndex = 11;
            this.txtCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxInroom
            // 
            this.cbxInroom.AutoSize = true;
            this.cbxInroom.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxInroom.Location = new System.Drawing.Point(100, 19);
            this.cbxInroom.Name = "cbxInroom";
            this.cbxInroom.Size = new System.Drawing.Size(15, 14);
            this.cbxInroom.TabIndex = 12;
            this.cbxInroom.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbxBathroom);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbxOutroom);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbxInroom);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 85);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Amenities";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Bathroom";
            // 
            // cbxBathroom
            // 
            this.cbxBathroom.AutoSize = true;
            this.cbxBathroom.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxBathroom.Location = new System.Drawing.Point(100, 59);
            this.cbxBathroom.Name = "cbxBathroom";
            this.cbxBathroom.Size = new System.Drawing.Size(15, 14);
            this.cbxBathroom.TabIndex = 18;
            this.cbxBathroom.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Out-Room";
            // 
            // cbxOutroom
            // 
            this.cbxOutroom.AutoSize = true;
            this.cbxOutroom.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxOutroom.Location = new System.Drawing.Point(100, 39);
            this.cbxOutroom.Name = "cbxOutroom";
            this.cbxOutroom.Size = new System.Drawing.Size(15, 14);
            this.cbxOutroom.TabIndex = 16;
            this.cbxOutroom.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "In-Room";
            // 
            // FormEntryRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 243);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEntryRoom";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Room";
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.NumericUpDown txtCapacity;
        private System.Windows.Forms.CheckBox cbxInroom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbxBathroom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbxOutroom;
    }
}