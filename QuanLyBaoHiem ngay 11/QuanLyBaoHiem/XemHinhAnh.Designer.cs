namespace QuanLyBaoHiem
{
    partial class XemHinhAnh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XemHinhAnh));
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnTieptheo = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuiLai = new DevExpress.XtraEditors.SimpleButton();
            this.imagebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagebox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(196, 356);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 43);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnTieptheo
            // 
            this.btnTieptheo.Enabled = false;
            this.btnTieptheo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTieptheo.ImageOptions.Image")));
            this.btnTieptheo.Location = new System.Drawing.Point(303, 356);
            this.btnTieptheo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTieptheo.Name = "btnTieptheo";
            this.btnTieptheo.Size = new System.Drawing.Size(110, 43);
            this.btnTieptheo.TabIndex = 4;
            this.btnTieptheo.Text = "Tiếp Theo";
            this.btnTieptheo.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // btnLuiLai
            // 
            this.btnLuiLai.Enabled = false;
            this.btnLuiLai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuiLai.ImageOptions.Image")));
            this.btnLuiLai.Location = new System.Drawing.Point(76, 356);
            this.btnLuiLai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuiLai.Name = "btnLuiLai";
            this.btnLuiLai.Size = new System.Drawing.Size(103, 43);
            this.btnLuiLai.TabIndex = 2;
            this.btnLuiLai.Text = "Lùi lại";
            this.btnLuiLai.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // imagebox
            // 
            this.imagebox.Location = new System.Drawing.Point(110, 60);
            this.imagebox.Margin = new System.Windows.Forms.Padding(2);
            this.imagebox.Name = "imagebox";
            this.imagebox.Size = new System.Drawing.Size(246, 245);
            this.imagebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagebox.TabIndex = 1;
            this.imagebox.TabStop = false;
            // 
            // XemHinhAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 452);
            this.Controls.Add(this.btnTieptheo);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuiLai);
            this.Controls.Add(this.imagebox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XemHinhAnh";
            this.Text = "Xem hình ảnh";
            this.Load += new System.EventHandler(this.XemHinhAnh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagebox;
        private DevExpress.XtraEditors.SimpleButton btnLuiLai;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnTieptheo;
    }
}