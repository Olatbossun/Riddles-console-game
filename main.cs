using System;

class Program {
  public static void Main (string[] args) {
    // See https://aka.ms/new-console-template for more information

Console.WriteLine("RIDDLES GAME");
Console.WriteLine("Guess the correct answer to the riddles\n");
Console.WriteLine("All correct answers carry 5 points, wrong answers carry no point");
Console.WriteLine("There are 20 riddles in total");
Console.WriteLine("All answers should be in lower case\n");
Console.Write("Press enter key to start and continue to the next question\n\n");
Console.ReadLine();

//question 1 
Console.WriteLine("NO 1 - What belongs to you but your friends use it more?");
Console.Write("Answer: ");
string answer = Console.ReadLine();
double score = 0;
switch (answer)
{
    case "name":
        {
            score += 5;
            break;
        }
    case "my name":
        {
            score += 5;
            break;
        }
    case "your name":
        {
            score += 5;
            break;
        }
    default:
        score += 0;
        break;
        
}
Console.WriteLine("score: {0} ", score);
Console.WriteLine("Total score: {0}", score);
Console.ReadLine();

//question 2
Console.WriteLine("NO 2 - What kind of tree can you carry in your hand?");
Console.Write("Answer: ");
string answer1 = Console.ReadLine();
double score1 = 0;
switch (answer1)
{
    case "palm tree":
        {
            score1 += 5;
            break;
        }
case "a palm tree":
        {
            score1 += 5;
            break;
        }
  case "palmtree":
        {
            score1 += 5;
            break;
        }
    case "palm":
        {
            score1 += 5;
            break;
        }
    default:
        score1 += 0;
        break;

}
score += score1;
Console.WriteLine("score: {0}", score1);
Console.WriteLine("Total score: {0}", score);
Console.ReadLine();

//question 3
Console.WriteLine("NO 3 - I am simple that i can only point, yet i guide people people all over the world?");
//Console.WriteLine("All answer should be in lower case");
Console.Write("Answer: ");
string answer2 = Console.ReadLine();
double score2 = 0;
switch (answer2)
{
    case "compass":
        {
            score2 += 5;
            break;
        }
    case "the compass":
        {
            score2 += 5;
            break;
        }
    case "a compass":
        {
            score2 += 5;
            break;
        }
  
    default:
        score2 += 0;
        break;
}
score += score2;
Console.WriteLine("Score: {0} ", score2);
Console.WriteLine("Total score: {0}", score);
Console.ReadLine();

//question 4
Console.WriteLine("NO 4 - How do you make the number one disappear?");
Console.Write("Answer: ");
string answer3 = Console.ReadLine();
double score3 = 0;
switch (answer3)
{
    case "by adding g":
        {
            score3 += 5;
            break;
        }
case "by adding letter g":
        {
            score3 += 5;
            break;
        }
case "add letter g":
        {
            score3 += 5;
            break;
        }
    case "add g":
        {
            score3 += 5;
            break;
        }
    default:
        score3 += 0;
        break;

}
score += score3;
Console.WriteLine("Score: {0} ", score3);
Console.WriteLine("Total score: {0}", score);
Console.ReadLine();

//question 5
Console.WriteLine("NO 5 - What gets wetter and wetter the more it dries");
Console.Write("Answer: ");
string answer4 = Console.ReadLine();
double score4 = 0;

switch (answer4)
{
    case "a towel":
        {
            score4 += 5;
            break;
        }
    case "towel":
        {
            score4 += 5;
            break;
        }
    default:
        score4 += 0;
        break;

}
score += score4;
Console.WriteLine("Score: {0} ", score4);
Console.WriteLine("Total score: {0}", score);
Console.ReadLine();

//question 6
Console.WriteLine("NO 6 - You see it once in june, three times in september and never in may, what is it");
Console.Write("Answer: ");
string answer5 = Console.ReadLine();
double score5 = 0;

switch (answer5)
{
    case "letter e":
        {
            score5 += 5;
            break;
        }
    case "the letter e":
        {
            score5 += 5;
            break;
        }
    case "e":
        {
            score5 += 5;
            break;
        }
    default:
        score5 += 0;
        break;

}
score += score5;
Console.WriteLine("Score: {0} ", score5);
Console.WriteLine("Total score: {0}", score);
Console.ReadLine();


//question 7
Console.WriteLine("NO 7 - What has thirteen hearts, but no other organs?");
Console.Write("Answer: ");
string answer6 = Console.ReadLine();
double score6 = 0;
switch (answer6)
{
    case "deck of cards":
        {
            score6 += 5;
            break;
        }
    case "a deck of cards":
        {
            score6 += 5;
            break;
        }
    case "deck of card":
        {
            score6 += 5;
            break;
        }
case "a deck of card":
        {
            score6 += 5;
            break;
        }
    
    default:
        score6 += 0;
        break;

}
score += score6;
Console.WriteLine("Score: {0} ", score6);
Console.WriteLine("Total score: {0}", score);
Console.ReadLine();

//question 8
Console.WriteLine("NO 8 - I am taller when i'm young, shorter when i'm old. What am I?");
Console.Write("Answer: ");
string answer7 = Console.ReadLine();
double score7 = 0;

switch (answer7)
{
    case "candle":
        {
            score7 += 5;
            break;
        }
    case "a candle":
        {
            score7 += 5;
            break;
        }
    case "candlestick":
        {
            score7 += 5;
            break;
        }
case "a candlestick":
        {
            score7 += 5;
            break;
        }
    default:
        score7 += 0;
        break;

}
score += score7;
Console.WriteLine("Score: {0} ", score7);
Console.WriteLine("Total score: {0}", score);
Console.ReadLine();

//question 9
Console.WriteLine("NO 9 - I make a loud sound when i'm changing, and i get bigger but weigh less. what am i?");
Console.Write("Answer: ");
string answer8 = Console.ReadLine();
double score8 = 0;
switch (answer8)
{
    case "popcorn":
        {
            score8 += 5;
            break;
        }
    case "pop-corn":
        {
            score8 += 5;
            break;
        }
    default:
        score8 += 0;
        break;

}
score += score8;
Console.WriteLine("Score: {0} ", score8);
Console.WriteLine("Total score: {0}", score);
Console.ReadLine();

//question 10
Console.WriteLine("NO 10 - What question can you never answer yes to?");
Console.Write("Answer: ");
string answer9 = Console.ReadLine();
double score9 = 0;
switch (answer9)
{
    case "asleep yet?":
        {
            score9 += 5;
            break;
        }
    case "are you asleep yet?":
        {
            score9 += 5;
            break;
        }
case "are you sleeping?":
        {
            score9 += 5;
            break;
        }
  case "are you asleep?":
        {
            score9 += 5;
            break;
        }
    default:
        score9 += 0;
        break;

}
score += score9;
Console.WriteLine("Score: {0} ", score9);
Console.WriteLine("Total score: {0}", score);
Console.ReadLine();

//question 11 
Console.WriteLine("NO 11 - What is easier to get into than out of?");
Console.Write("Answer: ");
string answer10 = Console.ReadLine();
double score10 = 0;

switch (answer10)
{
    case "trouble":
        {
            score10 += 5;
            break;
        }
    case "problem":
        {
            score10 += 5;
            break;
        }
    default:
        score10 += 0;
        break;

}
score += score10;
Console.WriteLine("Score: {0} ", score10);
Console.WriteLine("Total score: {0}", score);
Console.ReadLine();

//question 12
Console.WriteLine("NO 12 - Where does Thursdays come after Fridays?");
Console.Write("Answer: ");
string answer11 = Console.ReadLine();
double score11 = 0;

switch (answer11)
{
    case "dictionary":
        {
            score11 += 5;
            break;
        }
    case "the dictionary":
        {
            score11 += 5;
            break;
        }
case "in the dictionary":
        {
            score11 += 5;
            break;
        }
    default:
        score11 += 0;
        break;

}
score += score11;
Console.WriteLine("Score: {0} ", score11);
Console.WriteLine("Total score: {0}", score);
Console.ReadLine();


//question 13
Console.WriteLine("NO 13 - The more you take, the more you leave behind, what are they?");
Console.Write("Answer: ");
string answer12 = Console.ReadLine();
double score12 = 0;

switch (answer12)
{
    case "footsteps":
        {
            score12 += 5;
            break;
        }
    case "your footsteps":
        {
            score12 += 5;
            break;
        }
    default:
        score12 += 0;
        break;

}
score += score12;
Console.WriteLine("Score: {0} ", score12);
Console.WriteLine("Total score: {0}", score);
Console.ReadLine();

//question 14
Console.WriteLine("NO 14  - Remove my skin and i won't cry but you might, what am i?");
Console.Write("Answer: ");
string answer13 = Console.ReadLine();
double score13 = 0;

switch (answer13)
{
    case "onions":
        {
            score13 += 5;
            break;
        }
    case "onion":
        {
            score13 += 5;
            break;
        }
case "an onion":
        {
            score13 += 5;
            break;
        }
    default:
        score13 += 0;
        break;

}
score += score13;
Console.WriteLine("Score: {0} ", score13);
Console.WriteLine("Total score: {0}", score);
Console.ReadLine();

//question 15
Console.WriteLine("NO 15  - I am lighter than a feather, but not even the world strongest man can hold me for much longer than five minutes?");
Console.Write("Answer: ");
string answer14 = Console.ReadLine();
double score14 = 0;

switch (answer14)
{
    case "your breath":
        {
            score14 += 5;
            break;
        }
    case "breath":
        {
            score14 += 5;
            break;
        }
    default:
        score14 += 0;
        break;

}
score += score14; 
Console.WriteLine("Score: {0} ", score14);
Console.WriteLine("Total score: {0}", score);
Console.ReadLine();

//question 16
Console.WriteLine("NO 16  - What goes up but never goes down?");
Console.Write("Answer: ");
string answer15 = Console.ReadLine();
double score15 = 0;

switch (answer15)
{
    case "your age":
        {
            score15 += 5;
            break;
        }
    case "age":
        {
            score15 += 5;
            break;
        }
    default:
        score15 += 0;
        break;

}
score += score15;
Console.WriteLine("Score: {0} ", score15);
Console.WriteLine("Total score: {0}", score);
Console.ReadLine();

//question 17
Console.WriteLine("NO 17  - I start with a “p” and ends with “o-r-n,” and I’m a major player in the film industry. What am I?");
Console.Write("Answer: ");
string answer16 = Console.ReadLine();
double score16 = 0;

switch (answer16)
{
    case "popcorn":
        {
            score16 += 5;
            break;
        }
    case "pop-corn":
        {
            score16 += 5;
            break;
        }
    default:
        score16 += 0;
        break;

}
score += score16;
Console.WriteLine("Score: {0} ", score16);
Console.WriteLine("Total score: {0}", score);
Console.ReadLine();


//question 18
Console.WriteLine("NO 18  - Some people prefer being on top, others prefer being on the bottom, and it always involves a bed. What am I?");
Console.Write("Answer: ");
string answer17 = Console.ReadLine();
double score17 = 0;

switch (answer17)
{
    case "bunk bed":
        {
            score17 += 5;
            break;
        }
    case "a bunk bed":
        {
            score17 += 5;
            break;
        }
    case "bunk-bed":
        {
            score17 += 5;
            break;
        }

    default:
        score17 += 0;
        break;

}
score += score17;
Console.WriteLine("Score: {0} ", score17);
Console.WriteLine("Total score: {0}", score);
Console.ReadLine();

//question 19
Console.WriteLine("NO 19 -  David’s father has three sons: Snap, Crackle and...?");
Console.Write("Answer: ");
string answer18 = Console.ReadLine();
double score18 = 0;

switch (answer18)
{
    case "david":
        {
            score18 += 5;
            break;
        }
    default:
        score18 += 0;
        break;

}
score += score18;
Console.WriteLine("Score: {0} ", score18);
Console.WriteLine("Total score: {0}", score);
Console.ReadLine();

//question 20
Console.WriteLine("NO 20  - How many letters are in \"the alphabet\"?");
Console.Write("Answer: ");
string answer19 = Console.ReadLine();
double score19 = 0;

switch (answer19)
{
    case "11 letters":
        {
            score19 += 5;
            break;
        }
    case "eleven":
        {
            score19 += 5;
            break;
        }
    case "11":
        {
            score19 += 5;
            break;
        }
    case "eleven letters":
        {
            score19 += 5;
            break;
        }


    default:
        score19 += 0;
        break;

}
score += score19;
Console.WriteLine("Score: {0} ", score19);
Console.WriteLine("Total score: {0}", score);
Console.ReadLine();







Console.WriteLine("You have reach the end of the riddles!!");
Console.WriteLine("Your Total score = {0} ", score);
Console.WriteLine("Bye");

  }
}