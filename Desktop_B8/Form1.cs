using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_B8
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            //Thiết lập cho Connection
            SqlConnection conn = new SqlConnection(@"Data Source=MSI\MS_SQLSERVER;Initial Catalog=QLNhaSach;Persist Security Info=True;User ID=sa;Password=trandat05102003");
            conn.Open();

            //Thiết lập cho Adapter
            SqlDataAdapter da = new SqlDataAdapter("Select * from SanPham", conn);

            //Đỗ dữ liệu vào DataSet
            DataSet ds = new DataSet();
            da.Fill(ds);

            //Thiết lập Crytal Reports
            CrystalReport1 report = new CrystalReport1();
            report.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = report;

            dataGridView1.DataSource = ds.Tables[0];

            conn.Close();

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public IEnumerable<int> BP(int[] a, int n)
        {
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                yield return b[i] = a[i] * 2;
            }
        }
    }
}
