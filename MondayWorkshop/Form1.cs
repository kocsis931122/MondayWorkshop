using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MondayWorkshop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct Person
        {
            private string name;
            private string address;
            private int age;
            private string telephoneNumber;
            private string type;
        
            public Person(string name, string address, int age, string telephoneNumber, string type)
            {
                this.name = name;
                this.address = address;
                this.age = age;
                this.telephoneNumber = telephoneNumber;
                this.type = type;
            }
            public override string ToString()
            {
                return string.Format("Name: {0}, Address: {1}, Age: {2}, Mobile: {3}, Type: {4}", name, age, address, telephoneNumber, type.ToString());
            }
        }
        class TelephoneDirectory
        {
            public static List<Person> persons = new List<Person>(50);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxType.Items.Add("Home");
            comboBoxType.Items.Add("Workplace");
            comboBoxType.Items.Add("Mobile");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelephoneDirectory.persons.Add(new Person(textBoxName.Text, textBoxAddress.Text, Int32.Parse(textBoxAge.Text), textBoxMobile.Text, comboBoxType.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            for (int i = 0; i < TelephoneDirectory.persons.Count; i++)
            {
                listBox.Items.Add(TelephoneDirectory.persons[i].ToString());
            }
        }
    }
}
