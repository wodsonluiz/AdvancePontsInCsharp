using System.Text.Json.Serialization;

namespace RecordTypes.Console
{
    public record Person([property: JsonPropertyName("first_name")] string FirstName, string LastName)
    {
        public string FullName => $"{FirstName} {LastName}";
        public Address Address { get; init; }
    }

    public record Address(string street, string postalCode)
    {
    }

    public record PriorityPerson(string FirstName, string LastName): Person(FirstName, LastName);
}