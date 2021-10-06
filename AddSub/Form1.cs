using Delegates_And_Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddSub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            MyADD MdgAdd = new MyADD(Calculations.add);
            ResulttextBox.Text = MdgAdd(int.Parse(Num1TextBox.Text),int.Parse(Num2textBox.Text)).ToString();
        }

        private void Subbutton_Click(object sender, EventArgs e)
        {
            MyADD MdgAdd = new MyADD(Calculations.Sub);
            ResulttextBox.Text = MdgAdd(int.Parse(Num1TextBox.Text), int.Parse(Num2textBox.Text)).ToString();
        }
    }
}
