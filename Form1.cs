using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vigenere_Cipher_11
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textKey_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textMessege_TextChanged(object sender, EventArgs e)
        {
           
        }
            

        private void textKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                
            }
        }

        private void textMessege_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textEncryption_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
