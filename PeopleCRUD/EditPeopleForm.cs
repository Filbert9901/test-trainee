using PeopleCRUD.Presenters;
using PeopleCRUD.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleCRUD
{
    public partial class EditPeopleForm : Form,IEditPeople
    {
        public int peopleId;
        private EditPeoplePresenter editPeoplePresenter;
        public EditPeopleForm()
        {
            InitializeComponent();
        }

        public string TbFirstName { get => txtFirstName.Text; set => txtFirstName.Text = value; }
        public string TbLastName { get => txtLastName.Text; set => txtLastName.Text = value; }

        private void EditPeopleForm_Load(object sender, EventArgs e)
        {
            editPeoplePresenter = new EditPeoplePresenter(this);
            editPeoplePresenter.LoadPersonInfo(peopleId);
        }

        private void btnEditPeople_Click(object sender, EventArgs e)
        {
            editPeoplePresenter.EditPerson();
            this.Close();
        }
    }
}
