namespace StringsAndArrays
{
    class Program
    {
        // INSTRUCTIONS: Write you task related code answers under each specific comment/insturction
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1. Strings: ");
            Console.WriteLine(" ");
            // PART 1: Strings

            // 1. Basic String Operations
            string helloWorld = "Hello, World!";  // (Part of the original code)

            // 1.1 Print the length of the string.
            Console.WriteLine("1: ");
            Console.WriteLine("The length of the helloWorld string is: " + helloWorld.Length);

            // 1.2 Print the first and the last character of the string.

            Console.Write("The first character of the string is: ");
            Console.WriteLine(helloWorld[1]);

            Console.Write("The last character of the string is: ");
            Console.WriteLine(helloWorld[12]);

            Console.WriteLine(" ");

            // 2. String Manipulation
            Console.Write("2: ");
            Console.WriteLine(" ");

            Console.Write("Please enter your name: ");  // (Part of the original code)
            // 2.1 Get the input from and assing it into new string variable called name
            string name = Console.ReadLine();

            // 2.2 Print a personalized welcome message including the name.
            Console.WriteLine("Welcome " + name);

            // 2.3 Convert name variable to uppercase and output the result
            Console.WriteLine(name.ToUpper());

            // 2.4 Convert name variable to lovercase and output the result
            Console.WriteLine(name.ToLower());

            Console.WriteLine(" ");
            // 3. String Searching
            Console.WriteLine("3: ");
            // 3.1 Create new boolean variable called containsWorld

            bool containsWorld = true;

            // 3.2 Check that the helloWorld variable contains the word "World".
            //     Assign the result to the created constainsWorld variable

            containsWorld = helloWorld.Contains("World");

            if (containsWorld)
            {
                Console.WriteLine("Contains the word \"World\"");
            }
            else if (containsWorld == false)
            {
                Console.WriteLine("Does not contain the word \"World\"");
            }


            // 3.3 If the word is found, get the index of the word from helloWorld string
            if (containsWorld)
            {
                Console.Write("The index of the word is: ");
                Console.WriteLine(helloWorld.IndexOf("W"));
            }

            Console.WriteLine(" ");

            // PART 2: Arrays
            Console.WriteLine("Part 2. Arrays:");
            Console.WriteLine(" ");

            // 1. Basic Array Operations
            Console.WriteLine("1: ");

            // 1.1 initialize array called numbers containing array of int values
            //     Add these values to the array -> 2 3 5 7 11 
            int[] numbers = { 2, 3, 5, 7, 11 };

            // 1.2 Output the numbers array -> hint use Join
            // Expected outcome: 2, 3, 5, 7, 11
            string numbersArray = string.Join(", ", numbers);
            Console.WriteLine(numbersArray);

            // 1.3 Output the value of the third (3th) item in the numbers array 
            // Expected outcome: 5
            Console.WriteLine(numbers[2]);

            Console.WriteLine(" ");

            // 2. Array Manipulation
            Console.WriteLine("2: ");
            Console.WriteLine("Please enter five names:");  // (Part of the original code)

            // 2.1 Initialize new names string array variable that has room for 5 items
            //     The maximum lenght of the string array should be 5
            string[] newNames = new string[5];

            // 2.2 Ask the user to input new names 5 times
            //     and assing each name to the names string array in the given order.
            //     The first name should be at index 0
            //     Hint: you might want to use some sort of a loop here
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter name {i + 1}: ");
                newNames[i] = Console.ReadLine();
            }

            // 2.3 Output the array of given names.
            string namesArray = string.Join(", ", newNames);
            Console.WriteLine(namesArray);

            // 2.4 Reverse the order of the items in the names array and outpu the result
            Array.Reverse(newNames);

            foreach (string rName in newNames)
            {
                Console.WriteLine(rName);
            }

            Console.WriteLine(" ");

            // 3. Array Searching
            Console.WriteLine("Part 3. Array Searching:");
            Console.WriteLine(" ");

            Console.WriteLine("1: ");
            Console.Write("Please enter a name to search: ");  // (Part of the original code)
            string searchName = Console.ReadLine();           // (Part of the original code)
            // 3.1 Try to find out the searchName from the Task 2 names string array
            //     by finding out it's index.
            //     Assign the index value to new position integer variable
            int index = Array.IndexOf(newNames, searchName);

            // 3.2 Check that the index position was found
            //     Hint: What is the result of IndexOf if nothing is found
            // 3.2.1 If position is found output the searchName and the found position
            // 3.2.2 Else output that the searchName was not found
            if (index != -1)
            {
                Console.WriteLine($"The index of {searchName} is: {index}");
            }
            else
            {
                Console.WriteLine($"{searchName} name not found");
            }

            Console.WriteLine(" ");
            Console.WriteLine("4. Bonus: ");
            Console.WriteLine(" ");

            Console.WriteLine("1: ");
            // 4. BONUS

            // 1. String to Array
            // 1.1 Create new empty words string array

            string[] words;

            // 1.2 Try to get each word from the helloWorld variable and assing the values to
            //     the created words string array

            words = helloWorld.Split(' ', '.', StringSplitOptions.RemoveEmptyEntries);

            // 1.3 Output the values of the words array

            Console.WriteLine("Words Array:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
