using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planet_DevopsProject
{
    public class ProgramHandler
    {
        private Calculation _calculation;

        public ProgramHandler()
        {
            _calculation = new Calculation();
        }

        public void Run()
        {
        

            while (true)
            {
                Console.WriteLine("Enter the action to be performed");
                Console.WriteLine("Press 1 for Addition");
                Console.WriteLine("Press 2 for Subtraction");
                Console.WriteLine("Press 3 for Multiplication");
                Console.WriteLine("Press 4 for Division \n");
                int action = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 1st input");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd input");
                int b = Convert.ToInt32(Console.ReadLine());
                int result = 0;
                switch (action)
                {
                    case 1:
                        {
                            result = _calculation.Addition(a, b);
                            break;
                        }
                    case 2:
                        {
                            result = _calculation.Subtraction(a, b);
                            break;
                        }
                    case 3:
                        {
                            result = _calculation.Multiplication(a, b);
                            break;
                        }
                    case 4:
                        {
                            result = _calculation.Division(a, b);
                            break;
                        }
                    default:
                        Console.WriteLine("Wrong action!! try again");
                        break;
                }
                Console.WriteLine("The result is {0}", result);

                Console.ReadLine();
                Console.Clear();
            }

            
        }
    }
}
