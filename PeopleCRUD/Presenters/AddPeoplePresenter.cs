using PeopleCRUD.Models;
using PeopleCRUD.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCRUD.Presenters
{
    internal class AddPeoplePresenter
    {
        People people = new People();
        private IAddPeople addPeopleView;

        public AddPeoplePresenter(IAddPeople view)
        {
           addPeopleView = view;
        }

        public void AddPeople()
        {
            people.FirstName = addPeopleView.TbFirstName;
            people.LastName = addPeopleView.TbLastName;
            people.AddPeopleToDatabase();
        }
    }
}
