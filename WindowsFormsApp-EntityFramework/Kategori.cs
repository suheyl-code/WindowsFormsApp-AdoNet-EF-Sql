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
    public partial class Kategori : Form
    {
        NorthwindEntities1 db = new NorthwindEntities1();

        public Kategori()
        {
            InitializeComponent();
        }

        private void Kategori_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Kategoriler.ToList();
        }
    }
}
