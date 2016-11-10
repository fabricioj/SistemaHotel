using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.util
{
    public class EnumHelper
    {
        public static string GetDescription(Enum value)
        {
            string description = value.ToString();
            System.Reflection.FieldInfo fieldInfo = value.GetType().GetField(description);
            System.ComponentModel.DescriptionAttribute[] attributes =
               (System.ComponentModel.DescriptionAttribute[])
             fieldInfo.GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
            {
                description = attributes[0].Description;
            }
            return description;
        }
        public static System.Collections.IList ToList(Type type)
        {
            System.Collections.ArrayList list = new System.Collections.ArrayList();
            Array enumValues = Enum.GetValues(type);

            foreach (Enum value in enumValues)
            {
                list.Add(new KeyValuePair<Enum, string>(value, GetDescription(value)));
            }

            return list;
        }
        public static Enum GetValue(Object obj)
        {
            return ((KeyValuePair<Enum, string>)obj).Key;
        }

        public static KeyValuePair<Enum, string> SetValue(Enum value) {
            return new KeyValuePair<Enum, string>(value, GetDescription(value));
        }
    }
}
