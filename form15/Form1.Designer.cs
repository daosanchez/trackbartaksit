﻿namespace form15
{
    partial class Form1
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
            this.tbTaksit = new System.Windows.Forms.TrackBar();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblTaksit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbTaksit)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTaksit
            // 
            this.tbTaksit.Location = new System.Drawing.Point(46, 28);
            this.tbTaksit.Name = "tbTaksit";
            this.tbTaksit.Size = new System.Drawing.Size(287, 45);
            this.tbTaksit.TabIndex = 0;
            this.tbTaksit.Scroll += new System.EventHandler(this.tbTaksit_Scroll);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(199, 150);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(134, 23);
            this.btnHesapla.TabIndex = 1;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(46, 150);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(100, 20);
            this.txtTutar.TabIndex = 2;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(41, 214);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(70, 25);
            this.lblSonuc.TabIndex = 3;
            this.lblSonuc.Text = "label1";
            // 
            // lblTaksit
            // 
            this.lblTaksit.AutoSize = true;
            this.lblTaksit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaksit.Location = new System.Drawing.Point(42, 282);
            this.lblTaksit.Name = "lblTaksit";
            this.lblTaksit.Size = new System.Drawing.Size(60, 24);
            this.lblTaksit.TabIndex = 4;
            this.lblTaksit.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 380);
            this.Controls.Add(this.lblTaksit);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.tbTaksit);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbTaksit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbTaksit;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblTaksit;
    }
}

