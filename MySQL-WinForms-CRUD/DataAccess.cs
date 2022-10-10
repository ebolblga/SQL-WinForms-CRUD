using System.Data;
using Dapper;

namespace MySQL_WinForms_CRUD;

public class DataAccess
{
    public List<Person> GetPeople(int id)
    {
        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CrudDB")))
        {
            return connection.Query<Person>($"SELECT * FROM People WHERE id = '{id}'").ToList();
        }
    }
}
