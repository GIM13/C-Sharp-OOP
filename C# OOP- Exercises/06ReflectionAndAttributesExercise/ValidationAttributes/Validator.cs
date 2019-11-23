using System.Linq;
using System.Reflection;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(Person person)
        {
            PropertyInfo[] objPropertues = person.GetType()
                .GetProperties();

            foreach (var objPropertue in objPropertues)
            {
                var propAttributes = objPropertue
                    .GetCustomAttributes()
                    .Where(x => x is MyValidationAttribute)
                    .Cast<MyValidationAttribute>();

                foreach (var propAttribute in propAttributes)
                {
                    bool result = propAttribute.IsValid(objPropertue.GetValue(person));

                    if (!result)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}