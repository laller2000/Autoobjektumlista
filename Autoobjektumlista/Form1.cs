using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoobjektumlista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRogzit_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox_rendszam.Text.Trim()))
            {
                MessageBox.Show("Nem töltötted ki a rendszam mező!", "Hiba",MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBox_rendszam.Focus();
            }
             if(String.IsNullOrEmpty(textBox_teljesitmeny.Text.Trim()))
            {
                MessageBox.Show("Nem töltötted ki a teéjesitmeny mezőt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_teljesitmeny.Focus();
            }
             if(String.IsNullOrEmpty(textBox_tipus.Text.Trim()))
            {
                MessageBox.Show("Nem töltötted ki a tipus mezőt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_tipus.Focus();
            }
            if (checkBox_Magyar.Checked==false && checkBox_Angol.Checked==false && checkBox_Nemet.Checked==false && checkBox_Kulfoldi.Checked==false)
            {
                MessageBox.Show("Nem jelölte be egyet gyártmányt", "hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Auto auto = new Auto(textBox_rendszam.Text.Trim(), textBox_tipus.Text.Trim(), checkBox_Magyar.Checked, checkBox_Nemet.Checked, checkBox_Angol.Checked, checkBox_Kulfoldi.Checked, int.Parse(textBox_teljesitmeny.Text.Trim()));
            listBox_Autoadatok.Items.Add(auto);
        }

        private void listBox_Autoadatok_SelectedIndexChanged(object sender, EventArgs e)
        {
            Auto auto = (Auto)listBox_Autoadatok.Items[listBox_Autoadatok.SelectedIndex];
            textBox_rendszam.Text = auto.Rendszam;
            textBox_tipus.Text = auto.Tipus;
            checkBox_Magyar.Checked = auto.Magyar;
            checkBox_Nemet.Checked = auto.Nemet;
            checkBox_Angol.Checked = auto.Angol;
            checkBox_Kulfoldi.Checked = auto.Kulfoldi;
            textBox_teljesitmeny.Text = auto.Teljesitmeny.ToString();
        }
    }
}
