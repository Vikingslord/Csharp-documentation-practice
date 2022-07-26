namespace CsTryout
{
    class DataCasting
    {
        static void Main()
        {
            //Converting strings to Number(Int)
            int first = 5;
            int second = 15;

            string message = first.ToString() + second.ToString(); 
            Console.WriteLine(message);

            //Converting Int to String
            string firstString = "5";
            string secondString = "15";

            int sum = int.Parse(firstString) + int.Parse(secondString);
            Console.WriteLine(sum);

            //convert a string to a number using the Convert class
            string value1 = "5";
            string value2 = "7";
            int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
            Console.WriteLine(result);

        }
    }
}
