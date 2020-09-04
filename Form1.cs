using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add_Edit_Delete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyDetails me = new MyDetails();
            using (MyDetailsDBContext db = new MyDetailsDBContext())
            {
                me.Fname = txtfname.Text;
                me.Lname = txtlname.Text;
                me.Age = int.Parse(txtage.Text);

                db.Add<MyDetails>(me);
                db.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyDetails my = new MyDetails();
            using (MyDetailsDBContext db = new MyDetailsDBContext())
            {
                my.Fname = txtfdel.Text;
                var x = db.MyDetails.Where(x => x.Fname == my.Fname).FirstOrDefault();
                db.Remove<MyDetails>(x);
                db.SaveChanges();            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyDetails my = new MyDetails();
            using(MyDetailsDBContext db = new MyDetailsDBContext())
            {
                my = db.MyDetails.Where(x => x.Fname == txtfnameup.Text).FirstOrDefault();
                my.Lname = txtlnameu.Text;
                my.Age = int.Parse(txtageu.Text);
                db.SaveChanges();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyDetails my = new MyDetails();

            using(MyDetailsDBContext db = new MyDetailsDBContext())
            {
                List<MyDetails> myDetails = db.MyDetails.ToList();

                foreach(var me in myDetails)
                {
                    listBox1.Items.Add(me.Fname.ToString());
                    listBox1.Items.Add(me.Lname.ToString());
                    listBox1.Items.Add(me.Age);
                }
            }

        }
    }
}