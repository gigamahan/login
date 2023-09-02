using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db db1 = new db();   
            sing_up sing_Up = new sing_up();
            bool b = false;
            foreach (var item  in db1.sing_ups) 
            {
            if (item.user==textBox1.Text)
                {
                    MessageBox.Show("تکراری لطفا اسم دیگری پیدا کنید");
                    b = true;
                    break;   
                }

            }
            if (b==false)
            {
             if(textBox2.Text==textBox3.Text)
                
                {
                    sing_Up.user=textBox1.Text;
                    sing_Up.password=textBox2.Text;
                    db1.sing_ups.Add(sing_Up);
                    db1.SaveChanges();
                }
                else 
                {
                    MessageBox.Show("پسورد را چک کنید ");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();  
            form2.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
         Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog(); 
           
        }
    }
}
