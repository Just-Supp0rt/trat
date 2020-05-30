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
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Musíte si vybrat auto");
            }
            else if (string.IsNullOrEmpty(textBox1.Text))
            {
                if (comboBox1.Text == "LOGO DPE3" || comboBox1.Text == "Auto")
                {
                    MessageBox.Show("TBA");
                }

                else {
                    Hide();
                    if (comboBox1.Text == "Auto")
                    {
                        proměnná = "Auto";
                    }

                    if (comboBox1.Text == "LOGO DPE3")
                    {
                        proměnná = "Logo";
                    }

                    if (comboBox1.Text == "Mašinka tomáš")
                    {
                        proměnná = "Mašinka";
                    }
                    Form2 secondForm = new Form2(proměnná);


                    secondForm.ShowDialog();
                    Close();
                }
            }
            else
            {
                if (comboBox1.Text == "LOGO DPE3" || comboBox1.Text == "Auto")
                {
                    MessageBox.Show("TBA");
                }

                else
                {
                    
                    if (textBox1.Text == "svíčka") // level 3
                    {
                        Hide();
                        if (comboBox1.Text == "Auto")
                        {
                            proměnná = "Auto";
                        }
                        if (comboBox1.Text == "LOGO DPE3")
                        {
                            proměnná = "LOGO DPE3";
                        }
                        if (comboBox1.Text == "Mašinka tomáš")
                        {
                            proměnná = "Mašinka";
                        }
                        Form3 thirdForm = new Form3(proměnná);
                        thirdForm.ShowDialog();
                        Close();
                    }
                    if (textBox1.Text == "Civ") // level 4
                    {
                        Hide();
                        if (comboBox1.Text == "Auto")
                        {
                            proměnná = "Auto";
                        }
                        if (comboBox1.Text == "LOGO DPE3")
                        {
                            proměnná = "LOGO DPE3";
                        }
                        if (comboBox1.Text == "Mašinka tomáš")
                        {
                            proměnná = "Mašinka";
                        }
                        Form4 FourthForm = new Form4(proměnná);
                        FourthForm.ShowDialog();
                        Close();
                    }
                    if (!string.IsNullOrEmpty(textBox1.Text))
                    {
                        MessageBox.Show("Špatný kód");
                    }
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 2;
        }
    }
}
