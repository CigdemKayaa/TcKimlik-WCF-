using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TcKimlik.ServiceKimlik;

namespace TcKimlik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            KPSPublicSoapClient servis = new KPSPublicSoapClient();
           
            bool deger =  servis.TCKimlikNoDogrula(Convert.ToInt64(txtTc.Text), txtAd.Text.ToUpper(), txtSoyad.Text.ToUpper(), Convert.ToInt32(txtYil.Text));
            if (deger==true)
            {
                MessageBox.Show("Dogru Kimlik");
            }
            else
            {
                MessageBox.Show("Yanlış Kimlik");
            }
        }
    }
}
