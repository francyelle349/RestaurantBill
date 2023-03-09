using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Despesas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTotalDaConta.Text = (Convert.ToDouble(txtDespesa.Text) *1.10).ToString("N");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
