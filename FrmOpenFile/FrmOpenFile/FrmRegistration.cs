using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLab1
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            String[] data =
            {
                "Student Number: " + studentNo.Text,
                "Full Name: " + lastName.Text + ", "   + firstName.Text + " " + middleInitial.Text,
                "Program: " + program.Text,
                "Gender: " + gender.Text,
                "Age: " + age.Text,
                "Birthday: " + bday.Text,
                "Contact Number: " + contactNo.Text,
            };
            using (StreamWriter write = new StreamWriter($"{path}\\{studentNo.Text}.txt"))
            {
                foreach (var item in data)
                {
                    write.WriteLine(item);
                }
            }

        }
    }
}
