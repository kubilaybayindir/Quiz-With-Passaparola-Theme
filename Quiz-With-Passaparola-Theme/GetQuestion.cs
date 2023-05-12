using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_With_Passaparola_Theme
{
    public class GetQuestionAndAnswer
    {

        public string GetQue(char alphabet)
        {
            Random random = new Random();
            int cnt=random.Next(1,4);

            switch (alphabet)
            {
                case 'A':
                    switch (cnt)
                    {
                        case 1:
                            return "Which car manufacturer’s badge features a cross and a snake?"; // Alfa Romeo
                        case 2:
                            return "Ar is the chemical symbol for which element?"; //Argon
                        case 3:
                            return "In which country would you find the Sydney Opera House?"; //Australia
                        default:
                            return "Question not valid";
                    }
                case 'B':
                    switch (cnt)
                    {
                        case 1:
                            return "What is the tallest building in the world?"; // Burj Khalifa
                        case 2:
                            return "Which sea borders the north of Turkey?"; //Black Sea
                        case 3:
                            return "Digbeth and Edgbaston are suburbs of which British city?"; // Birmingham
                        default:
                            return "Question not valid";
                    }
                case 'C':
                    switch (cnt)
                    {
                        case 1:
                            return "Alastair Cook plays which sport?"; // Cricket  
                        case 2:
                            return "In Greek mythology, who was the father of Zeus?"; // Cronus   
                        case 3:
                            return "What breed of dog did Queen Elizabeth II famously own?"; //Corgis
                        default:
                            return "Question not valid";
                    }
                case 'D':
                    switch (cnt)
                    {
                        case 1:
                            return "What is the currency of Denmark?"; // Danish Krone   
                        case 2: 
                            return "What is the national flower of Wales?"; // Daffodil
                        case 3:
                            return "What was Miley Cyrus' birth name?"; //Destiny Hope Cyrus
                        default:
                            return "Question not valid";
                    }
                case 'E':
                    switch (cnt)
                    {
                        case 1:
                            return "An optometrist specialises in treating which part of the human body?"; // Eyes   
                        case 2:
                            return "Who was the head of state in Japan during the second world war?"; // Emperor Hirohito
                        case 3:
                            return "Who won 2021's Sports Personality of the Year?"; //Emma Raducanu
                        default:
                            return "Question not valid";
                    }
                case 'F':
                    switch (cnt)
                    {
                        case 1:
                            return "How many horses are on each team in a polo match?"; // Four
                        case 2:
                            return "Name the actor who plays the role of Mike Wheeler in Stranger Things."; // Finn Wolfhard
                        case 3:
                            return "What sport did David Beckham play?"; //Football
                        default:
                            return "Question not valid";
                    }
                case 'G':
                    switch (cnt)
                    {
                        case 1:
                            return "The former showrunners of which mega TV series reportedly walked away from a planned Star Wars trilogy?"; // Game of Thrones   
                        case 2:
                            return "Carl Froch defeated which opponent at Wembley in 2014?"; // George Groves
                        case 3:
                            return "What is the slang name for New York City, used by locals?"; //Gotham
                        default:
                            return "Question not valid";
                    }
                case 'H':
                    switch (cnt)
                    {
                        case 1:
                            return "Name the best-selling book series of the 21st century? "; // Harry Potter  
                        case 2:
                            return "In which state was former US President Barack Obama born?"; // Hawaii
                        case 3:
                            return "Name the composer behind the soundtracks of The Lion King, Inception and Pirates of the Caribbean?"; //Hanz Zimmer
                        default:
                            return "Question not valid";
                    }
                case 'I':
                    switch (cnt)
                    {
                        case 1:
                            return "What is the name of the main antagonist in the Shakespeare play Othello?"; // Iago   
                        case 2:
                            return "Which soft drink is commonly associated with Scotland?"; // Irn-Bru
                        case 3:
                            return "In 1952 Albert Einstein was offered the Presidency of which country?"; //Israel
                        default:
                            return "Question not valid";
                    }
                case 'J':
                    switch (cnt)
                    {
                        case 1:
                            return "Which of these actors has not made a cameo on Friends: Reese Witherspoon, Julianne Moore, or George Clooney?"; // Julianne Moore 
                        case 2:
                            return "What's the name of Andy Murray's tennis playing brother?"; // Jamie Murray
                        case 3:
                            return "Who founded Amazon?"; //Jeff Bezos
                        default:
                            return "Question not valid";
                    }
                case 'K':
                    switch (cnt)
                    {
                        case 1:
                            return "In Greek mythology, who was the father of Zeus?"; // Kronos
                        case 2:
                            return "What does KFC stand for?"; // Kentucky Fried Chicken
                        case 3:
                            return "Who had hits with ‘Firework’ and ‘I Kissed a Girl’?"; //Katy Perry
                        default:
                            return "Question not valid";
                    }
                case 'L':
                    switch (cnt)
                    {
                        case 1:
                            return "Jimmy Page formed which rock band?"; // Led Zeppelin 
                        case 2:
                            return "What is zero points in tennis known as?"; // Love
                        case 3:
                            return "What city do The Beatles come from?"; //Liverpool
                        default:
                            return "Question not valid";
                    }
                case 'M':
                    switch (cnt)
                    {
                        case 1:
                            return "Which driver has won the most Formula 1 championships?"; // Michael Schumacher
                        case 2:
                            return "Which artist painted the ceiling of the Sistine Chapel in Rome?"; // Michelangelo
                        case 3:
                            return "Who gave the famous speech “I Have a Dream”?"; //Martin Luther
                        default:
                            return "Question not valid";
                    }
                case 'N':
                    switch (cnt)
                    {
                        case 1:
                            return "Which southern Italian city is usually credited as the birthplace of the pizza?"; // Naples
                        case 2:
                            return "What language is spoken in Norway?"; // Norwegian
                        case 3:
                            return "The Animals formed in which UK city?"; //Newcastle
                        default:
                            return "Question not valid";
                    }
                case 'O':
                    switch (cnt)
                    {
                        case 1:
                            return "What is the capital of Canada?"; // Ottawa
                        case 2:
                            return "How many white balls are used to play snooker?"; // One
                        case 3:
                            return "What element does 'O' represent on the periodic table?"; //Oxygen
                        default:
                            return "Question not valid";
                    }
                case 'P':
                    switch (cnt)
                    {
                        case 1:
                            return "Which TV show features Tommy Shelby, Alfie Solomons and Luca Changretta?"; // Peaky Blinders  
                        case 2:
                            return "What kind of word reads the same backwards and forwards?"; // Palindrome
                        case 3:
                            return "What is Batman’s butler called?"; //Pennyworth
                        default:
                            return "Question not valid";
                    }
                case 'Q':
                    switch (cnt)
                    {
                        case 1:
                            return "Who directed Kill Bill: Volume 1? "; // Quentin Tarantino
                        case 2:
                            return "Which band sang “Bohemian Rhapsody”? "; // Queen
                        case 3:
                            return "Which football club plays its home games at Loftus Road?"; //Queen's Park Rangers
                        default:
                            return "Question not valid";
                    }
                case 'R':
                    switch (cnt)
                    {
                        case 1:
                            return "Which colour pill does Neo swallow in The Matrix?"; // Red
                        case 2:
                            return "The capital of Iceland is?"; // Reykjavik
                        case 3:
                            return "In which city can you find the Colosseum?"; //Rome
                        default:
                            return "Question not valid";
                    }
                case 'S':
                    switch (cnt)
                    {
                        case 1:
                            return "Which actor played Rocky? "; // Sylvester Stallone 
                        case 2:
                            return "Which sport is Michael Phelps known for?"; // Swimming
                        case 3:
                            return "What Netflix show had the most streaming views in 2021?"; //Squid Game
                        default:
                            return "Question not valid";
                    }
                case 'T':
                    switch (cnt)
                    {
                        case 1:
                            return "Who played David Aames in Vanilla Sky?"; // Tom Cruise  
                        case 2:
                            return "What shape are Doritos?"; // Triangle
                        case 3:
                            return "Which character is often referred to with ‘Giantsbane’ in their name?"; //Tormund
                        default:
                            return "Question not valid";
                    }
                case 'U':
                    switch (cnt)
                    {
                        case 1:
                            return "What is the national animal of Scotland?"; // Unicorn  
                        case 2:
                            return "What does USB stand for?"; // Universal Serial Bus
                        case 3:
                            return "In what country is the Chernobyl nuclear plant located?"; //Ukraine
                        default:
                            return "Question not valid";
                    }
                case 'V':
                    switch (cnt)
                    {
                        case 1:
                            return "Where is Angel Falls, the world’s largest waterfall, located?"; // Venezuela
                        case 2:
                            return "What car manufacturer had the highest revenue in 2020?"; // Volkswagen
                        case 3:
                            return "Café Terrace at Night is an 1888 oil painting by which Dutch master?"; //Vincent Van Gogh
                        default:
                            return "Question not valid";
                    }
                case 'W':
                    switch (cnt)
                    {
                        case 1:
                            return "What is the capital of New Zealand?"; // Wellington
                        case 2:
                            return "What’s the name of the cowboy in Toy Story?"; // Woody
                        case 3:
                            return "What happened between 1914 and 1919?"; // World War 1
                        default:
                            return "Question not valid";
                    }
                case 'X':
                    switch (cnt)
                    {
                        case 1:
                            return "x"; // x
                        case 2:
                            return "x"; // x
                        case 3:
                            return "x"; // x
                        default:
                            return "Question not valid";
                    }
                case 'Y':
                    switch (cnt)
                    {
                        case 1:
                            return "Aureolin is a shade of what color?"; // Yellow
                        case 2:
                            return "Aureolin is a shade of what color?"; // Yellow
                        case 3:
                            return "Aureolin is a shade of what color?"; // Yellow
                        default:
                            return "Question not valid";
                    }
                case 'Z':
                    switch (cnt)
                    {
                        case 1:
                            return "What is YouTuber Zoella's real name?"; // Zoe Sugg
                        case 2:
                            return "What is YouTuber Zoella's real name?"; // Zoe Sugg
                        case 3:
                            return "What is YouTuber Zoella's real name?"; // Zoe Sugg
                        default:
                            return "Question not valid";
                    }
                default:
                    return "Question not valid";
            }
        }
        public string[] GetAnswer(char alphabet)
        {
            Random random = new Random();
            string[] answers;
            switch (alphabet)
            {
                case 'A':
                    return answers =new string[] { "Alfa Romeo", "Argon", "Australia", "Answer not valid" };
                case 'B':
                    return answers = new string[] { "Burj Khalifa", "Black Sea", "Birmingham", "Answer not valid" };
                case 'C':
                    return answers = new string[] { "Cricket", "Cronus", "Corgis", "Answer not valid" };
                case 'D':
                    return answers = new string[] { "Danish Krone", "Daffodil", "Destiny Hope Cyrus", "Answer not valid" };
                case 'E':
                    return answers = new string[] { "Eyes", "Emperor Hirohito", "Emma Raducanu", "Answer not valid" };
                case 'F':
                    return answers = new string[] { "Four", "Finn Wolfhard", "Football", "Answer not valid" };
                case 'G':
                    return answers = new string[] { "Game of Thrones", "George Groves", "Gotham", "Answer not valid" };
                case 'H':
                    return answers = new string[] { "Harry Potter", "Hawaii", "Hanz Zimmer", "Answer not valid" };
                case 'I':
                    return answers = new string[] { "Iago", "Irn-Bru", "Israel", "Answer not valid" };
                case 'J':
                    return answers = new string[] { "Julianne Moore", "Jamie Murray", "Jeff Bezos", "Answer not valid" };
                case 'K':
                    return answers = new string[] { "Kronos", "Kentucky Fried Chicken", "Katy Perry", "Answer not valid" };
                case 'L':
                    return answers = new string[] { "Led Zeppelin ", "Love", "Liverpool", "Answer not valid" };
                case 'M':
                    return answers = new string[] { "Michael Schumacher", "Michelangelo", "Martin Luther", "Answer not valid" };
                case 'N':
                    return answers = new string[] { "Naples", "Norwegian", "Newcastle", "Answer not valid" };
                case 'O':
                    return answers = new string[] { "Ottawa", "One", "Oxygen", "Answer not valid" };
                case 'P':
                    return answers = new string[] { "Peaky Blinders", "Palindrome", "Pennyworth", "Answer not valid" };
                case 'Q':
                    return answers = new string[] { "Quentin Tarantino", "Queen", "Queen's Park Rangers", "Answer not valid" };
                case 'R':
                    return answers = new string[] { "Red", "Reykjavik", "Rome", "Answer not valid" };
                case 'S':
                    return answers = new string[] { "Sylvester Stallone", "Swimming", "Squid Game", "Answer not valid" };
                case 'T':
                    return answers = new string[] { "Tom Cruise", "Triangle", "Tormund", "Answer not valid" };
                case 'U':
                    return answers = new string[] { "Unicorn", "Universal Serial Bus", "Ukraine", "Answer not valid" };
                case 'V':
                    return answers = new string[] { "Venezuela", "Volkswagen", "Vincent Van Gogh", "Answer not valid" };
                case 'W':
                    return answers = new string[] { "Wellington", "Woody", "World War 1", "Answer not valid" };
                case 'X':
                    return answers = new string[] { "x", "x", "x", "Answer not valid" };
                case 'Y':
                    return answers = new string[] { "Yellow", "Yellow", "Yellow", "Answer not valid" };
                case 'Z':
                    return answers = new string[] { "Zoe Sugg", "Zoe Sugg", "Zoe Sugg", "Answer not valid" };
                default:
                    return answers = new string[] {"Answer not valid" };
            }
        }
    }
}
