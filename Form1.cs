using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzacı_Sipariş_Ekranı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hazır_Pizzalar_ve_Ekstralar form = new Hazır_Pizzalar_ve_Ekstralar();
            form.ShowDialog();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hazır_Pizzalar_ve_Ekstralar form = new Hazır_Pizzalar_ve_Ekstralar();
            form.ShowDialog();
            this.Hide();
        }

        private void btnsiparis_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text+"'nin"+" "+"siparişi hazırlanıyor...");
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(comboBox2.Text+" "+"+"+ " " + comboBox3.Text + " " + "+" + " " + comboBox4.Text);
            listBox5.Items.Add(comboBox1.Text + " " + "+" + " " + label32.Text+ " "+label33.Text + " " +label34.Text + " " +label35.Text + " " +label36.Text + " " +label37.Text + " " +label38.Text + " " +label39.Text + " " +label40.Text + " " +label41.Text + " " +label42.Text + " " +label43.Text + " " +label44.Text + " " +label45.Text + " " +label46.Text + " " +label47.Text + " " +label48.Text + " " +label49.Text + " " +label50.Text + " " +label51.Text);
            
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
                label32.Text = checkBox1.Text;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            label33.Text = checkBox12.Text;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label34.Text = checkBox2.Text;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label35.Text = checkBox3.Text;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label36.Text = checkBox4.Text;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            label37.Text = checkBox6.Text;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            label38.Text = checkBox8.Text;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            label39.Text = checkBox9.Text;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            label40.Text = checkBox10.Text;
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            label41.Text = checkBox14.Text;
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            label42.Text = checkBox24.Text;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            label43.Text = checkBox13.Text;
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            label44.Text = checkBox23.Text;
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            label45.Text = checkBox22.Text;
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            label46.Text = checkBox21.Text;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            label47.Text = checkBox5.Text;
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            label48.Text = checkBox18.Text;
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            label49.Text = checkBox16.Text;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            label50.Text = checkBox11.Text;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            label51.Text = checkBox7.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text=" ";
            comboBox2.Text = " ";
            comboBox3.Text = " ";
            comboBox4.Text = " ";
            label32.Text = " ";
            label33.Text = " ";
            label34.Text = " ";
            label35.Text = " ";
            label36.Text = " ";
            label37.Text = " ";
            label38.Text = " ";
            label39.Text = " ";
            label40.Text = " ";
            label41.Text = " ";
            label42.Text = " ";
            label43.Text = " ";
            label44.Text = " ";
            label45.Text = " ";
            label46.Text = " ";
            label47.Text = " ";
            label48.Text = " ";
            label49.Text = " ";
            label50.Text = " ";
            label51.Text = " ";
            checkBox1.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox16.Checked = false;
            checkBox18.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox13.Checked = false;
            checkBox21.Checked = false;
            checkBox22.Checked = false;
            checkBox23.Checked = false;
            checkBox24.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
        }
        private int checkedCount = 0;
        private void CheckBox(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox.Checked)
            {
                if (checkedCount >= 8)
                {
                    checkBox.Checked = false;
                    MessageBox.Show("Maksimum 8 malzeme seçebilirsin!");
                }
                else
                {
                    checkedCount++;
                }
            }
            else
            {
                checkedCount--;
            }
        }
    }
}
