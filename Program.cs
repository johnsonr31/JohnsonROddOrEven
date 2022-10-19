Console.Clear();

bool playAgain = true;
bool isNum;
int num;
int validNum;

while(playAgain == true)
{
    // The user will be asked to input either YES or NO to either begin or end the program
    Console.WriteLine("Would you like to know if a number is odd or even?");
    Console.Write("YES or NO: ");
    // The user's input will be taken and saved as a string called "yesNo"
    string yesNo = Console.ReadLine();
    // The input will be converted to uppercase, and validated to see if it is text or a whole number
    yesNo = yesNo.ToUpper();
    isNum = Int32.TryParse(yesNo, out num);
        if(yesNo == "NO" && isNum != true)
        {
            // If the user types NO, the program will print the text below to the console and end the while loop
            Console.WriteLine("Then goodbye");
            playAgain = false;
        }
        else if(yesNo == "YES" && isNum != true)
        {
            // If the user types YES, the program will ask them to input a whole number
            Console.Write("Please input a whole number: ");
            // The user's input will be saved as a string called "userInput"
            string userInput = Console.ReadLine();
            // The input will be validated as a whole number
            isNum = Int32.TryParse(userInput, out validNum);
                if(validNum % 2 == 0 && isNum == true)
                {
                    // If the number has a remainder of two, it is even
                    Console.WriteLine($"{validNum} is an even number.");
                    Console.WriteLine(" ");
                }
                else if(validNum %2 != 0 && isNum == true)
                {
                    // If the number doesn't have a remainder of two, it is odd
                    Console.WriteLine($"{validNum} is an odd number.");
                }
                else
                {
                    // If the user input isn't a whole number, this will print
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine(" ");
                }
        }
        else
        {
            // If the user types a whole number or anything else aside from YES or NO, this will print
            Console.WriteLine("Invalid Input.");
            Console.WriteLine(" ");
        }
}