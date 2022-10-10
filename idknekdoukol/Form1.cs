using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace idknekdoukol
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        public Form1()
        {
            form2 = new Form2(this);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count >= 10)
            {
                MessageBox.Show("10 prvků"); 
                return;//to return tě vyhodí z té funkce. stane se to a už tě to tam nepustí
            }
            else
            {
                form2.Show();
                form2.Focus();
            }
            
            
        }
        public void addItem(String txt)
        {
            listBox1.Items.Add(txt);
        }
    }
}
