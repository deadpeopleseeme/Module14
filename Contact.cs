namespace Module14LINQ
{
    // использование основного конструктора даёт более лаконичную запись
    internal class Contact(string name, string lastName, long phoneNumber, string email)
    {
        public string Name { get; } = name;
        public string LastName { get; } = lastName;
        public long PhoneNumber { get; } = phoneNumber;
        public string Email { get; } = email;
    }
}
