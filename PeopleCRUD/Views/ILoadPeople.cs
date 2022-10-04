using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleCRUD.Views
{
    internal interface ILoadPeople
    {
       DataGridView DGVPeople { get; set; }
    }
}
