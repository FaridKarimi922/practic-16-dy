namespace tamrin_1__16_dy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstName = GetStringValid("please Enter FirstName :");
            var lastName = GetStringValid("please Enter LastName :");

            Person.GetFullName(firstName, lastName);

        }
        public static string GetStringValid(string message)
        {
            string? value;
            do
            {
                Console.WriteLine(message);
                value = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(value));
            return value;

        }
    }
}
