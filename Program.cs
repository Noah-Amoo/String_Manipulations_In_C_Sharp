using System.Text;

//          MOVE FIRST CHARACTER IN EACH WORD TO THE LAST
//  This code moves the very first character of each word in the string to the last.
//  For example "noah" becomes "oahn". It utilizes nested for loop and a String
//  Builder can be very useful here as well in place of string concantenatinon.
string Sentence = "My name is Noah Amoo and I love coding so much";
var splitSentence = Sentence.Split(' ');
var newWord = string.Empty;

Console.WriteLine("EXAMPLE 1:");
Console.WriteLine($"Sentence: {Sentence}");
for (int i = 0; i < splitSentence.Length; ++i)
{
    var word = splitSentence[i];
    for (int j = 1; j < word.Length; ++j)
    {
        newWord += word[j];
    }
    newWord += word[0] + " ";
}
var newSentence = string.Join(" ", newWord);
Console.Write("Output:   ");
Console.WriteLine(newSentence);

Console.WriteLine();
Console.WriteLine();

//          REVERSE STRING
//  This code reverses a string. That is wording the string in the opposite direction.
//  This is important if you want to check if a word is a Palindrome. You will need an
//  if statement in this case to establish that the word itself is the same as the reversed.
var noah = "noahamoo";
var reverse = string.Empty;
Console.WriteLine("EXAMPLE 2");
Console.WriteLine($"Unreversed Word: {noah}");
for (int i = noah.Length - 1; i >= 0; --i)
{
    reverse += noah[i];
}
Console.WriteLine($"Reversed Word: \t {reverse}");

Console.WriteLine();
Console.WriteLine();

//           ADD THE NEXT CHARACTER IN THE STRING
//  This code adds the next character in the string at a time. It utilizes the String Buildier
//  and shows how one of its methods, the Append method, can be used. To use the String Builder,
//  we needed to call "using System.Text" in line 1.
var wordToTest = "noah";
Console.WriteLine("EXAMPLE 3");
Console.WriteLine($"Word: {wordToTest}");
Console.Write($"Output: ");
for (int i = 0; i < wordToTest.Length; i++)
{
    StringBuilder sb = new StringBuilder();
    for (int j = i; j < wordToTest.Length; j++)
    {
        sb.Append(wordToTest[j]);
        Console.Write(sb.ToString());
        Console.Write(' ');
    }

}
Console.WriteLine();
Console.WriteLine();

//          PRINT OUT ITEMS IN AN ARRAY
//This code snippet shows us how to output the items in an array on a single line using the join method.
var myArray = new int[5] { 4, 6, 8, 11, 20 };
Console.WriteLine("EXAMPLE 4");
Console.WriteLine("This example outputs the various items in an array on a single line.");
Console.WriteLine(string.Join(" ", myArray));

Console.WriteLine();
Console.WriteLine();

//          ITERATE THROUGH SUBSEQUENT CHARACTERS WITH AN INITIAL CHARACTER
//  This block of code takes an initial character of the string and attaches the subsequent
//  characters to it one at a time. A String Builder, however, is the best alternative to  
//  append the characters to the iterateChars variable.
string charInput = "abcdefgh";
string iterateChars = string.Empty;

Console.WriteLine("EXAMPLE 5");
Console.Write($"Uniterated Characters: {charInput}");
Console.WriteLine() ;
Console.Write("Iterated Characters: ");
for (int i = 0; i < charInput.Length; i++)
{
    iterateChars += charInput[i];
    Console.Write(iterateChars + " ");
}

Console.WriteLine();
Console.WriteLine();

//          SKIP THE NEXT CHARACTER IN STRING
//  The code below skips the next character in the string. For instance the string "abcdefgh"
//  will output "ac bd ce df eg fh". It utilizes a nested for loop and the break keyword to
//  ensure that the inner loop is exited from immediately after the next character is printed.
var skipCharInput = "abcdefghijklmn";
Console.WriteLine("EXAMPLE 6");
Console.Write($"Character Inputs: {skipCharInput}");
Console.WriteLine();
Console.Write("Output: ");
for (int i = 0; i < skipCharInput.Length / 2 + i; i++)
{
    for (int j = i + 2; j < skipCharInput.Length; j++)
    {
        Console.Write($"{skipCharInput[i]}{skipCharInput[j]} ");
        break;
    }
}

Console.WriteLine();
Console.ReadLine();