using System.Text;

// select a random number between 1 and 20
int number = new Random().Next(1, 21);

// ask the user to guess a number
Console.WriteLine("I'm thinking of a number between 1 and 20. Can you guess what it is?");
int userGuess = int.Parse(Console.ReadLine());

// give the user three guesses; if the user guessed incorrect, show it the correct number is smaller or larger
for (int i = 0; i < 2; i++)
{
    if (userGuess == number)
    {
        Console.WriteLine("You guessed correctly!");
        break;
    }
    else if (userGuess < number)
    {
        Console.WriteLine("Your guess is too low.");
    }
    else if (userGuess > number)
    {
        Console.WriteLine("Your guess is too high.");
    }

    Console.WriteLine("Guess again.");
    userGuess = int.Parse(Console.ReadLine());
}

// if the user guessed correctly, ask for the user name and save the score to a file on disk; use FileStream class
if (userGuess == number)
{
    Console.WriteLine("What is your name?");
    string userName = Console.ReadLine();

    string path = @"C:\Users\Public\Documents\score.txt";
    string score = $"{userName} guessed the number {number} correctly.";

    using (FileStream fs = File.Create(path))
    {
        byte[] info = new UTF8Encoding(true).GetBytes(score);
        fs.Write(info, 0, info.Length);
    }
}
else
{
    Console.WriteLine($"You didn't guess correctly. The correct number was {number}.");
}