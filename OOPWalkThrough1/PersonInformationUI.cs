using System;
using System.Windows.Forms;
using OOPWalkThrough1.modals;

namespace OOPWalkThrough1
{
    public partial class PersonInformationUI : Form
    {
        public PersonInformationUI()
        {
            InitializeComponent();
        }
        Person aPerson ;
        private void showButton_Click(object sender, EventArgs e)
        {

            //aPerson.Firstname = firstNameTextBox.Text;
            //aPerson.Middlename = middleNameTextBox.Text;
            //aPerson.Lastname = lastNameTextBox.Text;
            Person aPerson=new Person(firstNameTextBox.Text,middleNameTextBox.Text,lastNameTextBox.Text);
            fullNameTextBox.Text = aPerson.Fullname;
            reverseNameTextBox.Text = aPerson.Reversename;

        }
    }
}
