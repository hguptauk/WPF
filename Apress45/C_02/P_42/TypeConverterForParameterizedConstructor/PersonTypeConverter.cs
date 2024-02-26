using System.ComponentModel;

namespace TypeConverterForParameterizedConstructor
{
    public class PersonTypeConverter : TypeConverter
    {
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {


            // We can convert from Person to string
            if (destinationType == typeof(string))
            {
                return true;
            }

            return base.CanConvertTo(context, destinationType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            if (value is Person person && destinationType == typeof(string))
            {
                return $"{person.Name}, is {person.Age} years old";
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }
        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            // Convert the string to a Person object
            if (value is string stringValue)
            {
                string[] parts = stringValue.Split(',');
                if (parts.Length == 2)
                {
                    string name = parts[0].Trim();
                    if (int.TryParse(parts[1].Trim(), out int age))
                    {
                        return new Person(name, age);
                    }
                }
            }

            return base.ConvertFrom(context, culture, value);
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            // We can convert from string to Person
            if (sourceType == typeof(string))
            {
                return true;
            }

            return base.CanConvertFrom(context, sourceType);
        }
    }
}
