namespace Array;

class Array
{
    static void arrayPractice()
    {
        //Creating a New Array[] of string
        string[] friends = new string[4];//Friends array with 4 elements

        //Assigning values to the Friends array
        friends[0] = "Xavier";
        friends[1] = "Kobe";
        friends[2] = "Jie Long";
        friends[3] = "Reuben";

        foreach (var friend in friends) //Looping all the elements out of the Array
        {
            Console.WriteLine(friend);
        }

        //Another way of Creating an Array (easier way)
        int[] ages = { 23,21,19,20};

        foreach (var age in ages)
        {
            Console.WriteLine(age);
        }
    }

    static void Main(string[] arguments) //Main method where everything will run
    {
        arrayPractice(); //All the code from Array Practice
    }
}