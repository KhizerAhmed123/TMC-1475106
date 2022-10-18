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
  }
  public static void RangeTest() {
    IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x* x);

    foreach (int num in squares)
    {
        Console.WriteLine(num);
    }
}

}

    
      
      
      

  
