using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text.Trim();
            int Num ;
            bool isNum = int.TryParse(str,out Num);
            if(isNum)
            {
                //List<int> list = new List<int>();
                //list.Add(str);
                List<int> list = new List<int>();
                list.Add(Num);
                foreach(int elements in list)
                listBox1.Items.Add(elements);
            }
            else 
            {
                ArrayList list = new ArrayList();
                list.Add(str);
                foreach (String element in list)
                    listBox2.Items.Add(element);
            }
        }
    }
}
