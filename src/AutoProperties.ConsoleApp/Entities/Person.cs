namespace AutoProperties.ConsoleApp.Entities
{
    internal class Person(string firstName, string lastName, int age)
    {
        // Auto properties são mais concisas e reduzem a quantidade de código boilerplate
        public string FirstName { get; set; } = firstName;
        public string LastName { get; set; } = lastName;
        public int Age { get; set; } = age;
    }
}