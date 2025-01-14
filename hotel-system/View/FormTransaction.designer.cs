namespace PerpustakaanAppMVC.View
{
    partial class FormTransaction
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
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.lvwOrder = new System.Windows.Forms.ListView();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdOrder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search By Customer Name";
            this.label1.UseMnemonic = false;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(152, 6);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(393, 20);
            this.txtNama.TabIndex = 1;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(551, 4);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 23);
            this.btnCari.TabIndex = 2;
            this.btnCari.Text = "Find";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(15, 418);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 4;
            this.btnTambah.Text = "Pay";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(530, 415);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(96, 23);
            this.btnSelesai.TabIndex = 7;
            this.btnSelesai.Text = "Main Menu";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // lvwOrder
            // 
            this.lvwOrder.HideSelection = false;
            this.lvwOrder.Location = new System.Drawing.Point(15, 32);
            this.lvwOrder.Name = "lvwOrder";
            this.lvwOrder.Size = new System.Drawing.Size(611, 325);
            this.lvwOrder.TabIndex = 9;
            this.lvwOrder.UseCompatibleStateImageBehavior = false;
            this.lvwOrder.SelectedIndexChanged += new System.EventHandler(this.lvwOrder_SelectedIndexChanged);
            // 
            // txtCharge
            // 
            this.txtCharge.Location = new System.Drawing.Point(443, 363);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(183, 20);
            this.txtCharge.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Other Charge";
            this.label2.UseMnemonic = false;
            // 
            // txtBill
            // 
            this.txtBill.Location = new System.Drawing.Point(443, 389);
            this.txtBill.Name = "txtBill";
            this.txtBill.ReadOnly = true;
            this.txtBill.Size = new System.Drawing.Size(183, 20);
            this.txtBill.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total Bill";
            this.label3.UseMnemonic = false;
            // 
            // txtNight
            // 
            this.txtNight.Location = new System.Drawing.Point(106, 389);
            this.txtNight.Name = "txtNight";
            this.txtNight.ReadOnly = true;
            this.txtNight.Size = new System.Drawing.Size(183, 20);
            this.txtNight.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total Night";
            this.label4.UseMnemonic = false;
            // 
            // txtIdOrder
            // 
            this.txtIdOrder.Location = new System.Drawing.Point(106, 363);
            this.txtIdOrder.Name = "txtIdOrder";
            this.txtIdOrder.ReadOnly = true;
            this.txtIdOrder.Size = new System.Drawing.Size(183, 20);
            this.txtIdOrder.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Order Id";
            this.label5.UseMnemonic = false;
            // 
            // btnCek
            // 
            this.btnCek.Location = new System.Drawing.Point(449, 415);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(75, 23);
            this.btnCek.TabIndex = 18;
            this.btnCek.Text = "Check";
            this.btnCek.UseVisualStyleBackColor = true;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // FormTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.btnCek);
            this.Controls.Add(this.txtIdOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCharge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvwOrder);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders List - Choose the Order to Process the Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.ListView lvwOrder;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCek;
    }
}