using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap3
{
    public partial class Form1 : Form
    {
        private int bd;
        private int kt;

        public Form1()
        {
            InitializeComponent();

        }

        private void txtbd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && (!Char.IsControl(e.KeyChar)))
                {
                e.Handled = true;
            }
        }

        private void txtkt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && (!Char.IsControl(e.KeyChar)))
                {
                e.Handled = true;
            }
        }

       

        public Boolean Rong()
        {
            if (txtbd.Text != "" && txtkt.Text != "")
            {
               
                return true;
            }
            else
                return false;
        }

      
        

        private void txtbd_MouseMove(object sender, MouseEventArgs e)
        {
            if (Rong() == true)
            {
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
            }
        }

        private void txtkt_MouseMove(object sender, MouseEventArgs e)
        {
            if (Rong() == true)
            {
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
            }
        }

      
        public void Khaibao() // Khai bao bien cuc bo
        {
            bd = int.Parse(txtbd.Text);
            kt = int.Parse(txtkt.Text);
        }

        private void btntong_Click(object sender, EventArgs e)
        {
        
            Khaibao();
            int Tong = 0;
            for(int i=bd;i<=kt;i++)
            {
                Tong = Tong + i;
            }
            txttong.Text = Tong.ToString();
        }

        private void btntich_Click(object sender, EventArgs e)
        {
            Khaibao();
            int Tich = 1;
            for (int i = bd; i <= kt; i++)
            {
                Tich = Tich * i;
            }
            txttich.Text = Tich.ToString();
        }

        private void btntongchan_Click(object sender, EventArgs e)
        {
            Khaibao();
            int Tongchan = 0;
            for (int i = bd; i <= kt; i++)
            {
                if(i%2==0)
                {
                    Tongchan = Tongchan + i;
                }
            }
            txttongchan.Text = Tongchan.ToString();
        }

        private void btntongle_Click(object sender, EventArgs e)
        {

            Khaibao();
            int Tongle = 0;
            for (int i = bd; i <= kt; i++)
            {
                if (i % 2 != 0)
                {
                    Tongle = Tongle + i;
                }
            }
            txttongle.Text = Tongle.ToString();
        }
    }
}
