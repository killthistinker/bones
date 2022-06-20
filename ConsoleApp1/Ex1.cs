using System;
using System.Text;

namespace ConsoleApp1
{
    internal class Ex1
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Игра кубики: Введите число от 2 до 12 для броска кубиков");
            int enterCube = 0;
            int numberCube = Check(enterCube);
            int firstCube = rnd.Next(1, 7);
            int secondCube = rnd.Next(1, 7);
            int resultCube = CubeSumm(firstCube, secondCube);
            int mathCube = resultCube - Math.Abs(resultCube - numberCube) * 2;
            Console.WriteLine("---            Start game            ---");
            Console.WriteLine("Predict the points number (2..12): {0},", numberCube);
            GetGube(firstCube, secondCube);
            Console.WriteLine("Ont the dice fell {0} points.", resultCube);
            Console.WriteLine("Result is  {0} - abs({0} - {1})*2: {2} points.", resultCube, numberCube, mathCube);
            if (mathCube > 0)
            {
                Console.WriteLine("User wins!");
            }
            else
            {
                Console.WriteLine("User lose!");
            }
        }

        static void GetGube(int cubeFirst, int cubeSecond)
        {
            switch (cubeFirst)
            {
                case 1:
                    Console.WriteLine("-----------");
                    Console.WriteLine("|         |");
                    Console.WriteLine("|    #    |");
                    Console.WriteLine("|         |");
                    Console.WriteLine("-----------");
                    break;
                case 2:
                    Console.WriteLine("-----------");
                    Console.WriteLine("|    #    |");
                    Console.WriteLine("|         |");
                    Console.WriteLine("|    #    |");
                    Console.WriteLine("-----------");
                    break;
                case 3:
                    Console.WriteLine("-----------");
                    Console.WriteLine("|  #      |");
                    Console.WriteLine("|    #    |");
                    Console.WriteLine("|      #  |");
                    Console.WriteLine("-----------");
                    break;
                case 4:
                    Console.WriteLine("-----------");
                    Console.WriteLine("|  #    # |");
                    Console.WriteLine("|         |");
                    Console.WriteLine("|  #    # |");
                    Console.WriteLine("-----------");
                    break;
                case 5:
                    Console.WriteLine("-----------");
                    Console.WriteLine("| #    # |");
                    Console.WriteLine("|    #   |");
                    Console.WriteLine("| #    # |");
                    Console.WriteLine("-----------");
                    break;
                case 6:
                    Console.WriteLine("-----------");
                    Console.WriteLine("|  # # # |");
                    Console.WriteLine("|        |");
                    Console.WriteLine("|  # # # |");
                    Console.WriteLine("-----------");
                    break;
            }
            switch (cubeSecond)
            {
                case 1:
                    Console.WriteLine("-----------");
                    Console.WriteLine("|         |");
                    Console.WriteLine("|    #    |");
                    Console.WriteLine("|         |");
                    Console.WriteLine("-----------");
                    break;
                case 2:
                    Console.WriteLine("-----------");
                    Console.WriteLine("|    #    |");
                    Console.WriteLine("|         |");
                    Console.WriteLine("|    #    |");
                    Console.WriteLine("-----------");
                    break;
                case 3:
                    Console.WriteLine("-----------");
                    Console.WriteLine("|  #      |");
                    Console.WriteLine("|    #    |");
                    Console.WriteLine("|      #  |");
                    Console.WriteLine("-----------");
                    break;
                case 4:
                    Console.WriteLine("-----------");
                    Console.WriteLine("|  #    # |");
                    Console.WriteLine("|         |");
                    Console.WriteLine("|  #    # |");
                    Console.WriteLine("-----------");
                    break;
                case 5:
                    Console.WriteLine("-----------");
                    Console.WriteLine("| #    # |");
                    Console.WriteLine("|    #   |");
                    Console.WriteLine("| #    # |");
                    Console.WriteLine("-----------");
                    break;
                case 6:
                    Console.WriteLine("-----------");
                    Console.WriteLine("|  # # # |");
                    Console.WriteLine("|        |");
                    Console.WriteLine("|  # # # |");
                    Console.WriteLine("-----------");
                    break;
            }
        }
        static int CubeSumm(int x, int y)
        {
            return x += y;
        }

        static int Check(int numberCube)
        {
            int enterCube = int.Parse(Console.ReadLine());
            if(enterCube < 2)
            {
                Console.WriteLine("Введено неверное значение, введите число от 2 до 12");
                return Check(numberCube);
            }
            else if(enterCube > 12)
            {
                
                Console.WriteLine("Введено неверное значение, введите число от 2 до 12");
                return Check(numberCube);
            }
            else
            {
                return enterCube;
            }
        }
    }
}
