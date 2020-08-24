using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine("Please enter up to 100 numbers, and at the end ';'");
      int[] numbers;   //dec
      numbers = new int[100];    //instantiation + assignment
      int i = 0;
      string numberInput = "";
      while (i < 100 && numberInput != ";")
      {
        numberInput = Console.ReadLine();   //js: console.log('text'),  php: echo 'text'
        if (numberInput != ";")
        {
          numbers[i] = int.Parse(numberInput);
        }

        i++;
      }

      Console.ReadLine();
      //for (int i = 0; i < 100; i++)
      //{
      //  int number = int.Parse(numInput);
      //}

      //var x = int.Parse(numInput);
      //int number = int.Parse(numInput);


      //int num = int.Parse("5");
      ////int num = 5;
      //bool flag = bool.Parse("true");
      ////bool flag = false;





      ////variables
      //int num1;
      //int num2;
      //int num3;
      //int num4;
      //int num5;
      //int num6;
      //int num7;
      //int num8;
      //int num9;
      //string str;
      //string name1;
      //string name2;
      //string name3;
      //string name4;
      //string name5;
      //string name6;
      //string name7;
      //string name8 = "ori";
      //string name9;
      //decimal salary;
      //DateTime birthDate;
      //TimeSpan lessonLength;
      //double formulaRatio;
      //bool isFemale;
      //char letter;   //RAM= Random-Access-Memory

      //while (true)
      //{

      //}

      ////arrays
      //string[] familyNames;  //declaration
      //familyNames = new string[5];   //instantiation + assignment
      //Console.WriteLine("Please enter all of your family names (and press enter between them)");
      //for (int i = 0; i < 5; i++)
      //{
      //  string name = Console.ReadLine();
      //  familyNames[i] = name;   //usage (write)
      //}

      //Console.WriteLine("Your familiy names are :");
      //for (int i = 0; i < 5; i++)
      //{
      //  string name = familyNames[i];   //usage (read)
      //  Console.WriteLine(name);
      //}




      //int i;   //dec
      //i = 0;   //init
      //if (i < 10)
      //{

      //}

      //i++;   //promote   i=i+1

      //for (int i = 0; i < 10; i++)
      //{

      //  Console.WriteLine(i);
      //  //0 1 2 3 4 5 6 7 8 9   10 X
      //}   //iteration

      //int i = 0;
      //while (i < 10)
      //{

      //  Console.WriteLine(i);
      //  i++;
      //}

      //i = 0;
      //do
      //{

      //  i++;
      //} while (i < 10);

      //Console.WriteLine("What is your first name");
      //string fname = Console.ReadLine();   //dec+ass

      //Console.WriteLine("What is your last name");
      //string lname;   //dec
      //lname = Console.ReadLine();   //ass

      //Console.WriteLine("How old are you ?");
      //string ageInput = Console.ReadLine();
      //int age = int.Parse(ageInput);
      ////int age = Convert.ToInt32(ageInput);

      //Console.WriteLine("What is your address ?");
      //string address = Console.ReadLine();

      //Console.WriteLine("What is your salary ? ");
      //string salaryInput = Console.ReadLine();
      //decimal salary = decimal.Parse(salaryInput);

      //Console.WriteLine("Press any key to continue...");
      //Console.ReadLine();

      //Console.WriteLine("Your full name is: " + fname + " " + lname);
      //if (salary > 3000)
      //{
      //  Console.WriteLine("and you are rich !!!");
      //}
      //else
      //{
      //  Console.WriteLine("you have no money !!!");
      //}


      Console.ReadLine();
    }
  }
}
