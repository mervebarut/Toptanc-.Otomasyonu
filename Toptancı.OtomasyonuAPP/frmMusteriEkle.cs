using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toptancı.OtomasyonuAPP
{
    public partial class frmMusteriEkle : Form
    {
        public frmMusteriEkle()
        {
            InitializeComponent();
        }
        SqlConnection cn = null;
        internal string txtAdText;

      
        //Katmanlı Mimari
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                MusteriBL obl = new MusteriBL();
                Musteri ogr = new Musteri();
                ogr.Ad = txtAd.Text.Trim();
                ogr.Soyad = txtSoyad.Text.Trim();
                ogr.Telefon = int.Parse(txtTel.Text.Trim());
                MessageBox.Show(obl.Kaydet(ogr) ? "Başarılı" : "Başarısız");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 245:
                        MessageBox.Show("Numara alanına sadece rakam giriniz");
                        break;
                    default:
                        MessageBox.Show("Veritabanı Hatası" + ex.Number);
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Numara alanına sadece rakam giriniz");
            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen Hata!!");
            }
        }

        private void BtnBul_Click(object sender, EventArgs e)
        {
            frmMusteriBul frm = new frmMusteriBul(this);
            frm.Show();
        }
    }
}
