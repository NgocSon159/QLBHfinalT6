using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBaoHiem.Models;
namespace QuanLyBaoHiem.DAO
{
    public class HinhAnhDao
    {
        QLBHContext db = new QLBHContext();
        public string getlasthinhanh()
        {
            var countRow = db.HinhAnhs.Count();
            int getCount = countRow + 1;
            string newMaHinhAnh = "HA";
            if (getCount < 10) newMaHinhAnh += "00" + getCount.ToString();
            else if (getCount < 100) newMaHinhAnh += "00" + getCount.ToString();
            return newMaHinhAnh;
        }
        public List<HinhAnh> LoadHinhTheoMaKH(string MaKH)
        {
            return db.HinhAnhs.Where(x => x.MaKH == MaKH&&x.Status==true).ToList();
        }
        public void XoaAnh(string MaHA)
        {
            var model = db.HinhAnhs.FirstOrDefault(x=>x.MaHA==MaHA);
            model.Status = false;
            db.SaveChanges();
        }
    }
}
