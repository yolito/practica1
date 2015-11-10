using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace git
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Thread t = new Thread();

        }

        private void button1_Click(object sender, EventArgs e)
        {
    
            System.Windows.Forms.Button[] Buttons = new System.Windows.Forms.Button[10];

            for (int i = 0; i < 10; ++i)
            {
                Buttons[i] = new Button();
                Buttons[i].Text = "?";
                Buttons[i].BackColor = Color.Yellow;
                Buttons[i].Location = new System.Drawing.Point(i*100 + 100,100);
                this.Controls.Add(Buttons[i]); 
                MessageBox.Show("Hola github");
                MessageBox.Show("Estoy en internet :D");
            }

           
        }
    }
}
