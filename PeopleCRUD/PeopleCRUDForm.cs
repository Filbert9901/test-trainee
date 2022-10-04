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
    public partial class PeopleCRUDForm : Form,ILoadPeople,IAddPeople,IDeletePeople
    {
        private LoadPeoplePresenter loadPresenter;
        private AddPeoplePresenter addPeoplePresenter;
        private DeletePeoplePresenter deletePeoplePresenter;

        private int peopleId;
        public PeopleCRUDForm()
        {
            InitializeComponent();
        }

        public DataGridView DGVPeople { get => dgvPeople; set => dgvPeople.DataSource = value; }
        public string TbFirstName { get => txtFirstName.Text; set => throw new NotImplementedException(); }
        public string TbLastName { get => txtLastName.Text; set => throw new NotImplementedException(); }
        string IDeletePeople.peopleId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private void PeopleCRUDForm_Load(object sender, EventArgs e)
        {
            LoadPeopleList();
        }

        private void btnAddPeople_Click(object sender, EventArgs e)
        {
            addPeoplePresenter = new AddPeoplePresenter(this);
            addPeoplePresenter.AddPeople();
            LoadPeopleList();
        }

        private void LoadPeopleList()
        {
            loadPresenter = new LoadPeoplePresenter(this);
            loadPresenter.DisplayPeopleToDGV();
        }
        
        private void dgvPeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPeople.Rows[e.RowIndex];

                peopleId = int.Parse(row.Cells["id"].Value.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to delete this person","Delete Person", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                deletePeoplePresenter = new DeletePeoplePresenter(this);
                deletePeoplePresenter.DeletePeople(peopleId);
                LoadPeopleList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditPeopleForm editPeopleForm = new EditPeopleForm();
            editPeopleForm.peopleId = peopleId;
            editPeopleForm.ShowDialog();
            LoadPeopleList();
        }
    }
}
