using System.IO;
using System;

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
  }
}