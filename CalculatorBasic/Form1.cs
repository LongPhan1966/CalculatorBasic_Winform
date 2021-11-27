using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            float a, b, kq;

            a = float.Parse(txta.Text);
            b = float.Parse(txtb.Text);

            kq = a + b;

            txtkq.Text = kq.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            float a, b, kq;

            a = float.Parse(txta.Text);
            b = float.Parse(txtb.Text);

            kq = a - b;

            txtkq.Text = kq.ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            float a, b, kq;

            a = float.Parse(txta.Text);
            b = float.Parse(txtb.Text);

            kq = a * b;

            txtkq.Text = kq.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            float a, b, kq;

            a = float.Parse(txta.Text);
            b = float.Parse(txtb.Text);

            kq = a / b;

            txtkq.Text = kq.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txta.Text = "";
            txtb.Text = "";
            txtkq.Text = "";
        }
    }
}
