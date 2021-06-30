using PollosAPIREST.Dto;
using System.Collections.Generic;

namespace PollosAPIREST.Utils
{
    public static class SortingListValidator<T> where T : DtoAbstract
    {
        //[Id ASC,Name DESC,Dni,Lastname]
        public static bool Validate(List<string> sortingList)
        {
            foreach (var sortData in sortingList)
            {
                string[] array = sortData.Split(" ");
                string fieldName = array[0];
                if (array.Length > 2)
                {
                    return false;
                }

                if (array.Length == 2)
                {
                    string sortingType = array[1];

                    if (!sortingType.Equals("ASC") && !sortingType.Equals("DESC"))
                    {
                        return false;
                    }
                }

                bool isFieldNameExist = false;

                foreach (var field in typeof(T).GetProperties())
                {
                    isFieldNameExist = field.Name.Equals(fieldName) 
                        ? true 
                        : isFieldNameExist;
                }

                if (!isFieldNameExist)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
