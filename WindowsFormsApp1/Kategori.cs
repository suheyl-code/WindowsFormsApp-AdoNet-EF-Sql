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
    public partial class Kategori : Form
    {
        private static String _connectionString = "Data Source=LENOVOTHINKBOOK\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=true";
        SqlConnection baglanti = new SqlConnection(_connectionString);

        public Kategori()
        {
            InitializeComponent();
        }

       
        private void Kategori_Load(object sender, EventArgs e)
        {
            UrunList();
        }

        private void UrunList()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Kategoriler", baglanti);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            datagridKategori.DataSource = dataTable;
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            string kategoriAdi = tbxKategoriAdi.Text;
            string tanimi = tbxTanimi.Text;
            

            if (kategoriAdi == "" || tanimi == "")
            {
                MessageBox.Show("Please fill all items");
            }
            else
            {
                SqlCommand komut = new SqlCommand();
                komut.CommandText = $"Insert Kategoriler(KategoriAdi,Tanimi) values('{kategoriAdi}','{tanimi}')";
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
                baglanti.Close();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(datagridKategori != null)
            {
                int id = Convert.ToInt32(datagridKategori.CurrentRow.Cells["KategoriID"].Value);
                SqlCommand cmd = new SqlCommand($"delete Kategoriler where KategoriID={id}", baglanti);
                baglanti.Open();
                int etki = cmd.ExecuteNonQuery();
                if (etki > 0)
                {
                    MessageBox.Show("Item Deleted!");
                    UrunList();
                }
                else
                {
                    MessageBox.Show("Error!");
                }
                baglanti.Close();
            }
        }
    }
}
