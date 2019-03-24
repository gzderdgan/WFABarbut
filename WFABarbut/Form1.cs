using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFABarbut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int sure = 10;
        int sure2 = 10;
        int x, y;
        int s,t;

        private void btn1_Click(object sender, EventArgs e)
        {
            tmr2.Start();
           
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tmr1.Start();
        }

        private void tmr2_Tick(object sender, EventArgs e)
        {
           sure--;
            x = rnd.Next(1, 7);
            String bir = x + ".png";
            pb1.Image = Image.FromFile(bir);

            t = Convert.ToInt32(label1.Text);

            if (sure == 0)
            {
                int sonuc = x + t;
                label1.Text = sonuc.ToString();
                tmr2.Stop();
                sure = 10;
                btn1.Enabled = false;
                btn2.Enabled = true;


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            sure2--;
            y = rnd.Next(1, 7);
            String bir = y + ".png";
            pb2.Image = Image.FromFile(bir);

           
            if (sure2 == 0)
            {
                int sonuc = s + y;
                label2.Text = sonuc.ToString();
                tmr1.Stop();
                sure2 = 10;
                btn1.Enabled = true;
                btn2.Enabled = false;

          }
            s = Convert.ToInt32(label2.Text);
            
            if (x > y)
                lblSonuc.Text = "Biirinci kazandı";
            else if (x == y)
            {
                lblSonuc.Text = "Berabere";
            }
            else
                lblSonuc.Text = "İkinci kazandı";

        }
    }
}
