// See https://aka.ms/new-console-template for more information
bool start = true;
while (start)
{
    //Information to user how to use the program
    Console.WriteLine("Hi, Welcome to the main-menu");
    Console.WriteLine("0: exit");
    Console.WriteLine("1:Adolscence or Pensioner");
    Console.WriteLine("2:Adolscence or Pensioner V2");
    Console.WriteLine("3:Repeat 10 times");
    Console.WriteLine("4:The third word ");

    //Read input from user
    string userInput = Console.ReadLine();

    switch (userInput)
    {
        //If userInput is 0 exit the program
        case "0":
            start = false;
            break;
        case "1":
            //Get value from user
            Console.WriteLine("Please type age in numbers: ");
            string input = Console.ReadLine();
            int age;

            //User can only type an integer value
            while (!int.TryParse(input, out age))
            {
                Console.WriteLine("Not a valid number, try again.");
                input = Console.ReadLine();
            }

            //convert the input from user to an Integer
            age = int.Parse(input);

            //age less than 5 years or higher than 100 years price is free
            if (age < 5 || age > 100)
            {
                Console.WriteLine("Free of charge!");
            }
            //age less than 20 years price is 80 kr
            else if (age < 20)
            {
                Console.WriteLine("For adolescences price: 80 kr");
            }
            //age higher than 64 years price is 90 kr
            else if (age > 64)
            {
                Console.WriteLine("For pensioners price: 90 kr");
            }
            //all other ages the price is 120 kr
            else
            {
                Console.WriteLine("Standard price: 120 kr");
            }
            break;

        case "2":
            int price = 0;
            //Letting user type how many they are
            Console.WriteLine("Type how many you are: ");
            input = Console.ReadLine();

            //Program only accepts integer values
            while (!int.TryParse(input, out age))
            {
                Console.WriteLine("Not a valid number, try again.");
                input = Console.ReadLine();
            }
            //Convert user's input to integer
            int nbrOfPersons = int.Parse(input);
            //User typing the ages for every person
            for (int i = 1; i <= nbrOfPersons; i++)
            {
                Console.WriteLine("Please type age in numbers for person number " + i + ": ");
                input = Console.ReadLine();

                while (!int.TryParse(input, out age))
                {
                    Console.WriteLine("Not a valid number, try again.");
                    input = Console.ReadLine();
                }

                //The price gets summed depeding on the ages of the people
                if (age < 5 || age > 100)
                {
                    Console.WriteLine("+0kr");
                }
                else if (age < 20)
                {
                    Console.WriteLine("+80 kr");
                    price += 80;
                }
                else if (age > 64)
                {
                    Console.WriteLine("+90 kr");
                    price += 90;
                }
                else
                {
                    Console.WriteLine("+120 kr");
                    price += 120;
                }
            }
            //Console prints out the number of people and the total price
            Console.WriteLine("Total people: " + nbrOfPersons);
            Console.WriteLine("Total price is: " + price);
            break;

        case "3":
            string word;
            string input2 = "";
            //User typing 10 different words
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Type anything you want: ");
                word = Console.ReadLine();
                //Program only acccepts not null values
                while (string.IsNullOrEmpty(word)) {
                    Console.WriteLine("Type not valid, try again");
                    word = Console.ReadLine();
                }
                //input from user gets stored in input2 and is beign appended with another user input. 
                input2 += "input " + i + ": " + word + " ";
            }
            //Console prints out the 10 inputs from user
            Console.WriteLine(input2);
            break;

        case "4":
            Console.WriteLine("Write a sentence with three words");
            input = Console.ReadLine();

            //The input is only accepted if the string value contains three different words, having a space between them
            while (input.Split(' ').Length != 3)
            {
                Console.WriteLine("Type not valid, try again");
                input = Console.ReadLine();
            }
            //The string from user input gets splitted and stored into array
            string[] words = input.Split(" ");
            //Prints out the third word
            Console.WriteLine("The third word is: " + words[2].ToString());

            break;
        //If the user types an incorrect value, inform them. 
        default:
            Console.WriteLine("Invalid choice. Type the correct value.");
            break;
    }
}


