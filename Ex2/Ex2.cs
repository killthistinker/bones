using System;
using System.Text;

namespace Ex2
{
    internal class Ex2
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Игра кубики: Введите число от 2 до 12 для броска кубиков");
            int firstCube = rnd.Next(1, 7);
            int secondCube = rnd.Next(1, 7);
            int firstComputerCube = rnd.Next(1, 7);
            int secondComputerCube = rnd.Next(1, 7);
            GetWin(firstCube, secondCube, firstComputerCube, secondComputerCube);
        }

       static void GetWin(int firstCube,int secondCube, int firstComputerCube, int secondComputerCube)
        {
            int enterCube = 0;
            int numberCube = Check(enterCube);
            int resultCube = CubeSumm(firstCube, secondCube);
            int resultComputerCube = CubeSumm(firstComputerCube, secondComputerCube);
            int mathCube = resultCube - Math.Abs(resultCube - numberCube) * 2;
            Console.WriteLine("---            Start game            ---");
            Console.WriteLine("Predict the points number (2..12): {0}.", numberCube);
            Console.WriteLine("User rolls the dice:");
            GetGube(firstCube, secondCube);
            Console.WriteLine("Ont the dice fell {0} points.", resultCube);
            Console.WriteLine("Result is  {0} - abs({0} - {1})*2: {2} points.", resultCube, numberCube, mathCube);
            Console.WriteLine("");
            int computerCube = rnd.Next(2, 13);
            int mathComputerCube = resultComputerCube - Math.Abs(resultComputerCube - computerCube) * 2;
            Console.WriteLine("Computer predicted {0} points.", computerCube);
            Console.WriteLine("Computer rolls the dice:");
            GetGube(firstComputerCube, secondComputerCube);
            Console.WriteLine("Ont the dice fell {0} points.", resultComputerCube);
            Console.WriteLine("Result is  {0} - abs({0} - {1})*2: {2} points.", resultComputerCube, computerCube, mathComputerCube);
            Console.WriteLine("");
            if (mathCube > mathComputerCube)
            {
                mathCube -= mathComputerCube;
                Console.WriteLine("User wins {0} points more \nCongratulations!", mathCube);
            }
            else if (mathComputerCube > mathCube)
            {
                mathComputerCube -= mathCube;
                Console.WriteLine("Computer wins {0} points more \nyou LOSE", mathComputerCube);
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
            if (enterCube < 2)
            {
                Console.WriteLine("Введено неверное значение, введите число от 2 до 12");
                return Check(numberCube);
            }
            else if (enterCube > 12)
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
