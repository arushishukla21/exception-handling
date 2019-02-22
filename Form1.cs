using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_exception
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                string x = textBox3.Text;

                MyClass obj = new MyClass();
                obj.show(x);

            }
            catch(myOwnexception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public class myOwnexception : Exception
        {
            public myOwnexception(string msg) : base(msg)
            {

            }
        }
        public class MyClass
        {
            public void show(string x)
            {
                if (x == " " && x != "A+" && x != "A" && x!= "B+" && x != "B" && x != "C+" && x != "C")
                {
                    throw (new myOwnexception("Grade only A+ OR A OR B+ OR B OR C+ OR C" ));
                }
                
            }
        }
    }
}
