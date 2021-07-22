using PollosDatabase.Src.DbEntities;
using PollosDatabase.Src.SqlCommands;
using PollosDatabase.Src.Utils;
using System.Text;

namespace PollosDatabase.Src.Dao
{
    public static class DaoLogin
    {
        public static DbEntityUser FindByUsernamePassword(string username, string password)
        {
            string tableName = UtilAnnotationTableDb<DbEntityUser>.GetTableName();
            StringBuilder userNameAndPassword = new StringBuilder();
            userNameAndPassword.Append($"Username='{username}' AND ");
            userNameAndPassword.Append($"Password='{password}'");
            var filteredList = SqlCommandSelectFilter<DbEntityUser>.Execute(
                tableName, userNameAndPassword.ToString());
            return (filteredList.Count < 1) ? null : filteredList[0];
        }
    }
}
