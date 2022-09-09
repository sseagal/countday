using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime first = datefrom.Value.Date;
            var fdate = first.ToShortDateString();
            DateTime second = dateto.Value.Date;
            var sdate = second.ToShortDateString();
            var result = first.Date - second.Date;
            var days = result.Days;
            count.Text = Convert.ToString(Math.Abs(days));

        }
    }
}
