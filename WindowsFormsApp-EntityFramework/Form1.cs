using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_EntityFramework
{
    public partial class Form1 : Form
    {
        NorthwindEntities1 db = new NorthwindEntities1();

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
            dataGridView1.DataSource = db.Urunler.ToList();
            ColumnsPrivate(2, 3, 7, 8, 9, 10, 11, 12);

            var list = db.Urunler.Select(x => x.UrunAdi).ToList();
            comboBox1.DataSource = list;
        }

        private void ColumnsPrivate(params int[] series)
        {
            for (int i = 0; i < series.Length; i++)
            {
                int value = series[i];
                dataGridView1.Columns[value].Visible = false;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urunler urun = new Urunler();
            urun.UrunAdi = tbxUrunAdi.Text;
            urun.BirimFiyati = Convert.ToDecimal(tbxFiyat.Text);
            urun.HedefStokDuzeyi = Convert.ToInt16(tbxStok.Text);
            db.Urunler.Add(urun);
            int etki = db.SaveChanges();
            if(etki > 0)
            {
                MessageBox.Show("Product added!");
                UrunList();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUrunAdi.Tag = dataGridView1.CurrentRow.Cells["UrunID"].Value;
            tbxUrunAdi.Text = dataGridView1.CurrentRow.Cells["UrunAdi"].Value.ToString();
            tbxFiyat.Text = dataGridView1.CurrentRow.Cells["BirimFiyati"].Value.ToString();
            tbxStok.Text = dataGridView1.CurrentRow.Cells["HedefStokDuzeyi"].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxUrunAdi.Tag);
            var x = db.Urunler.Find(id);
            x.UrunAdi = tbxUrunAdi.Text;
            x.BirimFiyati = decimal.Parse(tbxFiyat.Text);
            x.HedefStokDuzeyi = short.Parse(tbxStok.Text);
            int etki = db.SaveChanges();
            if(etki > 0)
            {
                MessageBox.Show("Updated!");
                UrunList();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
