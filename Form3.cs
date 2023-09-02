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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
            
        }
        public db db1= new db();
        private void button1_Click(object sender, EventArgs e)
        { 
            bool b = false;  
         foreach(var item in db1.sing_ups) 
         {
             if(item.user==textBox1.Text)
             {
                 if (item.password==textBox2.Text)
                 {
                     Form_admin form_Admin = new Form_admin();  
                        form_Admin.Show();
                        this.Close();
                 }
             }
             else
             {
               MessageBox.Show("wrong password");
             }
             b = true;
         }
         if (b) 
         {
           MessageBox.Show("موفقیت وارد شد");
         }
            else
            {
                MessageBox.Show("همچین یوزری پیدا نشد لطفا چک کنید");
            }

         
        
            
        }
    }
}
