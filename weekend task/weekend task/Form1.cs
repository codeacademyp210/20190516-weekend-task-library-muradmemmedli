using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using weekend_task.Models;

namespace weekend_task
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            GenerateClients();
            GenerateBooks();
          
        }
        private void GenerateClients()
        {
            using (academyEntities db = new academyEntities())
            {
                clientDGV.AutoGenerateColumns = false;
                clientDGV.DataSource = db.Clients.ToList();
               

            }
        }
        private void GenerateBooks()
        {
            using (academyEntities db = new academyEntities())
            {
                booksDGV.AutoGenerateColumns = false;
                booksDGV.DataSource = db.Books.ToList();
            }
        }

        


        private void button1_Click(object sender, EventArgs e)
        {
          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
        //private void GenerateAuthor()
        //{
        //    using (academyEntities db = new academyEntities())
        //    {
        //        booksDGV.AutoGenerateColumns = false;
        //        booksDGV.DataSource = db.Authors.ToList();
        //    }
        //}

    }
}
