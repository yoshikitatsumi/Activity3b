using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity3b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var total = Convert.ToInt32(Money.Text);

            Hundredth.Text = total / 100 + "";
            var remain = Convert.ToInt32(Hundredth.Text) * 100;
            total = total - remain;
            Fiftieth.Text = total / 50 + "";
            remain = Convert.ToInt32(Fiftieth.Text) * 50;
            total = total - remain;
            Twentieth.Text = total / 20 + "";
            remain = Convert.ToInt32(Twentieth.Text) * 20;
            total = total - remain;
            Tenth.Text = total / 10 + "";
            remain = Convert.ToInt32(Tenth.Text) * 10;
            total = total - remain;
            Fifth.Text = total / 5 + "";
            remain = Convert.ToInt32(Fifth.Text) * 5;
            total = total - remain;
            Seconds.Text = total / 2 + "";
            remain = Convert.ToInt32(Seconds.Text) * 2;
            total = total - remain;
            First.Text = total + "";





        }
    }
}
