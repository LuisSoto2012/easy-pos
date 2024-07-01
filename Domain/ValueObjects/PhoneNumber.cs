// PhoneNumber.cs03:0703:07
using System.Text.RegularExpressions;

namespace Domain.ValueObjects;

public partial record PhoneNumber
{
    private const int DefaultLength = 9;
    private const string Pattern = @"^(?:-*\d-*){8}$";
    
    private PhoneNumber(string value) => this.Value = value;

    public static PhoneNumber? Create(string value)
    {
        if (string.IsNullOrEmpty(value) || !PhoneNumberRegex().IsMatch(value) || value.Length != DefaultLength)
        {
            return null;
        }

        return new PhoneNumber(value);
    }
    
    public string Value { get; set; }

    [GeneratedRegex(Pattern)]
    private static partial Regex PhoneNumberRegex();
}