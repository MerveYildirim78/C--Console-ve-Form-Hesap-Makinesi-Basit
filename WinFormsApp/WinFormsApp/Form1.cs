using Calculater1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        bool optDurum = false;
        double sonuc = 0;
        string opt = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void RakamEvent(object sender, EventArgs e)
        {
            if (textResult.Text == "0"||optDurum)
                textResult.Clear();
            optDurum = false;

            Button btn = (Button)sender;
            textResult.Text += btn.Text;

        }

        private void OperatorEvent(object sender, EventArgs e)
        {
            optDurum = true;
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;

            labelResult.Text = labelResult.Text + " " + textResult.Text + " " + yeniOpt;
            switch (opt)
            {
                case "+": textResult.Text = (sonuc + Double.Parse(textResult.Text)).ToString(); break;
                case "-": textResult.Text = (sonuc - Double.Parse(textResult.Text)).ToString(); break;
                case "/": textResult.Text = (sonuc / Double.Parse(textResult.Text)).ToString(); break;
                case "x": textResult.Text = (sonuc * Double.Parse(textResult.Text)).ToString(); break;
            }
            sonuc = double.Parse(textResult.Text);
            textResult.Text = sonuc.ToString();
            opt = yeniOpt;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textResult.Text = "0";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textResult.Text = "0";
            labelResult.Text = "";
            opt = "";
            sonuc = 0;
            optDurum = false;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            labelResult.Text = "";
            optDurum = true;

            switch (opt)
            {
                case "+": textResult.Text = (sonuc + Double.Parse(textResult.Text)).ToString(); break;
                case "-": textResult.Text = (sonuc - Double.Parse(textResult.Text)).ToString(); break;
                case "/": textResult.Text = (sonuc / Double.Parse(textResult.Text)).ToString(); break;
                case "x": textResult.Text = (sonuc * Double.Parse(textResult.Text)).ToString(); break;
            }
            sonuc = double.Parse(textResult.Text);
            textResult.Text = sonuc.ToString();
            opt = "";

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (this.BackColor ==Color.Pink)
            {
                this.BackColor = Color.White;
            }
            else
                this.BackColor = Color.Pink;
        }
    }
}
