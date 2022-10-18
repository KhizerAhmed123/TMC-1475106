using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  static void Main () 
  {  
      //create array for month of the year 
    string[] months = new string[12]
    {"Jan","Feb","Mar","Apr", "May" ,"Jun" ,"Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};

      Random rnd = new Random();
        //initialise prng with a time-dependant default seed value
        int month = rnd.Next(1, 13);
        

    //output the random month name
    Console.WriteLine("month is {0}", months[month-1]);
    RangeTest();
    RoundTest();
    TruncateTest();
    GetLengthOfString("khizer");
    GetCharOfString("khizer", 5);
  }
  
  public static void RangeTest() {
    IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x* x);

    foreach (int num in squares)
        Console.WriteLine(num);
}

  public static void RoundTest()
  {
    float originalNumber1 = 1.23f;
    float originalNumber2 = 3.15f;
    float originalNumber3 = 1.9f;

    float roundedNumber1 = (float)Math.Round(originalNumber1, 1);
    float roundedNumber2 = (float)Math.Round(originalNumber2, 1);
    float roundedNumber3 = (float)Math.Round(originalNumber3, 0);

    Console.WriteLine("roundNumber1 is " + roundedNumber1);
    Console.WriteLine("roundNumber2 is " + roundedNumber2);
    Console.WriteLine("roundNumber3 is " + roundedNumber3);                  

  }

  public static void TruncateTest()
 {
    decimal decimalNumber;

    decimalNumber = 32.7865m;
    //Displays 32 
    Console.WriteLine(Math.Truncate(decimalNumber));

    decimalNumber = -32.9012m;
    //Display -32 
    Console.WriteLine(Math.Truncate(decimalNumber));
  }  
 public static void GetLengthOfString(string str) {
   int length;

   length = str.Length;
   Console.WriteLine("{0} is {1} characters long", str, length);
   
 }     
  public static void GetCharOfString(string str, int i) 
  {
    Char singleletter;

    SingleLetter = str[i];
    Console.WriteLetter("Character {0} of {1} is {2}",i,str,
 SingleLetter);                       
  }
  }      