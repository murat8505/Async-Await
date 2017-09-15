using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Async_Await
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var b = sender as Button;

            b.Enabled = false;

            var calc = await Calc();

            Text = calc.ToString();


            b.Enabled = true;

        }

        int n = 0;

        async Task<int> Calc()
        {
            return await Task.Factory.StartNew(() =>
            {
                Task.Delay(1000).Wait();

                return n++;
            });
        }


        
    }
}
