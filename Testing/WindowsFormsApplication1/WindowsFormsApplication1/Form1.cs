using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsAppApi;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from = "56966411028";
            string to = txtTo.Text;
            string msg = txtMessage.Text;

            WhatsApp wa = new WhatsApp(from, "hXYN1vWci60z0Df6s7yautuO+Ks=", "rodrigo", false, false);
            
            wa.OnConnectSuccess += () =>
            {
                MessageBox.Show("Conectando a WhatsAppa");

                wa.OnLoginSuccess += (phoneNumber, data) =>
                {
                    wa.SendMessage(to, msg);
                    MessageBox.Show("Mensaje enviado");

                };

                wa.OnLoginFailed += (data) =>
                {
                    MessageBox.Show(string.Format("Fallo login : {0} ", data));
                };

                wa.Login();

            };

            wa.OnConnectFailed += (ex) =>
            {
                MessageBox.Show("Fallo la conexion");
            };

            wa.Connect();

            //WIhDFaZ/gB4kEv6fk/d9h7rlhJY=

        }
    }
}
