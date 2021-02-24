using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 視窗應用程式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblShow.Text = " ";
        }

        //確定按鈕
        private void btmOk_Click(object sender, EventArgs e)
        {
            lblShow.Text = "Hello, " + txtName.Text;
            lblShow.BackColor = Color.Yellow;
        }

        //結束按鈕

        private void btmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();  //結束程式
        }
    }
}
