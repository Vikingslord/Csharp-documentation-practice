
namespace CsTryout
{
    class Switch
    {
        static void Main(string[] arguments)
        {
            int employeeLevel = 200;
            string employeeName = "John Smith";

            string title = "";

            switch (employeeLevel)
            {
                case 100:
                    title = "Junior Associate";
                    break;
                case 200:
                    title = "Associate";
                    break;
                case 300:
                    title = "Senior Associate";
                    break;
                case 400:
                    title = "Managing Partner";
                    break;
                default:
                    title = "Founder";
                    break;
            }

            Console.WriteLine($"{employeeName}, {title}");

        }
    }
}
