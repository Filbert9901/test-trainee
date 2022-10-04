using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCRUD.Models
{
    public class People
    {
        public int PeopleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DataTable LoadPeopleList()
        {
            Connection con = new Connection();
            con.Query("Select * from people");
            return con.ExecuteSelectQuery();
        }

        public DataTable LoadPersonById()
        {
            Connection con = new Connection();
            con.Query($"Select * from people where id = {PeopleId}");
            return con.ExecuteSelectQuery();
        }

        public void AddPeopleToDatabase()
        {
            Connection con = new Connection();
            con.Query("insert into people (first_name,last_name) values(@first_name,@last_name)");
            con.cmd.Parameters.AddWithValue("@first_name", FirstName);
            con.cmd.Parameters.AddWithValue("@last_name", LastName);
            con.ExecuteNonSelectQuery();
        }

        public void EditPeopleById()
        {
            Connection con = new Connection();
            con.Query($"update people set first_name = '{FirstName}', last_name = '{LastName}' where id = {PeopleId} ");
            con.ExecuteNonSelectQuery();
        }



        public void DeletePeopleById()
        {
            Connection con = new Connection();
            con.Query("delete from people where id = @id");
            con.cmd.Parameters.AddWithValue("id", PeopleId);
            con.ExecuteNonSelectQuery();
        }

    }
}
