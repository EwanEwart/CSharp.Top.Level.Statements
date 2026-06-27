/* 
 * https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/top-level-statements
 * 
 * Build dotnet answer machine
 */

//using System.Diagnostics;
//using System.Threading.Tasks;

Console.WriteLine();
Console.WriteLine(args); // prints: System.String[]
                         // enumerate the args array: string[] args
                         // echoing the question
foreach (var arg in args)
{
    Console.Write($"{arg} ");
    //Trace.WriteLine(arg);
}
Console.WriteLine();

// thinking animation ...
for (int i = 0; i < 20; i++)
{
    Console.Write("| -");
    await Task.Delay(50);
    Console.Write("\b\b\b");

    Console.Write("/ \\");
    await Task.Delay(50);
    Console.Write("\b\b\b");

    Console.Write("- |");
    await Task.Delay(50);
    Console.Write("\b\b\b");

    Console.Write("\\ /");
    await Task.Delay(50);
    Console.Write("\b\b\b");
}

Console.WriteLine();
string[] answers =
[
    "It is certain.",       "Reply hazy, try again.",     "Don’t count on it.",
    "It is decidedly so.",  "Ask again later.",           "My reply is no.",
    "Without a doubt.",     "Better not tell you now.",   "My sources say no.",
    "Yes – definitely.",    "Cannot predict now.",        "Outlook not so good.",
    "You may rely on it.",  "Concentrate and ask again.", "Very doubtful.",
    "As I see it, yes.",
    "Most likely.",
    "Outlook good.",
    "Yes.",
    "Signs point to yes.",
];
int index = new Random().Next(answers.Length - 1); // random index
Console.WriteLine(answers[index]); // answer to console

