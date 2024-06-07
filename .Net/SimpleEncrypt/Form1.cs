using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace com.mercantilbanco.api.sample
{
    public partial class Form1 : Form
    {
        private Util util = new Util();

        public Form1()
        {
            InitializeComponent();
        }       

        private void Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;

            FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);

            sw.Write(cvv.Text);

            sw.Close();
            fs.Close();
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            if (secretkey.Text == "")
            {
                MessageBox.Show("Ingrese la clave de cifrado");
                return;
            }
            if (cvv.Text != "")
                cvv.Text = util.Encrypt(secretkey.Text, cvv.Text);
            if (twofactor_auth.Text != "")
                twofactor_auth.Text = util.Encrypt(secretkey.Text, twofactor_auth.Text);
            if (twofactor_type.Text != "")
                twofactor_type.Text = util.Encrypt(secretkey.Text,twofactor_type.Text);           
        }
        private void Decrypt_Click(object sender, EventArgs e)
        {
            if (secretkey.Text == "")
            {
                MessageBox.Show("Ingrese la clave de cifrado");
                return;
            }
            if (cvv.Text != "")
                cvv.Text = util.Decrypt(secretkey.Text, cvv.Text);
            if (twofactor_auth.Text != "")
                twofactor_auth.Text = util.Decrypt(secretkey.Text, twofactor_auth.Text);
            if (twofactor_type.Text != "")
                twofactor_type.Text = util.Decrypt(secretkey.Text, twofactor_type.Text);
        }
    }
}
