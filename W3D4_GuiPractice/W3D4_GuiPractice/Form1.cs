using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W3D4_GuiPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetComboBoxWithColor();     
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {
            
            int i = 0;
            foreach (var item in txtText.Text.ToString())
            {
                i++;
            }
            label1.Text = "Aktualny pocet znakov v textfielde :" + i.ToString();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = (RadioButton)sender;
            txtText.Font = new Font(radioButton.Tag.ToString(), Font.Size);
        }
        private void txtFontSize_TextChanged(object sender, EventArgs e)
        {
            {
                if (float.TryParse(txtFontSize.Text, out float sizeToChange))
                {
                    if (sizeToChange > 1)
                    {
                        txtText.Font = new Font(Font.Name, sizeToChange);
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtText.ForeColor = Color.FromName(comboBox1.Text);
        }
        private void SetComboBoxWithColor()
        {
            List<string> colors = new List<string> 
            {
                "Black",
                "Red",
                "DarkRed",
                "Green",
                "Lime",
                "Salmon",
                "Coral",
                "RoyalBlue",
                "NavyBlue",
                "Blue",
                "Gold",
                "Crimson",
                "Pink",
                "Magenta",
            };
            foreach (var item in colors)
            {
                comboBox1.Items.Add(item.ToString());
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtText.ReadOnly = true;
            }
            else
            {
                txtText.ReadOnly = false;
            }
        }
    }
}
