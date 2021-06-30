using PollosAPIREST.Dto;
using System.Collections.Generic;
using System.Reflection;

namespace PollosAPIREST.Utils
{
    public static class FilterListValidator<T> where T : DtoAbstract
    {
        public static bool Validate(string data)
        {
            string[] array = data.Split("=");
            string fieldName = array[0];

            if (array.Length != 2)
            {
                return false;
            }

            bool isFieldNameExist = false;
            var listProps = new List<PropertyInfo>(typeof(T).GetProperties());
            listProps.ForEach(prop => 
                isFieldNameExist = prop.Name.Equals(fieldName) 
                    ? true 
                    : isFieldNameExist);

            if (!isFieldNameExist)
            {
                return false;
            }
            return true;
        }
    }
}
