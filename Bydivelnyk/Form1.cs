using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bydivelnyk
{
    public partial class Form1 : Form
    {
        List<Auto> AutoPark = new List<Auto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AutoPark.Add(new Auto1());
            comboBox1.Items.Add("BMW");   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AutoPark.Add(new Auto2());
            comboBox1.Items.Add("WMB");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AutoPark.Add(new Auto3());
            comboBox1.Items.Add("MWB");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex >= 0)
            AutoPark.Add(AutoPark[comboBox1.SelectedIndex].Clone());
            comboBox1.Items.Add(comboBox1.Items[comboBox1.SelectedIndex].ToString()+ "Clone");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                AutoPark[comboBox1.SelectedIndex].set_radio(textBox1.Text);
            }
            if (textBox2.Text != "")
            {
                AutoPark[comboBox1.SelectedIndex].set_tone(Convert.ToInt32(textBox2.Text));
            }
            if (textBox3.Text != "")
            {
                AutoPark[comboBox1.SelectedIndex].set_capacity(Convert.ToDouble(textBox3.Text));
            }
            if (textBox4.Text != "")
            {
                AutoPark[comboBox1.SelectedIndex].set_engine(textBox4.Text);
            }
            if (comboBox1.SelectedIndex >= 0)
                label1.Text = AutoPark[comboBox1.SelectedIndex].Info();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex >= 0)
            label1.Text = AutoPark[comboBox1.SelectedIndex].Info();
        }
    }
}
