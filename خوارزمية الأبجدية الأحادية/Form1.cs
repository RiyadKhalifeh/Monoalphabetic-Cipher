using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace خوارزمية_الأبجدية_الأحادية
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCipher.Clear();
            textBoxDecipher.Clear();
            textBoxPlan.Clear();
            textBoxKey.Clear();
            buttonDecipher.Enabled = false;
        }
        string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
       // string alphabets = "أبتثجحخدذرزسشصضطظعغفقكلمنهوي";

        private void buttonCipher_Click(object sender, EventArgs e)
        {
            textBoxCipher.Clear();
            string PlanText = textBoxPlan.Text.ToUpper();
            string Key = textBoxKey.Text.ToUpper();
            bool repeated = false;


            if (textBoxPlan.Text == "" || textBoxKey.Text == "")
            {
                MessageBox.Show("بعض الحقول المطلوبة فارغة");
            }
            else
            {
                for (int i = 0; i < Key.Count(); i++)
                {
                    for (int j = i+1 ; j < Key.Count() ; j++)
                        if (Key[i] == Key[j])
                        {
                            repeated = true;
                            goto Next; 
                        }                        
                }
            Next:
                if (repeated == false)
                {
                    for (int i = 0; i < textBoxPlan.Text.Length; i++)
                    {
                        if (alphabets.Contains(PlanText[i]))
                        {
                            int indexPlan = alphabets.IndexOf(PlanText[i]);
                            textBoxCipher.Text += Key[indexPlan];
                        }
                        else
                            textBoxCipher.Text += PlanText[i];

                    }
                    buttonDecipher.Enabled = true;
                }
                else
                    MessageBox.Show("هناك حرف مكرر");
            }
        }

        private void buttonDecipher_Click(object sender, EventArgs e)
        {
            textBoxDecipher.Clear();
            string CipherText = textBoxCipher.Text.ToUpper();
            string Key = textBoxKey.Text.ToUpper();

            if (textBoxCipher.Text == "" || textBoxKey.Text == "")
            {
                MessageBox.Show("بعض الحقول المطلوبة فارغة");
            }
            else
            {
                for (int i = 0; i < textBoxCipher.Text.Length; i++)
                {
                    if (alphabets.Contains(CipherText[i]))
                    {
                        int indexCipher = Key.IndexOf(CipherText[i]);
                        textBoxDecipher.Text += alphabets[indexCipher];
                    }
                    else
                        textBoxDecipher.Text += CipherText[i];

                }
            }
        }

        private void textBoxKey_TextChanged(object sender, EventArgs e)
        {
            this.textBoxKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckKeys);
        }

        private void CheckKeys(object sender, KeyPressEventArgs e)
        {
            string key=textBoxKey.Text;
            if (key.Contains(e.KeyChar))
            {
                e.Handled = true;                
            }
        }

    }
}
