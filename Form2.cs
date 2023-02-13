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
    public partial class Form2 : Form
    {
        public Product product ;
        Form3 form3 = new Form3();
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Product product)
        {
            InitializeComponent();
            textBox1.Text = product.Name;
            numericUpDown1.Value = product.Cina;
        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            product = new Product(textBox1.Text, numericUpDown1.Value);            
             form3.listBox1.Items.Add(product);
            
            //Visible
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            //this.Hide();
            // richTextBox1.Text=r
            
            //this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                form3.Show();
                this.Close();
            
        }
    }
}
