using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form3 : Form
    {
        Product product;
        public Form3()
        {
            InitializeComponent();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            Form1 form1 = new Form1();
            // this.Hide();
            form1.ShowDialog();
            this.Close();

        }       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Form2 f2 = new Form2();
            //listBox1= new ListBox();
            //listBox1.Items.Add(new ListViewItem(f2.product.ToString()));
            //listBox1.Items.AddRange(s);
            //Product tmp = new Product(f3.product.Name, f3.product.Cina);
            //listBox1.Items.Add("gfhfh");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Product tmp;
            //Form2 form2 = new Form2();
            //tmp = new Product(form2.product.Name, form2.product.Cina);
            //listBox1.Items.Add(tmp);
            //listBox1.Items.Add("gfhfh");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Product tex = listBox1.SelectedItem as Product;             
            Form2 form2 = new Form2(tex); 
            form2.Show();
            this.Close();
            
            
            
                
                }
    }
}
