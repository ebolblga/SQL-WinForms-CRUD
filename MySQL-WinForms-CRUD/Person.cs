namespace MySQL_WinForms_CRUD;

public class Person
{
    public int id { get; set; }

    public string Name { get; set; }

    public bool Vote { get; set; }

    public string FullInfo
    {
        get
        {
            return $"{id} {Name} {Vote}";
        }
    }
}
