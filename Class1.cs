using System;
using System.Reflection;
using System.Dynamic;
using System.Collections.Generic;
public class Class1
{
    public static dynamic ToExpando(Type t, Object o)
    {
        dynamic Properties = new ExpandoObject();
        var expandoDictionary = Properties as IDictionary<string, object>;
        PropertyInfo[] propertyArray = t.GetProperties();
        foreach (PropertyInfo property in propertyArray)
        {
            if (property.GetValue(o, null) != null)
            {
                expandoDictionary.Add(property.Name, property.GetValue(o, null));
            }
        }
        return Properties;
    }

}
