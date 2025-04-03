using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;

namespace Bank
{
    public enum Palette
    {
        [Color(44, 53, 80)]
        Background,
        [Color(44, 53, 100)]
        Primary,
        [Color(72, 83, 108)]
        Secondary,
        [Color(39, 174, 96)]
        Confirm,
        [Color(231, 76, 60)]
        Cancel,
        [Color(255, 255, 255)]
        Text,
        [Color(0, 0, 0)]
        ButtonText,
        [Color(255, 255, 255)]
        CardBackground
    }

    public static class ColorAttributeExtension
    {
        public static Color GetColor(this Enum value)
        {
            Type type = value.GetType();

            FieldInfo field = type.GetField(value.ToString());

            ColorAttribute attribute = (ColorAttribute)Attribute.GetCustomAttribute(field, typeof(ColorAttribute));

            return attribute.CustomColor;
        }
    }
}