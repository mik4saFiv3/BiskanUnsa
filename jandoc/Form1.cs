using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.setName(textBox4.Text);
            person.setAddress(textBox5.Text);
            person.setContact(Int32.Parse(textBox6.Text));

            MessageBox.Show("Save!");
            Form2 form = new Form2(person);
            form.Show();
            this.Hide();
            
        }
    }
}
