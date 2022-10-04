using PeopleCRUD.Models;
using PeopleCRUD.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCRUD.Presenters
{
    internal class LoadPeoplePresenter
    {
        People people = new People();
        private ILoadPeople loadPeopleView;

        public LoadPeoplePresenter(ILoadPeople view)
        {
            loadPeopleView = view;
        }

        public void DisplayPeopleToDGV()
        {
            loadPeopleView.DGVPeople.DataSource = people.LoadPeopleList();
        }

    }
}
