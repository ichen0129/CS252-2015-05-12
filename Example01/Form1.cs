using GuyLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public partial class Form1 : Form
    {
        private Guy Joe;
        private Guy Bob;

        public Form1() //方法跟class名稱相同即為建構式
        {
            InitializeComponent();
            this.Joe = new Guy("Joe", 2000);
            MessageBox.Show(string.Format("現在有{0}個Guy", Guy.TotalGuys));

            //this.Bob = new Guy("Bob", 5000);
            this.Bob = Joe.Clone();

            MessageBox.Show(string.Format("現在有{0}個Guy", Guy.TotalGuys));
            this.UpdateLabels();
        }

        private void UpdateLabels()
        {
            this.nameLabel1.Text = this.Joe.Name;
            this.cashLabel1.Text = this.Joe.Cash.ToString();

            this.nameLabel2.Text = this.Bob.Name;
            this.cashLabel2.Text = this.Bob.Cash.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Bob.收錢(this.Joe.給錢(100));
            this.UpdateLabels();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Joe.收錢(this.Bob.給錢(250));
            this.UpdateLabels();
        }
    }
}