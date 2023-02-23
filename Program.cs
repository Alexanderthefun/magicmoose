using System;

Main();

void Main()
{
    Console.WriteLine("Ask me a question, I dare you.");
    string question;
    do
    {
        question = Console.ReadLine();
        if (question.Length > 0)
        {
        MooseSays();
        }
    } while (question.Length > 0);
    

    
}

void MooseSays()
{
    string[] answers = {"As I see it, yes.", "Ask again later", "Better not to tell you now", "Cannot Predit now", "Concentrate and ask again", "Don't count on it.", "It is certain", "It is decidedly so", "Most Likely", "My reply is no.", "My sources say no.", "Outlook not so good", "Outlook good", "Reply hazy, try again", "Signs point to yes.", "Very Doubtful", "Without a doubt", "Yes.", "Yes - Definitely", "You may rely on it"};
    Random r = new Random();
    int answer = r.Next(0,19);

    Console.WriteLine(answers[answer]);
}


// using System;

// Main();

// void Main()
// {
//     Console.WriteLine("Ask me a question, I dare you.");
//     string question = Console.ReadLine();
//     do {
//         MooseSays();
//     } while (question.Length > 0);
    

    
// }

// void MooseSays()
// {
//     string[] answers = {"As I see it, yes.", "Ask again later", "Better not to tell you now", "Cannot Predit now", "Concentrate and ask again", "Don't count on it.", "It is certain", "It is decidedly so", "Most Likely", "My reply is no.", "My sources say no.", "Outlook not so good", "Outlook good", "Reply hazy, try again", "Signs point to yes.", "Very Doubtful", "Without a doubt", "Yes.", "Yes - Definitely", "You may rely on it"};
//     Random r = new Random();
//     int answer = r.Next(0,19);

//     Console.WriteLine(answers[answer]);
// }