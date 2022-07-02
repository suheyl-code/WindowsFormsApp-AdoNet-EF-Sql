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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private static String _connectionString = "Data Source=LENOVOTHINKBOOK\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=true";
        SqlConnection baglanti = new SqlConnection(_connectionString);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UrunList();
        }

        private void UrunList()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Urunler", baglanti);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string urunAdi = txtUrunAdi.Text;
            decimal fiyat = numericFiyat.Value;
            decimal stok = numericStok.Value;

            if (urunAdi == "" || fiyat == default || stok == default)
            {
                MessageBox.Show("Please fill all items");
            }
            else
            {
                SqlCommand komut = new SqlCommand();
                komut.CommandText = $"Insert Urunler(UrunAdi,BirimFiyati,HedefStokDuzeyi) values('{urunAdi}',{fiyat},{stok})";
                komut.Connection = baglanti;
                baglanti.Open();
                int etki = komut.ExecuteNonQuery();
                if (etki > 0)
                {
                    MessageBox.Show("Added!");
                    UrunList();
                }
                else
                {
                    MessageBox.Show("Error!");
                }

            }
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori();
            kategori.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunAdi.Tag = dataGridView1.CurrentRow.Cells["UrunID"].Value;
            txtUrunAdi.Text = dataGridView1.CurrentRow.Cells["UrunAdi"].Value.ToString();
            numericFiyat.Value = (decimal)dataGridView1.CurrentRow.Cells["BirimFiyati"].Value;
            numericStok.Value = Convert.ToInt16(dataGridView1.CurrentRow.Cells["HedefStokDuzeyi"].Value);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = $"update Urunler set UrunAdi = '{txtUrunAdi.Text}', BirimFiyati = {numericFiyat.Value}, HedefStokDuzeyi = {numericStok.Value} where UrunID = {txtUrunAdi.Tag}";
            komut.Connection = baglanti;
            baglanti.Open();
            int etki = komut.ExecuteNonQuery();
            if(etki > 0)
            {
                MessageBox.Show("Item Updated!");
                UrunList();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
