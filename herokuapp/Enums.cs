using System;
using System.ComponentModel;
using System.Reflection;

namespace herokuapp
{
    public static class Enums
    {
        public static string GetEnumText(Enum value)
        {
            FieldInfo FieldInfo = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] Attributes = (DescriptionAttribute[])FieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (Attributes != null && Attributes.Length > 0) return Attributes[0].Description;
            else return value.ToString();
        }

        public enum BrowerTypes
        {
            Chrome,
            IE
        }

        public enum HomePageLinks
        {
            Dropdown,
            [Description("Form Authentication")]
            FormAuthentication,
            [Description("JavaScript Alerts")]
            JavaScriptAlerts,
            [Description("WYSIWYG Editor")]
            WYSIWYGEditor,
            NegativeTest
        }
                
        
    }
}
