using PollosDatabase.Src.DbEntities;
using PollosDatabase.Src.SqlCommands;
using PollosDatabase.Src.Utils;
using System.Collections.Generic;

namespace PollosDatabase.Src.Dao.DaoCrud
{
    public static class DaoProduct
    {
        private static string tableName = UtilAnnotationTableDb<DbEntityProduct>.GetTableName();

        public static void Create(DbEntityProduct dbEntity)
        {
            string columns = "ProductName,ProductPrice,Stock,CreatedBy";
            string values = $"'{dbEntity.ProductName}','{dbEntity.ProductPrice}','{dbEntity.Stock}','{dbEntity.CreatedBy}'";
            SqlCommandInsert<DbEntityProduct>.Execute(dbEntity, tableName, columns, values);
        }

        public static List<DbEntityProduct> Read()
        {
            return SqlCommandSelect<DbEntityProduct>.Execute(tableName);
        }

        public static void Update(int id, DbEntityProduct dbEntity)
        {
            string columnsAndValues =
                $"ProductName='{dbEntity.ProductName}',ProductPrice='{dbEntity.ProductPrice}',Stock='{dbEntity.Stock}',UpdatedBy='{dbEntity.UpdatedBy}'";
            SqlCommandUpdate<DbEntityProduct>.Execute(dbEntity, tableName, id, columnsAndValues);
        }

        public static void Delete(int id)
        {
            SqlCommandDelete<DbEntityProduct>.Execute(tableName, id);
        }
    }
}
