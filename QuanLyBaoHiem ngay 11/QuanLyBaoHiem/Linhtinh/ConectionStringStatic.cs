using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoHiem.Linhtinh
{
    public static class ConectionStringStatic
    {
        public static string local = @"data source=(local)\SQLEXPRESS;initial catalog=QuanLiBaoHiem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        public static string online = @"data source=27.75.236.201,1433;initial catalog=QuanLiBaoHiem;User ID=son;Password=123;MultipleActiveResultSets=True;App=EntityFramework";
    }
}
