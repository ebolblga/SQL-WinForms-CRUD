using System.Collections.Immutable;
using System.Data;
using Dapper;

namespace MySQL_WinForms_CRUD;

public class DataAccess
{
    // SELECT * WHERE
    public List<Person> GetPeople(int id)
    {
        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CrudDB")))
        {
            return connection.Query<Person>($"SELECT * FROM People WHERE id = '{id}'").ToList();
        }
    }

    //INSERT
    public void InsetPerson(int id, string Name, bool Vote)
    {
        List<Person> people = new List<Person>();
        people.Add(new Person { id = id, Name = Name, Vote = Vote });

        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CrudDB")))
        {
            connection.Execute($"INSERT INTO People(id, Name, Vote) VALUES (@id, @Name, @Vote)", people);
        }
    }

    // SELECT *
    public List<Person> GetAll()
    {
        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CrudDB")))
        {
            return connection.Query<Person>($"SELECT * FROM People").ToList();
        }
    }

    // COUNT
    public int Count()
    {
        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CrudDB")))
        {
            return connection.ExecuteScalar<int>($"SELECT COUNT(*) FROM People");
        }
    }

    // DELETE
    public void DeletePerson(int id)
    {
        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CrudDB")))
        {
            connection.ExecuteAsync($"DELETE People WHERE id = '{id}'");
        }
    }

    // UPDATE
    public void UpdatePerson(int id, string Name, bool Vote)
    {
        List<Person> people = new List<Person>();
        people.Add(new Person { id = id, Name = Name, Vote = Vote });

        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CrudDB")))
        {
            connection.Execute($"UPDATE People SET Name = @Name, Vote = @Vote WHERE id = @id", people);
        }
    }
}
