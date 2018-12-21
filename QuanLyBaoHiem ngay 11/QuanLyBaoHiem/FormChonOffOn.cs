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
using System.Configuration;
using QuanLyBaoHiem.Linhtinh;

namespace QuanLyBaoHiem
{
    public partial class FormChonOffOn : DevExpress.XtraEditors.XtraForm
    {
        public FormChonOffOn()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(radioGroup1.SelectedIndex==0)
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connectionStringsSection.ConnectionStrings["QLBHContext"].ConnectionString = ConectionStringStatic.online;
                config.Save();
                ConfigurationManager.RefreshSection("connectionStrings");
                frmLogin f = new frmLogin();
                this.Hide();
                f.Show();
            }
            else
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connectionStringsSection.ConnectionStrings["QLBHContext"].ConnectionString = ConectionStringStatic.local;
                config.Save();

                ConfigurationManager.RefreshSection("connectionStrings");
                //frmLogin f = new frmLogin();
                this.Hide();
                //f.Show();


                frmMain f = new frmMain("offline","abc","x");
                f.Show();

            }
            
        }
    }
}