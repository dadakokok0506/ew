// CustomAttribute.cs
using System;

namespace ReflectionDemo
{
    [AttributeUsage(AttributeTargets.All)]
    public class CustomAttribute : Attribute
    {
        public CustomAttribute()
        {
            Console.WriteLine("Custom Attribute Created.");
        }
    }
}

