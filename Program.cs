using System;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Print()
        {
            Console.WriteLine("My First C-sharp Program!!");
            Console.WriteLine(3 + 3);
            
            // Print in Same Line
            Console.Write("Hello World! ");
            Console.Write("I will print on the same line.");
        }
        static void Addtwonumbers()
        {
             // Adding two Numbers
            int x = 5;
            int y = 6;
            int sum = x + y;
            Console.WriteLine(sum);
        }
        static void Variables()
        {
            // Variables
            string name="Nimish";
            string last="Nimbalkar";
            string full=name+last;
            int age=21;
            const int c=60;
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(c); 
            Console.WriteLine(full);
            
        }
        static void Datatypes()
        {
            // Data Types
            string myname="Nimish";
            double q=4.56D;
            char n='n';
            int t=56;
            float w=5.67F;
            Console.WriteLine(Convert.ToString(t));
            Console.WriteLine(Convert.ToDouble(t));
            Console.WriteLine(myname);
            Console.WriteLine(q);
            Console.WriteLine(n);
            Console.WriteLine(t);
            Console.WriteLine(w);
        }
        static void Userinput()
        {
            // User Input
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Enter your Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Username is {0}",username);
            Console.WriteLine("Username is "+username);
            // Numeric Input
            Console.WriteLine("Enter your age:");
            string ages = Console.ReadLine();
            int ag=Convert.ToInt32(ages);
            Console.WriteLine("Your age is "+ag);
        }
        static void Maths()
        {
            // Math
            int l=9;
            int m=-7;
            Console.WriteLine(Math.Max(l,m));
            Console.WriteLine(Math.Min(l,m));
            Console.WriteLine(Math.Sqrt(l));
            Console.WriteLine(Math.Abs(m));
            Console.WriteLine(Math.Round(5.68));
        }
        static void String(string username)
        {
            // String
            int m=-7;
            string name="Nimish";
            string last="Nimbalkar";
            Console.WriteLine("Length of the string is: "+username.Length);
            Console.WriteLine(username.ToUpper());
            Console.WriteLine(username.ToLower());
            Console.WriteLine(Math.Abs(m));
            string f = string.Concat(name, last);
            Console.WriteLine(f);
            string g =$"Full name is: {name} {last}";
            Console.WriteLine(g);
            Console.WriteLine(username[0]);
            Console.WriteLine(username[1]);
            Console.WriteLine(name.IndexOf("m"));
            int substringi=last.IndexOf("m");
            string substring=last.Substring(substringi);
            Console.WriteLine(substring);
            Console.WriteLine("I\'m \"Nimish\"\\");
        }

        static void Boolean()
        {
            // Boolean
            bool statement=true;
            Console.WriteLine(statement);
            Console.WriteLine(8==7);
        }

        static void Ifelse(int ag)
        {
            // If-else
            Userinput();
            if (ag>18)
            {
                Console.WriteLine("Age is above 18!");
            }
            else if (ag==18)
            {
                Console.WriteLine("Age is 18.");
            }
            else
            {
                Console.WriteLine("Age is below 18.");
            }
            int d=9;
            string result=(d==9)?"Good day":"Good Evening";
            Console.WriteLine(result);

        }

        static void whilel()
        {
            // While
            int i=0;
            while(i<5)
            {
                Console.WriteLine(i);
                i++;
            }

            int u=0;
            do
            {
                Console.WriteLine(u);
                u++;
            }
            while(u<3);
        }

        static void forl()
        {
             // For Loop
            int p;
            for(p=0;p<=10;p=p+2)
            {
                Console.WriteLine(p);
            }
            string[] Cars={"Volvo","Honda","Maruti","BMW"};
            foreach(string v in Cars)
            {
                Console.WriteLine(v);
            }

        }
       
        static void array()
        {
            // Arrays
            string[] Car={"Volvo","Honda","Maruti","BMW"};
            Console.WriteLine(Car[2]);
            Console.WriteLine(Car.Length);
            Array.Sort(Car);
            foreach(string h in Car)
            {
                Console.WriteLine(h);
            }

            int[] myNum={60, 10, 20, 30, 40, 50};
            Array.Sort(myNum);
            foreach(int insort in myNum)
            {
                Console.WriteLine(insort);
            }
            Console.WriteLine(myNum.Max());
            Console.WriteLine(myNum.Min());
            Console.WriteLine(myNum.Sum());
        }
        static void Main(string[] args)
        {
            // Switch
            Console.WriteLine("Enter a number From the list:\n 1. Print\n 2. Add two Numbers(5+6)\n 3. Variables\n 4. Datatypes\n 5. User Input\n 6. Math\n 7. String\n 8. Boolean\n 9. If-Else\n 10. While\n 11. For Loop\n 12. Array");
            int num=Convert.ToInt32(Console.ReadLine());
            switch(num)
            {
                case 1:
                Print();
                break;
                case 2:
                Addtwonumbers();
                break;
                case 3:
                Variables();
                break;
                case 4:
                Datatypes();
                break;
                case 5:
                Userinput();
                break;
                case 6:
                Maths();
                break;
                case 7:
                Console.Write("Enter your username: ");
                string e=Console.ReadLine();
                String(e);
                break;
                case 8:
                Boolean();
                break;
                case 9:
                Console.Write("Enter your age: ");
                int f=Convert.ToInt32(Console.ReadLine());
                Ifelse(f);
                break;
                case 10:
                whilel();
                break;
                case 11:
                forl();
                break;
                case 12:
                array();
                break;
                default:
                Console.WriteLine("Select again");
                break;
            }

        }
        
    }
}
