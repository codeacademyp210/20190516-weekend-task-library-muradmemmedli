using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using weekend_task.Models;

namespace weekend_task
{
    public partial class Form2 : Form
    {   

        public Form2()
        {
            InitializeComponent();
            Createbooks();
        }
        //private bool Createbooks()
        //{
        //    int affectedRows = 0;
        //    using (academyEntities db = new academyEntities())
        //    {
        //        Book book = new Book
        //        {
        //            Name = txtName.Text,
        //            Price = Convert.ToInt32(txtPrice.Text),
        //            Count = Convert.ToInt32(txtCount.Text),
                   

                 
        //        };
        //    }

        //    if (affectedRows > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        private void Createbooks()
        {
            using (academyEntities db = new academyEntities())
            {
                Book book = new Book
                {
                    Name = txtName.Text
                };
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Createbooks();
        }
    }
}
