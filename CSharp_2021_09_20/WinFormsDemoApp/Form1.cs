using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsDemoApp
{
    public partial class Form1 : Form
    {
        //Für Programmierer
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menü Eintrag wurde geklickt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = "Otto Walkes ist lustig";

            //using (HttpClient client = new HttpClient())
            //{
            //    Task task =  client.GetAsync("https:localhost:5001/PersonService");
            //    task.Wait();
            //} // HttpClient wird hier bereinigt 
        }
    }
}
