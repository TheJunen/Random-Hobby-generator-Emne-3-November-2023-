// See https://aka.ms/new-console-template for more information
using static System.Net.Mime.MediaTypeNames;

var rand = new Random();
Console.WriteLine("Write your name to generate a new hobby");
string input = Console.ReadLine();
//char hobbies[5][20];
//strcpy(hobbies[0], "${input}:I spend my weekends painting landscapes and experimenting with vibrant colors.");
string[] hobbies = { $"Painting is {input} newest hobby! {input} spend their weekends painting landscapes and experimenting with vibrant colors", $"{input} Has now a new hobby! Practicing yoga helps {input} find balance and peace in the midst of a busy schedule.", $" {input} loves board games now!. Friday nights are reserved for board game gatherings with friends, where strategy and laughter go hand in hand.", $"{input} loves singing now! Whether in the shower or a local choir, singing is {input} way of expressing joy and emotion."};
var randomhobbyindex = rand.Next(hobbies.Length);
Console.WriteLine(hobbies[randomhobbyindex]);

Console.WriteLine("Write 1 to choose a new hobby, and write something else to quit the console");
string chooseAgain = Console.ReadLine();
if(chooseAgain == "1")
{
    Console.WriteLine(hobbies[rand.Next(hobbies.Length)]);
}
else
{
    Environment.Exit(0);
}

