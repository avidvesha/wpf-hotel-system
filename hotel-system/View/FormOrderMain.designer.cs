namespace PerpustakaanAppMVC.View
{
    partial class FormOrderMain
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
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lvwOrder = new System.Windows.Forms.ListView();
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
            this.btnTambah.Location = new System.Drawing.Point(12, 415);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 4;
            this.btnTambah.Text = "Add";
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
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(480, 418);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(44, 20);
            this.txtCount.TabIndex = 8;
            // 
            // lvwOrder
            // 
            this.lvwOrder.HideSelection = false;
            this.lvwOrder.Location = new System.Drawing.Point(15, 32);
            this.lvwOrder.Name = "lvwOrder";
            this.lvwOrder.Size = new System.Drawing.Size(611, 377);
            this.lvwOrder.TabIndex = 9;
            this.lvwOrder.UseCompatibleStateImageBehavior = false;
            // 
            // FormOrderMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.lvwOrder);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormOrderMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.ListView lvwOrder;
    }
}