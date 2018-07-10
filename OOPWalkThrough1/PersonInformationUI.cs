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
        Person aPerson = new Person();
        private void showButton_Click(object sender, EventArgs e)
        {

            aPerson.firstname = firstNameTextBox.Text;
            aPerson.middlename = middleNameTextBox.Text;
            aPerson.lastname = lastNameTextBox.Text;

            fullNameTextBox.Text = aPerson.GetFullName();
            reverseNameTextBox.Text = aPerson.GetReverseName();

        }
    }
}
