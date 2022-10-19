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
    string yesNo = Console.ReadLine();
    yesNo = yesNo.ToUpper();
    isNum = Int32.TryParse(yesNo, out num);
        if(yesNo == "NO" && isNum != true)
        {
            // If the user types NO, the program will print the text below to the console and end the while loop
            Console.WriteLine("Then goodbye");
            playAgain = false;
        }
        else if(yesNo == "NO" && isNum != true)
        {
            // If the user types YES, the program will ask them to input a number
            Console.Write("Please input a whole number: ");
            string userInput = Console.ReadLine();
            isNum = Int32.TryParse(userInput, out validNum);
                if(validNum % 2 == 0)
                {
                    // If the number has a remainder of two, it is even
                    Console.WriteLine($"{validNum} is an even number.");
                    Console.WriteLine(" ");
                }
                else
                {
                    // If the number doesn't have a remainder of two, it is odd
                    Console.WriteLine($"{validNum} is an odd number.");
                }
        }
        else
        {
            Console.WriteLine("Invalid Input.");
            Console.WriteLine(" ");
        }
}