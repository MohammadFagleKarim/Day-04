using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop
{
    public partial class ArrayTest : Form
    {
        int size = 0, index = 0;
        int[] arr = new int[5];
        public ArrayTest()
        {
            InitializeComponent();
        }

        private void addSizeBtn_Click(object sender, EventArgs e)
        {
            if(size < 5)
            {
                size = Convert.ToInt32(sizeTB.Text);
            }
            else
            {
                MessageBox.Show("Size cannot be more than 5");
            }
        }

        private void addElementBtn_Click(object sender, EventArgs e)
        {
            if(index < size)
            {
                arr[index] = Convert.ToInt32(elementTB.Text);
                index++;
            }
            else
            {
                MessageBox.Show("Cannnot insert more than " + size + " elements.");
            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            //const int size = 10;
            //string[] name = new string[size];
            //name[0] = "Alimul";
            //name[1] = "Asad";
            //name[2] = "Ripon";
            //name[3] = "Karim";

            //int[] age = new int[size];

            string message = "";
            //for(int i=0; i<size; i++)
            //{
            //    message += "Name: " + name[i] + ", Age: " + age[i] + "\n";
            //}
            //MessageBox.Show(message);

            for (int i = 0; i < size; i++)
            {
                message += "The inserted elements are: " + arr[i] + " " + "\n";
            }
            MessageBox.Show(message);
        }
    }
}