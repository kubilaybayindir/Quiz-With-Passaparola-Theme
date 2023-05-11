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
                case 'P':
                    return answers = new string[] { "Peaky Blinders", "Palindrome", "Pennyworth", "Answer not valid" };
                default:
                    return answers = new string[] {"Answer not valid" };
            }
        }
    }
}
