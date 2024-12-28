namespace hotel_system.View
{
    partial class FormOrderRoom
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
            this.txtNama = new System.Windows.Forms.TextBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.lvwRoom = new System.Windows.Forms.ListView();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.dtIn = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtOut = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Room";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(145, 6);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(400, 20);
            this.txtNama.TabIndex = 1;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(551, 4);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 74);
            this.btnCari.TabIndex = 2;
            this.btnCari.Text = "Find";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // lvwRoom
            // 
            this.lvwRoom.HideSelection = false;
            this.lvwRoom.Location = new System.Drawing.Point(15, 84);
            this.lvwRoom.Name = "lvwRoom";
            this.lvwRoom.Size = new System.Drawing.Size(611, 325);
            this.lvwRoom.TabIndex = 3;
            this.lvwRoom.UseCompatibleStateImageBehavior = false;
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(551, 415);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(75, 23);
            this.btnSelesai.TabIndex = 7;
            this.btnSelesai.Text = "Next";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(515, 417);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(30, 20);
            this.txtCount.TabIndex = 8;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(15, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtIn
            // 
            this.dtIn.Location = new System.Drawing.Point(145, 32);
            this.dtIn.Name = "dtIn";
            this.dtIn.Size = new System.Drawing.Size(400, 20);
            this.dtIn.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Check In";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Check Out";
            // 
            // dtOut
            // 
            this.dtOut.Location = new System.Drawing.Point(145, 58);
            this.dtOut.Name = "dtOut";
            this.dtOut.Size = new System.Drawing.Size(400, 20);
            this.dtOut.TabIndex = 12;
            // 
            // FormOrderRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtIn);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.lvwRoom);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormOrderRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.ListView lvwRoom;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dtIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtOut;
    }
}