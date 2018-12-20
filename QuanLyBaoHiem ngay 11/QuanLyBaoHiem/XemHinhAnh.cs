using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyBaoHiem.DAO;
using System.IO;
using QuanLyBaoHiem.Models;

namespace QuanLyBaoHiem
{
    public partial class XemHinhAnh : DevExpress.XtraEditors.XtraForm
    {
        ucQuanLyThongTinKhachHang f;
        public string MaKH;
        List<HinhAnh> listhinhanh = new List<HinhAnh>();
        public int soluong=0;
        public int vitri = 0;
        public XemHinhAnh(string MaKH,ucQuanLyThongTinKhachHang ff)
        {
            InitializeComponent();
            f = ff;

            HinhAnhDao hadao = new HinhAnhDao();
            var model = hadao.LoadHinhTheoMaKH(MaKH);
            listhinhanh = model;
            this.MaKH = MaKH;
            soluong = listhinhanh.Count;
            if (model==null)
            {
                imagebox.Image = null;
                btnLuiLai.Enabled = false;
                btnXoa.Enabled = false;
                btnTieptheo.Enabled = false;
            }
            else
            {
                setbutton(soluong,vitri);
                if(soluong>1)
                {
                    MemoryStream ms = new MemoryStream(model[0].HinhAnh1);
                    imagebox.Image = Image.FromStream(ms);
                }
                else
                {
                    XtraMessageBox.Show("Không có gì để hiện thị!!");
                    btnXoa.Enabled = false;
                }
            }
            
        }
        private void setbutton(int soluong,int vitri)
        {
            if (soluong > 1)
            {
                if (vitri < 0)
                {
                    btnLuiLai.Enabled = false;
                    btnTieptheo.Enabled = true;
                }
                else
                {
                    if (vitri == 0)
                    {
                        btnLuiLai.Enabled = false;
                        btnTieptheo.Enabled = true;
                    }
                    else
                    {


                        if (vitri >= 0 && vitri < soluong - 1)
                        {
                            btnLuiLai.Enabled = true;
                            btnTieptheo.Enabled = true;
                        }
                        else
                        {
                            if (vitri >= 0 && vitri == soluong - 1)
                            {
                                btnLuiLai.Enabled = true;
                                btnTieptheo.Enabled = false;
                            }
                        }
                    }
                }



            }
            else
            {
                btnLuiLai.Enabled = false;
                btnTieptheo.Enabled = false;
            }
            
        }
        private void XemHinhAnh_Load(object sender, EventArgs e)
        {

        }

        //Lùi lại
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            vitri = vitri - 1;
            //soluong = soluong - 1;
            setbutton(soluong,vitri);
            MemoryStream ms = new MemoryStream(listhinhanh[vitri].HinhAnh1);
            imagebox.Image = Image.FromStream(ms);
            
        }

        //Button tiếp thep
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            vitri = vitri + 1;
            //soluong = soluong + 1;
            setbutton(soluong,vitri);
            MemoryStream ms = new MemoryStream(listhinhanh[vitri].HinhAnh1);
            imagebox.Image = Image.FromStream(ms);
            
        }


        //Xóa
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
            HinhAnhDao hd = new HinhAnhDao();
            hd.XoaAnh(listhinhanh[vitri].MaHA);
            if(vitri==soluong-1)
            {
                vitri = vitri - 1;
            }
            
            f.refresh();
            this.refresh();

        }
        public void refresh()
        {
            HinhAnhDao hinhAnh = new HinhAnhDao();
            var model = hinhAnh.LoadHinhTheoMaKH(this.MaKH);
            listhinhanh = model;
            soluong = listhinhanh.Count;
            if (model == null)
            {
                imagebox.Image = null;
                btnLuiLai.Enabled = false;
                btnXoa.Enabled = false;
                btnTieptheo.Enabled = false;
            }
            else
            {
                
                setbutton(soluong, vitri);
                MemoryStream ms = new MemoryStream(model[vitri].HinhAnh1);
                imagebox.Image = Image.FromStream(ms);
            }
        }
    }
}