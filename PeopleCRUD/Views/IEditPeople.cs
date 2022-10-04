using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCRUD.Views
{
    internal interface IEditPeople
    {
        string TbFirstName { get; set; }
        string TbLastName { get; set; }
    }
}
