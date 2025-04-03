using System;
using System.ComponentModel;

namespace Bank
{
    public enum TextSize
    {
        H1,
        H2,
        H3,
        H4,
        NormalText
    }

    public static class EnumExtensions
    {
        public static string Name<T>(this T value) where T : Enum
        {
            return Enum.GetName(typeof(T), value);
        }
    }
}