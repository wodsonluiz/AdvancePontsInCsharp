using System.Diagnostics.CodeAnalysis;

namespace NullableReferenceTypes.Console
{
    public static class OrderValidator
    {
        public static bool ValidaDescription([NotNullWhen(true)] string description)
        {
            return true;
        }
    }
}