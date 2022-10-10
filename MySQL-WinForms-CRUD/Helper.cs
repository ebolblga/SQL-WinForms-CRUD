using System.Configuration;

namespace MySQL_WinForms_CRUD;

public static class Helper
{
    public static string CnnVal(string name)
    {
        return ConfigurationManager.ConnectionStrings[name].ConnectionString;
    }
}
