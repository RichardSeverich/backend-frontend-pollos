using PollosDatabase.Src.DbEntities;
using PollosDatabase.Src.SqlCommands;
using PollosDatabase.Src.Utils;
using System.Collections.Generic;

namespace PollosDatabase.Src.Dao.DaoCrud
{
    public static class DaoUser
    {
        private static string tableName = UtilAnnotationTableDb<DbEntityUser>.GetTableName();

        public static void Create(DbEntityUser dbEntityUser)
        {
            string columns = "Dni,Name,Lastname,BirthDate,Address,PhoneNumber,Email,Username,Password,CreatedBy";
            string values = $"'{dbEntityUser.Dni}','{dbEntityUser.Name}','{dbEntityUser.Lastname}'," +
                $"'{dbEntityUser.BirthDate}','{dbEntityUser.Address}','{dbEntityUser.PhoneNumber}'," +
                $"'{dbEntityUser.Email}','{dbEntityUser.Username}','{dbEntityUser.Password}','{dbEntityUser.CreatedBy}'";
            SqlCommandInsert<DbEntityUser>.Execute(dbEntityUser, tableName, columns, values);
        }

        public static List<DbEntityUser> Read()
        {
            return SqlCommandSelect<DbEntityUser>.Execute(tableName);
        }

        public static void Update(int id, DbEntityUser dbEntityUser)
        {
            string columnsAndValues = 
                $"Dni='{dbEntityUser.Dni}',Name='{dbEntityUser.Name}',Lastname='{dbEntityUser.Lastname}'," +
                $"BirthDate='{dbEntityUser.BirthDate}',Address='{dbEntityUser.Address}',PhoneNumber='{dbEntityUser.PhoneNumber}'," +
                $"Email='{dbEntityUser.Email}',Username='{dbEntityUser.Username}',Password='{dbEntityUser.Password}',UpdatedBy='{dbEntityUser.UpdatedBy}'";
            SqlCommandUpdate<DbEntityUser>.Execute(dbEntityUser, tableName, id, columnsAndValues);
        }

        public static void Delete(int id)
        {
            SqlCommandDelete<DbEntityUser>.Execute(tableName, id);
        }
    }
}
