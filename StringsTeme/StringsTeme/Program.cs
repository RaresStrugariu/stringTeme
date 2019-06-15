using System;
using System.Text;

namespace StringsTeme
{
   class Program
   {
      static void Main(string[] args)
      {
         

         RemoveIndex();
         //RemoveOddNumberCharacters();
         //TransformText();
         //ReverseAStringIfMultipleOf4();
         //ConvertToUpper();
         //RemovesNewLine();
         //FormattedTextOnLines();
         //FormatToPercentage();
         //ReverseAString();
         //StripsASetOfCharacters();
         //TransformToLower();
         //FirstAndLast();
         //SumOfDigits();
         //CleanTheText();
         //AddIngOrLy();
         //HideAdress();
         //FirstTwoLastTwo();
         //ChangeAllOccurences();
         //SwapLetters();
         //PoorAndBad();
         //ListOfWOrds();
         //LastPartBeforeCharacter();
         //StartWith();
         //SwapCommaAndDot();
         //RemoveWhiteSpaces();
         //Palindrome();
      }
      public static void RemoveIndex()
      {
         Console.WriteLine("Please insert a string");
         string str1 = Console.ReadLine();

         Console.WriteLine($"Please insert a number between 0 and {str1.Length}");
         int index1 = int.Parse(Console.ReadLine());

         string myStringChanged = str1.Remove(index1, 1);
         Console.WriteLine(myStringChanged);
      }
      public static void RemoveOddNumberCharacters()
      {

         Console.WriteLine("Please insert a string");
         string stringInserted = Console.ReadLine();
         string newString = "";
         for (int i = 0; i < stringInserted.Length; i++)
         {
            if (i % 2 == 0)
            {
               newString += stringInserted[i].ToString();
            }
         }
         Console.WriteLine(newString);
      }
      public static void TransformText()
      {
         Console.WriteLine("Please write a string");
         string stringInserted = Console.ReadLine();

         Console.WriteLine($"The string transformed to upper case : {stringInserted.ToUpper()}");
         Console.WriteLine($"The string transformed to lower case : {stringInserted.ToLower()}");
      }
      public static void ReverseAStringIfMultipleOf4()
      {
         Console.WriteLine("Please insert a string");
         string stringInserted = Console.ReadLine();

         if (stringInserted.Length % 4 == 0)
         {
            string stringReversed = string.Empty;
            for (int i = stringInserted.Length - 1; i >= 0; i--)
            {
               stringReversed += stringInserted[i];
            }
            Console.WriteLine(stringReversed);
         }
         else
         {
            Console.WriteLine("The string's length is not a multiple of 4.");
         }
      }
      public static void ConvertToUpper()
      {
         Console.WriteLine("Please insert a string with a minimum of 4 characters");
         string stringInserted = Console.ReadLine();

         int count = 0;

         for (int i = 0; i < 4; i++)
         {
            //Nu inteleg de ce nu ma lasa cu  if(stringInserted[i] == stringInserted[i].ToUpper())
            if (Char.IsUpper(stringInserted[i]))
            {
               count++;
            }
         }
         if (count >= 2)
         {
            Console.WriteLine(stringInserted.ToUpper());
         }
         else if (count < 2)
         {
            Console.WriteLine("The string can not be converted.");
         }
      }
      public static void RemovesNewLine()
      {
         string myString = "Ana\n are\n multe\n mere\n";
         Console.WriteLine(myString);
         //Cu Trim am vazut ca sterge characterul \n dar tot ia newline, nu stiu daca se pune.
         var sb = new StringBuilder();
         for (int i = 0; i < myString.Length; i++)
         {
            if (myString[i] != '\n')
            {
               sb.Append(myString[i]);
            }
         }
         myString = sb.ToString();
         Console.WriteLine(myString);
      }
      public static void FormattedTextOnLines()
      {
         string myText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras vitae risus consectetur,faucibus neque a, aliquet nibh.Praesent risus ipsum, sodales sed felis sed, dictum mattis magna.";
         var sb = new StringBuilder(myText.Length);

         for (int i = 0; i < myText.Length; i++)
         {
            sb.Append(myText[i]);
            if (i == 50)
            {
               sb.Append('\n');
               myText = myText.Remove(0, 50);
               i = 0;
            }
         }
         myText = sb.ToString();
         Console.WriteLine(myText);
      }
      public static void FormatToPercentage()
      {
         var number = 0.888;
         string s = number.ToString("P2");
         Console.WriteLine(s);
      }
      public static void ReverseAString()
      {
         string myString = "caracatita";
         Console.WriteLine(myString);
         var newStr = new StringBuilder();
         for (int i = myString.Length - 1; i >= 0; i--)
         {
            newStr.Append(myString[i]);
         }
         myString = newStr.ToString();
         Console.WriteLine(myString);
      }
      public static void StripsASetOfCharacters()
      {
         string myString = "write a method that strips a set of characters from a string.";
         Console.WriteLine(myString);
         Console.WriteLine("Please insert a set of characters");
         string set = Console.ReadLine();
         for (int i = 0; i < set.Length; i++)
         {
            myString = myString.Replace(set[i].ToString(), "");
         }
         Console.WriteLine(myString);
      }
      public static void TransformToLower()
      {
         string myString = "PREAfericit";
         Console.WriteLine(myString);

         Console.WriteLine($"Please insert a number between 0 and {myString.Length}");
         int num = int.Parse(Console.ReadLine());

         string firstChars = myString.Substring(0, num).ToLower();
         string remainingChars = myString.Remove(0, num);
         string finalStr = firstChars + remainingChars;
         Console.WriteLine(finalStr);


      }
      public static void FirstAndLast()
      {
         string myString = "Ana are multe mere.";
         Console.WriteLine(myString);
         string[] splitStr = myString.Split(' ', '.');

         var sb = new StringBuilder();

         for (int i = 0; i < splitStr.Length; i++)
         {
            for (int g = 0; g < splitStr[i].Length; g++)
            {
               if (g == 0 || g == splitStr[i].Length - 1)
               {
                  sb.Append(Char.ToUpper(splitStr[i][g]));
               }
               else
               {
                  sb.Append(splitStr[i][g]);
               }

            }
            sb.Append(" ");
         }

         myString = sb.ToString();
         myString = myString + ".";
         //Nu stiu de ce imi lasa spatiu intre ultimul cuvant si punct.
         Console.WriteLine(myString);
      }
      public static void SumOfDigits()
      {
         string myString = "123Alaba09la542Ala31B";
         Console.WriteLine(myString);
         int sum = 0;
         for (int i = 0; i < myString.Length; i++)
         {
            if (myString[i] == '0' || myString[i] == '1' || myString[i] == '2' || myString[i] == '3' || myString[i] == '4' ||
               myString[i] == '5' || myString[i] == '6' || myString[i] == '7' || myString[i] == '8' || myString[i] == '9')
            {
               int num = myString[i] - '0';
               sum += num;
            }
         }
         if (sum != 0)
         {
            Console.WriteLine(sum);
         }
         else
         {
            Console.WriteLine("No digits found.");
         }

      }
      public static void CleanTheText()
      {
         string myString = "Hi ^> there << I’m + telling %% you, you & need % to$ do &your $homeworks.@Hate ^ me ^ % now % and % thank % me & later.";
         Console.WriteLine(myString);



         char[] stuffToDelete = { '^', '>', '<', '+', '%', '&', '%', '$', '@' };

         foreach (char s in stuffToDelete)
         {

            myString = myString.Replace(s.ToString(), "");
         }



         myString = myString.Replace("  ", " ");
         myString = myString.Replace("  ", " ");
         myString = myString.Replace("   ", " ");
         Console.WriteLine(myString);
      }
      public static void AddIngOrLy()
      {
         Console.WriteLine("Please insert a string");
         string myString = Console.ReadLine();
         if (myString.Length >= 3)
         {
            if (myString.Substring(myString.Length - 3, 3) == "ing")
            {
               myString = myString + "ly";
               Console.WriteLine(myString);
            }
            else
            {
               myString = myString + "ing";
               Console.WriteLine(myString);
            }
         }
         else
         {
            Console.WriteLine(myString);
         }
      }
      public static void HideAdress()
      {
         string email = "awesome@dotnet.com";
         Console.WriteLine(email);
         var sb = new StringBuilder();
         int stopNum = email.IndexOf('@');
         string publicAdress = email.Substring(stopNum);
         int i = 0;
         while (i != stopNum)
         {
            sb.Append('*');
            i++;
         }
         sb.Append(publicAdress);
         email = sb.ToString();
         Console.WriteLine(email);
      }
      public static void FirstTwoLastTwo()
      {
         Console.WriteLine("Please insert a string");
         string str = Console.ReadLine();
         if (str.Length >= 2)
         {
            string firstTwo = str.Substring(0, 2);
            string lastTwo = str.Substring(str.Length - 2, 2);
            str = firstTwo + lastTwo;
            Console.WriteLine(str);
         }
         else
         {
            Console.WriteLine(str);
         }
      }
      public static void ChangeAllOccurences()
      {
         Console.WriteLine("Please insert a string");
         string str = Console.ReadLine();
         var sb = new StringBuilder();
         sb.Append(str[0]);

         for (int i = 1; i < str.Length; i++)
         {
            if (str[0] == str[i])
            {
               sb.Append('$');
            }
            else
            {
               sb.Append(str[i]);
            }
         }
         str = sb.ToString();
         Console.WriteLine(str);
      }
      public static void SwapLetters()
      {
         Console.WriteLine("Insert first string");
         string myString1 = Console.ReadLine();

         Console.WriteLine("Insert second string");
         string myString2 = Console.ReadLine();

         string finalString = "";
         string myString1First2 = myString1.Substring(0, 2);
         string myString2First2 = myString2.Substring(0, 2);

         string myString1Rest = myString1.Substring(2);
         string myString2Rest = myString2.Substring(2);

         finalString = myString1First2 + myString2Rest + " " + myString2First2 + myString1Rest;

         Console.WriteLine(finalString);
      }
      public static void PoorAndBad()
      {
         string myString = "The lyrics is not that poor!";
         string finalString = "";

         if (myString.IndexOf(" not") != -1 && myString.LastIndexOf(" poor") != -1 && myString.IndexOf(" not") < myString.LastIndexOf(" poor"))
         {
            string firstPart = myString.Substring(0, myString.IndexOf(" not"));
            finalString = firstPart + " good.";
            Console.WriteLine(finalString);
         }


      }
      public static void ListOfWOrds()
      {
         string myString = "Write a method that takes a list of words";
         Console.WriteLine(myString);

         string[] splitString = myString.Split(" ");
         //Console.WriteLine(splitString[0]);
         string max = splitString[0];

         for (int i = 0; i < splitString.Length; i++)
         {
            if (splitString[i].Length > max.Length)
            {
               max = splitString[i];
            }
         }
         Console.WriteLine($"The length of the longest word is : {max.Length}");
      }
      public static void LastPartBeforeCharacter()
      {
         string str = "https://www.siit.com/net-exercises";
         Console.WriteLine(str);
         Console.WriteLine("Please insert one character\n ex: ('a', '-', '+', '/'  etc..)");
         string charac = Console.ReadLine();
         string final = "";

         if (str.IndexOf(charac) == -1)
         {
            Console.WriteLine("That character does not exist in the string");
         }
         else
         {

            int location = str.IndexOf(charac);
            final = str.Substring(0, location);
            Console.WriteLine(final);
         }



      }
      public static void StartWith()
      {
         string str = "awesome string";
         Console.WriteLine(str);

         Console.WriteLine("Please insert one char");
         string character = Console.ReadLine();

         string message = "";
         if (str[0].ToString() == character)
         {
            message = $"yes it starts with {character}";
            Console.WriteLine(message);

         }
         else
         {
            message = $"It does not start with {character}";
            Console.WriteLine(message);
         }

      }
      public static void SwapCommaAndDot()
      {
         string myString = "32.054,23";
         var sb = new StringBuilder();
         for (int i = 0; i < myString.Length; i++)
         {
            if (myString[i].ToString() == ".")
            {
               sb.Append(",");
            }
            else if (myString[i].ToString() == ",")
            {
               sb.Append(".");
            }
            else
            {
               sb.Append(myString[i]);
            }
         }
         Console.WriteLine(myString);
         myString = sb.ToString();
         Console.WriteLine(myString);
      }
      public static void RemoveWhiteSpaces()
      {
         string myString = "Whrite      a   method    to           remove    spaces.";
         Console.WriteLine(myString);
         myString = myString.Replace(" ", string.Empty);
         Console.WriteLine(myString);

      }
      public static void Palindrome()
      {
         Console.WriteLine("Please insert a string");
         string str = Console.ReadLine();

         var sb = new StringBuilder();
         bool decision = false;
         for (int i = str.Length - 1; i >= 0; i--)
         {
            sb.Append(str[i]);
         }
         if (str == sb.ToString())
         {
            decision = true;
         }
         Console.WriteLine(decision);
      }

   }
}
