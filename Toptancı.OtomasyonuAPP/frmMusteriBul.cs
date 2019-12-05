using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toptancı.OtomasyonuAPP
{
    public partial class frmMusteriBul : Form
    {
        SqlConnection cn;
        frmMusteriEkle frm;

        public frmMusteriBul()
        {
            InitializeComponent();
        }
        private void BtnAra_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=.;Initial Catalog=ToptanciVT;Integrated Security=true");
            SqlCommand cmd = new SqlCommand("Select MusteriId,TC NO,Ad,Soyad,Telefon,Sifre,Eposta,Adres from " +
                "MUSTERILER where TC NO=@TCNO", cn);
            SqlParameter[] p = { new SqlParameter("@TCNO", txtTcNo.Text.Trim()) };
            cmd.Parameters.AddRange(p);
            OpenConnection();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                frm.txtAd.Text = dr["Ad"].ToString();
                frm.txtSoyad.Text = dr["Soyad"].ToString();
                frm.txtTel.Text = dr["Telefon"].ToString();

                frmMusteriEkle frm1 = (frmMusteriEkle)Application.OpenForms["Form1"];

            }
            else
            {
                MessageBox.Show("Müşteri Bulunamadı!!");
            }

            dr.Close();
            CloseConnection();


        }


        public void OpenConnection()
        {
            try
            {
                if (cn != null && cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (cn != null && cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
