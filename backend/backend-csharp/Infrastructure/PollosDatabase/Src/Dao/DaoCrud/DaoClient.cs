using PollosDatabase.Src.DbEntities;
using PollosDatabase.Src.SqlCommands;
using PollosDatabase.Src.Utils;
using System.Collections.Generic;

namespace PollosDatabase.Src.Dao.DaoCrud
{
    public static class DaoClient
    {
        private static string tableName = UtilAnnotationTableDb<DbEntityClient>.GetTableName();

        public static void Create(DbEntityClient dbEntity)
        {
            string columns = "Dni,Name,CreatedBy";
            string values = $"'{dbEntity.Dni}','{dbEntity.Name}','{dbEntity.CreatedBy}'";
            SqlCommandInsert<DbEntityClient>.Execute(dbEntity, tableName, columns, values);
        }

        public static List<DbEntityClient> Read()
        {
            return SqlCommandSelect<DbEntityClient>.Execute(tableName);
        }

        public static void Update(int id, DbEntityClient dbEntity)
        {
            string columnsAndValues =
                $"Dni='{dbEntity.Dni}',Name='{dbEntity.Name}',UpdatedBy='{dbEntity.UpdatedBy}'";
            SqlCommandUpdate<DbEntityClient>.Execute(dbEntity, tableName, id, columnsAndValues);
        }

        public static void Delete(int id)
        {
            SqlCommandDelete<DbEntityClient>.Execute(tableName, id);
        }
    }
}
