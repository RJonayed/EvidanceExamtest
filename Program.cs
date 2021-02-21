using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidanceExamtest
{
    class Program
    {
        static int count = 0;
        static void Main(string[] args)
        {
            try
            {
                MyClass cls = new MyClass();
                cls.StudentId = 1001;
                cls.Fanme = "Joanyed";
                cls.Lanme = "Rahaman";
                cls.Salary = 5000;
                cls.GetFullName();

                Console.WriteLine($"My id is: {cls.StudentId}\nMy Name is: {cls.GetFullName()}\nSalar: {cls.Salary}");

                getWork();
                

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                
            }

            Console.ReadLine();
        }

        private static void getWork()
        {
            //WorkingMethods();
            //Console.WriteLine($" this execute of No: {count}");
            // WorkingwithTupple();
            // WorkingWithAithetic();
            //WorkingSwitchCase();
            //WorkingifElse();
            //WorkingElseif(); 
            //workingWithWhileLop();
            //workingWithForLop();
            //workingWithForEach();
            //WorkingWithSteamWriter();
            //WorkingWithSteamReader();

        }

        private static void WorkingWithSteamReader()
        {
            string line = "";
            StreamReader Sr = new StreamReader("Test.txt");
            while ((line=Console.ReadLine())!=null)
            {
                Console.WriteLine(line);
            }
        }

        private static void WorkingWithSteamWriter()
        {
            string[] myAraay = new string[] { "Jonayed" ,"Rahama" ,"jakir" ,"Karim" };
            StreamWriter SW = new StreamWriter("Test.txt");
            foreach (var Test in myAraay)
            {
                SW.WriteLine(Test);
            }
        }

        private static void workingWithForEach()
        {
         
            int currentNumber = 0;
            int posNumber = 0;
            int negetiveNumber = 0;
            int zeroNumber = 0;
            int[] myArray = new int[] {0,1,2,5,8,-7,-3,0,0,0};
            foreach (var item in myArray)
            {
                currentNumber = item;
                if (currentNumber>0)
                {
                    posNumber++;
                }
                if (currentNumber < 0)
                {
                    negetiveNumber++;

                }
                else if (currentNumber< 0)
                {
                    zeroNumber++;
                }                               
            }
            Console.WriteLine($"Count Pos Number:{posNumber}\nNegetive Number:{negetiveNumber}\nZero Count:{zeroNumber}");
        }

        private static void workingWithForLop()
        {
            Console.WriteLine("Enster your number");
            int myNeumber = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i <= myNeumber; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void workingWithWhileLop()
        {
            Console.WriteLine("Enter your Start number");
            int StratNumber = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter your first number");
            int firstNumber = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter your first number");
            int lastNumber = Convert.ToInt16(Console.ReadLine());

            while (StratNumber<=lastNumber)
            {
                int result = 0;
                result = StratNumber * lastNumber;
                Console.WriteLine($" {StratNumber}*{lastNumber}={result}");
                StratNumber++;
            }
        }

        private static void WorkingElseif()
        {
            Console.WriteLine("Enter your first Number");
            int number = Convert.ToInt16(Console.ReadLine());
            string result = "";

            if (number >= 0 && number<=100) 
            {
                if (number >= 60 && number <= 70)
                {
                    result = "B";
                    Console.WriteLine(result);

                }
                else if (number >= 71 && number <= 80)
                {
                    result = "A";
                    Console.WriteLine(result);
                }
                else if (number >= 81 && number <= 100)
                {
                    result = "A+";
                    Console.WriteLine(result);
                }
                else
                {

                    Console.WriteLine("Not Valid");
                }
            }
            Console.WriteLine("Not Valid");

        }

        private static void WorkingifElse()
        {
            Console.WriteLine("Enter your Number");
            int startNumber = Convert.ToInt16(Console.ReadLine());

            string Grade = "";

            if (startNumber >= 60 && startNumber <= 70)
            {
                Grade = "B";
                Console.WriteLine(Grade);
            }
            if (startNumber >= 71 && startNumber <= 80)
            {
                Grade = "A";
                Console.WriteLine(Grade);
            }

            if (startNumber >= 81 && startNumber <= 100)
            {
                Grade = "A+" +
                    "";
                Console.WriteLine(Grade);
            }
            else
            {
                Console.WriteLine("Out Range");
            }
        }

        private static void WorkingSwitchCase()
        {
            Console.WriteLine("Enter your Number");
            int day = Convert.ToInt16(Console.ReadLine());
            switch (day)
            {
                case 1:                  
                    Console.WriteLine("Satuarday");
                    break;
                case 2:
                    Console.WriteLine("Sunday");
                    break;
                case 3:
                    Console.WriteLine("Monday");
                    break;
                case 4:
                    Console.WriteLine("Tuesday");
                    break;
                case 5:
                    Console.WriteLine("Wednesday");
                    break;

                case 6:
                    Console.WriteLine("thusday");
                    break;
                case 7:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("Not Valid number");
                    break;
            }
        }

        private static void WorkingWithAithetic()
        {
            Console.WriteLine("Enter first number");
            int myFirstNumber = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Escond number");
            int mySecondNumber = Convert.ToInt16(Console.ReadLine());

            int result = 0;
            result = myFirstNumber + mySecondNumber;
            Console.WriteLine($"Result of {myFirstNumber}+{mySecondNumber}={result}");

            result = myFirstNumber - mySecondNumber;
            Console.WriteLine($"Result of {myFirstNumber}-{mySecondNumber}={result}");


            result = myFirstNumber / mySecondNumber;
            Console.WriteLine($"Result of {myFirstNumber}/{mySecondNumber}={result}");


            result = myFirstNumber * mySecondNumber;
            Console.WriteLine($"Result of {myFirstNumber}*{mySecondNumber}={result}");

            Console.WriteLine();
            Console.WriteLine("Working of Increment");
            Console.WriteLine();
            result = myFirstNumber++;
            Console.WriteLine($"Post increment of {myFirstNumber}");

            result = ++myFirstNumber;
            Console.WriteLine($"Pre increment of {myFirstNumber}");

            result = myFirstNumber--;
            Console.WriteLine($"Post Decrement of {myFirstNumber}");

            result = --myFirstNumber;
            Console.WriteLine($"Pre Decrement of {myFirstNumber}");

        }

        private static void WorkingMethods()
        {
            Console.WriteLine("Anster to the question No_1");
            Console.WriteLine("----------------------------");
            Console.WriteLine();          

            Console.WriteLine();

            int num1 = 10;
            int num2 = 15;
            int num3 = 12;

            addNumber(num1, num2, num3);
            addNumber(num1: 10, num2: 15);

        }

        private static void WorkingwithTupple()
        {
            Console.WriteLine("-----------------------------Generic tuple----------------------------");

            Tuple<int, string, double, float> myTuple = new Tuple<int, string, double, float>(101, "Jonayed Rahaman", 5000,1) ;
            Console.WriteLine($"My id is:{myTuple.Item1}\nName is:{myTuple.Item2}\nSalary:{myTuple.Item3} Company id:{myTuple.Item4}");
            
            Console.WriteLine("-----------------------------Regular tuple----------------------------");
            var myTuple1 = Tuple.Create (101, "Jonayed Rahaman", 5000, 1);
            Console.WriteLine($"My id is:{myTuple.Item1}\nName is:{myTuple.Item2}\nSalary:{myTuple.Item3} Company id:{myTuple.Item4}");

            Console.WriteLine("-----------------------------Name tuple----------------------------");
            var tuple = (EmpId:101, Name:"Jonayed Rahaman", Salary:5000,CompanyId: 1);
            Console.WriteLine($"My id is:{myTuple.Item1}\nName is:{myTuple.Item2}\nSalary:{myTuple.Item3} Company id:{myTuple.Item4}");
        }

        private static void addNumber(int num1, int num2, int num3=12)
        {


            int result = 0;
            result = num1 + num2 + num3;
            Console.WriteLine($"{num1} + {num2} + {num3}={result}");
            count++;

        }

        private static void addNumber(int num1, int num2)
        {
            Console.WriteLine("----------------------------");
            int result = 0;
            result = num1 + num2;
            Console.WriteLine($"{num1}+{num2}={result}");
            count++;
        }
    }
}