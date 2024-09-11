using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace play game
{
    public partial class Form1 : Form
    {
    private object form1;

    public object Thread { get; private set; }

    public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
    {
        label1.BackColor = Color.Black;
        label1.Forecolor = Color.Black;
        Refresh
     

        label1.Forecolor = Color.Silver;
        Refresh 

         Form1.Backcolor = Color.Green;




    }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
    {
        label1.forecolor = Color.Black;
        label1.backcolor = Color.Black;
        button1.forecolor = Color.Transparent;





    }
    }
}
