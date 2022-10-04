using PeopleCRUD.Models;
using PeopleCRUD.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCRUD.Presenters
{
    internal class DeletePeoplePresenter
    {
        People people = new People();
        private IDeletePeople deleteView;

        public DeletePeoplePresenter(IDeletePeople view)
        {
            deleteView = view;   
        }

        public void DeletePeople(int peopleId)
        {
            people.PeopleId = peopleId;
            people.DeletePeopleById();
        }
    }
}
