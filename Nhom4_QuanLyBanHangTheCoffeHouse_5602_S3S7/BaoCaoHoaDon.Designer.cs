namespace Quanlyquancoffe
{
    partial class BaoCaoHoaDon
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
            this.rpwrBaoCao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnThoat = new ePOSOne.btnProduct.Button_WOC();
            this.btnTaoBaoCao = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // rpwrBaoCao
            // 
            this.rpwrBaoCao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rpwrBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpwrBaoCao.Location = new System.Drawing.Point(0, 0);
            this.rpwrBaoCao.Name = "rpwrBaoCao";
            this.rpwrBaoCao.ServerReport.BearerToken = null;
            this.rpwrBaoCao.Size = new System.Drawing.Size(921, 579);
            this.rpwrBaoCao.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnThoat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnThoat.ButtonColor = System.Drawing.Color.OrangeRed;
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnThoat.Location = new System.Drawing.Point(744, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnThoat.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThoat.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnThoat.Size = new System.Drawing.Size(72, 26);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTaoBaoCao
            // 
            this.btnTaoBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTaoBaoCao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnTaoBaoCao.ButtonColor = System.Drawing.Color.OrangeRed;
            this.btnTaoBaoCao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnTaoBaoCao.Location = new System.Drawing.Point(645, 0);
            this.btnTaoBaoCao.Name = "btnTaoBaoCao";
            this.btnTaoBaoCao.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnTaoBaoCao.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTaoBaoCao.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnTaoBaoCao.Size = new System.Drawing.Size(72, 26);
            this.btnTaoBaoCao.TabIndex = 13;
            this.btnTaoBaoCao.Text = "Tạo báo cáo";
            this.btnTaoBaoCao.TextColor = System.Drawing.Color.White;
            this.btnTaoBaoCao.UseVisualStyleBackColor = false;
            this.btnTaoBaoCao.Click += new System.EventHandler(this.btnTaoBaoCao_Click);
            // 
            // BaoCaoHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 579);
            this.Controls.Add(this.btnTaoBaoCao);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.rpwrBaoCao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaoCaoHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaoCaoHoaDon";
            this.Load += new System.EventHandler(this.BaoCaoHoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpwrBaoCao;
        private ePOSOne.btnProduct.Button_WOC btnThoat;
        private ePOSOne.btnProduct.Button_WOC btnTaoBaoCao;
    }
}