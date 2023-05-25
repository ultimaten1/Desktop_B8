using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_B8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            QLNhaSachEntities3 db = new QLNhaSachEntities3();
            var listSP = db.SanPhams;
            dataGridView1.DataSource = listSP;
            
        }
    }
}
