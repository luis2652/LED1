using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduinouno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Open();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] aBuffer = Encoding.ASCII.GetBytes("LED_ENCENDIDO");
            serialPort1.Write(aBuffer, 0, aBuffer.Length);
            MessageBox.Show("LED ENCENDIDO");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] aBuffer = Encoding.ASCII.GetBytes("LED_APAGADO");
            serialPort1.Write(aBuffer, 0, aBuffer.Length);
            MessageBox.Show("LED APAGADO");
        }
    }
}
