using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkNumber4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string proměnná;

        private void button1_Click(object sender, EventArgs e)
        {     
            if (string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Musíte si vybrat auto a obtížnost");
            }

            else

            {
                if (comboBox1.Text == "Logo DPE3" || comboBox1.Text == "Auto" || comboBox2.Text == "Těžká")
                {
                    MessageBox.Show("TBA");
                }
                else {
                    Hide();
                    if (comboBox2.Text == "Lehká")
                    {
                        if (comboBox1.Text == "Auto")
                        {
                            proměnná = "Auto";
                        }

                        if (comboBox1.Text == "Logo DPE3")
                        {
                            proměnná = "Logo";
                        }

                        if (comboBox1.Text == "Mašinka tomáš")
                        {
                            proměnná = "Mašinka";
                        }
                        Form2 secondForm = new Form2(proměnná);
                        secondForm.ShowDialog();
                    }
                    if (comboBox2.Text == "Normální")
                    {
                        if (comboBox1.Text == "Auto")
                        {
                            proměnná = "Auto";
                        }

                        if (comboBox1.Text == "Logo DPE3")
                        {
                            proměnná = "Logo";
                        }

                        if (comboBox1.Text == "Mašinka tomáš")
                        {
                            proměnná = "Mašinka";
                        }
                        Form3 thirdForm = new Form3(proměnná);
                        thirdForm.ShowDialog();
                    }
                    if (comboBox2.Text == "Těžká")
                    {
                        if (comboBox1.Text == "Auto")
                        {
                            proměnná = "Auto";
                        }

                        if (comboBox1.Text == "Logo DPE3")
                        {
                            proměnná = "Logo";
                        }

                        if (comboBox1.Text == "Mašinka tomáš")
                        {
                            proměnná = "Mašinka";
                        }
                        Form4 fourthForm = new Form4(proměnná);
                        fourthForm.ShowDialog();
                    }
                    Close();
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 2;
            comboBox2.SelectedIndex = 0;
        }
    }
}
