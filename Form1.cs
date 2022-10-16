using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap
{
    public partial class Form1 : Form
    {
        private char _islem;
        bool _silenecekMi;
        double _ilkSayi;
        bool _virgul;


        public Form1()
        {
            InitializeComponent();
        }

        private void rakam1_Click(object sender, EventArgs e)
        {
            if (_silenecekMi)
            {
                label1.Text = "";
                _silenecekMi = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "1";
        }

        private void rakam2_Click(object sender, EventArgs e)
        {
            if (_silenecekMi)
            {
                label1.Text = "";
                _silenecekMi = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "2";
        }
        private void rakam3_Click(object sender, EventArgs e)
        {
            if (_silenecekMi)
            {
                label1.Text = "";
                _silenecekMi = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "3";

        }

        private void rakam4_Click(object sender, EventArgs e)
        {
            if (_silenecekMi)
            {
                label1.Text = "";
                _silenecekMi = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "4";

        }

        private void rakam5_Click(object sender, EventArgs e)
        {
            if (_silenecekMi)
            {
                label1.Text = "";
                _silenecekMi = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "5";


        }

        private void rakam6_Click(object sender, EventArgs e)
        {
            if (_silenecekMi)
            {
                label1.Text = "";
                _silenecekMi = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "6";

        }

        private void rakam7_Click(object sender, EventArgs e)
        {
            if (_silenecekMi)
            {
                label1.Text = "";
                _silenecekMi = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "7";

        }

        private void rakam8_Click(object sender, EventArgs e)
        {
            if (_silenecekMi)
            {
                label1.Text = "";
                _silenecekMi = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "8";

        }

        private void rakam9_Click(object sender, EventArgs e)
        {
            if (_silenecekMi)
            {
                label1.Text = "";
                _silenecekMi = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "9";

        }

        private void rakam0_Click(object sender, EventArgs e)
        {
            if (_silenecekMi)
            {
                label1.Text = "";
                _silenecekMi = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "0";

        }

        private void artibuton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _silenecekMi = true;
            _ilkSayi = Convert.ToDouble(label1.Text);
        }

        private void esitbuton_Click(object sender, EventArgs e)
        {
            double ikinciSayi = Convert.ToDouble(label1.Text);
            double sonuc;
            
            switch (_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilkSayi / ikinciSayi;
                    break;
                default:
                    sonuc = 0;
                    break;
                    
            }
            label1.Text = Convert.ToString(sonuc);
        }

        private void ACbutton_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }


        private void bolmebuton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _silenecekMi = true;
            _ilkSayi = Convert.ToDouble(label1.Text);
        }

        private void carpmabuton_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _silenecekMi = true;
            _ilkSayi = Convert.ToDouble(label1.Text);
        }

        private void eksibuton_Click(object sender, EventArgs e)
        {

            _islem = '-';
            _silenecekMi = true;
            _ilkSayi = Convert.ToDouble(label1.Text);
        }

        private void virgulbuton_Click(object sender, EventArgs e)
        {
            if (!_virgul)
            {
                label1.Text += ".";
                _virgul = true;
            }
        }

        private void arti_eksi_button_Click(object sender, EventArgs e)
        {

            double sayi = Convert.ToDouble(label1.Text);
            sayi = sayi * -1;
            label1.Text = Convert.ToString(sayi);
        }

        private void yuzdebuton_Click(object sender, EventArgs e)
        {

            double sayi = Convert.ToDouble(label1.Text);
            sayi = sayi / 100;
            label1.Text = Convert.ToString(sayi);
        }
    }

    
}