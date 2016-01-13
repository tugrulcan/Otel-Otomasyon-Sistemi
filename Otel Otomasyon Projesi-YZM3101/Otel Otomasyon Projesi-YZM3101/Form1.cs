using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Otel_Otomasyon_Projesi_YZM3101
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmMusteriCheckin c = new frmMusteriCheckin();
            c.Show();
            this.Hide();
        }
    }
}
