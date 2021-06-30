using PollosAPIREST.Dto;

namespace PollosAPIREST.Utils
{
    public static class DtoUpdateFactory<T> where T : DtoAbstract
    {
        public static T GetDto(T oldObject, T newObject)
        {
            foreach (var field in typeof(T).GetProperties())
            {
                if (field.GetValue(newObject) != null && !field.GetValue(newObject).Equals(string.Empty))
                {
                    field.SetValue(oldObject, field.GetValue(newObject));
                }
            }
            return oldObject;
        }
    }
}
