using PeopleCRUD.Models;
using PeopleCRUD.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCRUD.Presenters
{
    internal class EditPeoplePresenter
    {
        People people = new People();
        private IEditPeople editPeopleView;

        public EditPeoplePresenter(IEditPeople view)
        {
            editPeopleView = view;
        }

        public void LoadPersonInfo(int peopleId)
        {
            people.PeopleId = peopleId;

            DataTable dt = people.LoadPersonById();

            editPeopleView.TbFirstName = dt.Rows[0]["first_name"].ToString();
            editPeopleView.TbLastName = dt.Rows[0]["last_name"].ToString();

        }

        public void EditPerson()
        {
            people.FirstName = editPeopleView.TbFirstName;
            people.LastName = editPeopleView.TbLastName;
            people.EditPeopleById();
        }

    }
}
