using System;

namespace Ex3
{
    internal class Ex3
    {
        static Random rnd = new Random();
        private static int[] _resultsUser = new int[3];
        private static int[] _resultsComputer = new int[3];
        private static int[] _userPredicted = new int[3];
        private static int[] _computerPredicted = new int[3];
        private static int[] _userDice = new int[3];
        private static int[] _computerDice = new int[3];
        static void Main(string[] args)
        {
            Console.WriteLine("Игра кубики: Введите число от 2 до 12 для броска кубиков");           
            int i = 0;
            GetCast(i);      
        }

        static void GetCast(int x)
        {
            for(int i = 0; i < 3; i++)
            {
                if(x < 3)
                {
                    int firstCube = rnd.Next(1, 7);
                    int secondCube = rnd.Next(1, 7);
                    int firstComputerCube = rnd.Next(1, 7);
                    int secondComputerCube = rnd.Next(1, 7);
                    Console.WriteLine("Бросайте кубик");
                    int enterCube = 0;
                    int numberCube = Check(enterCube);
                    _userPredicted[i] = numberCube;
                    int resultCube = CubeSumm(firstCube, secondCube);
                    int resultComputerCube = CubeSumm(firstComputerCube, secondComputerCube);
                    _userDice[i] = resultCube;
                    _computerDice[i] = resultComputerCube;
                    int mathCube = resultCube - Math.Abs(resultCube - numberCube) * 2;
                    Console.WriteLine("---            Start game            ---");
                    Console.WriteLine("Predict the points number (2..12): {0}.", numberCube);
                    Console.WriteLine("User rolls the dice:");
                    GetGube(firstCube, secondCube);
                    Console.WriteLine("Ont the dice fell {0} points.", resultCube);
                    Console.WriteLine("Result is  {0} - abs({0} - {1})*2: {2} points.", resultCube, numberCube, mathCube);
                    Console.WriteLine("");
                    int computerCube = rnd.Next(2, 13);
                    _computerPredicted[i] = computerCube;
                    int mathComputerCube = resultComputerCube - Math.Abs(resultComputerCube - computerCube) * 2;
                    Console.WriteLine("Computer predicted {0} points.", computerCube);
                    Console.WriteLine("Computer rolls the dice:");
                    GetGube(firstComputerCube, secondComputerCube);
                    Console.WriteLine("Ont the dice fell {0} points.", resultComputerCube);
                    Console.WriteLine("Result is  {0} - abs({0} - {1})*2: {2} points.", resultComputerCube, computerCube, mathComputerCube);
                    Console.WriteLine("");
                    Console.WriteLine("------- Current score -------");
                    Console.WriteLine("User: {0}", mathCube);
                    Console.WriteLine("Computer: {0}", mathComputerCube);
                    _resultsUser[i] = mathCube;
                    _resultsComputer[i] = mathComputerCube;
                        if (_resultsUser[i] > _resultsComputer[i])
                        {
                            _resultsUser[i] -= _resultsComputer[i];
                            Console.WriteLine("User as ahead by {0} points!", _resultsUser[i]);
                        }
                        else if (_resultsComputer[i] > _resultsUser[i])
                        {
                            _resultsComputer[i] -= _resultsUser[i];
                            Console.WriteLine("Computer as ahead by {0} points!", _resultsComputer[i]);
                        }
                        else
                        {
                            Console.WriteLine("draw!");
                        }
                        x++;
                }
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-------------- Finish game --------------");
            Console.WriteLine("Round |              User|       Computer");
            int number = 0, userResult = 0, computerResult = 0;
            for (int i = 0; i < _computerPredicted.Length; i++)
            {
                number++;
                Console.WriteLine("--------+---------------+---------------");
                Console.WriteLine("        | Predicted: {0}  | Predicted: {1}", _userPredicted[i], _computerPredicted[i]);
                Console.WriteLine(" - {0} -  | Dice:      {1}  | Dice:      {2}", number, _userDice[i], _computerDice[i]);
                Console.WriteLine("        | Result:    {0}  | Result:    {1}", _resultsUser[i], _resultsComputer[i]);
                userResult += _resultsUser[i];
                computerResult += _resultsComputer[i];
            }
            Console.WriteLine(" ");
            Console.WriteLine("Total   |  Points:   {0}| Points:   {1}", userResult, computerResult);
            Console.WriteLine(" ");
            if(userResult < 0)
            {
                userResult = Math.Abs(userResult);
            }
            else
            {
                if (userResult > computerResult)
                {
                    userResult -= computerResult;
                    Console.WriteLine("Users win {0} points more\n Congratulations!", userResult);
                }
                else if (computerResult > userResult)
                {
                    computerResult -= userResult;
                    Console.WriteLine("Computer win {0} points more", computerResult);
                }
                else
                {
                    Console.WriteLine("Draw!");
                }
            }
            if (computerResult < 0)
            {
                computerResult = Math.Abs(computerResult);
            }
            else
            {
                if (userResult > computerResult)
                {
                    userResult -= computerResult;
                    Console.WriteLine("Users win {0} points more\n Congratulations!", userResult);
                }
                else if (computerResult > userResult)
                {
                    computerResult -= userResult;
                    Console.WriteLine("Computer win {0} points more", computerResult);
                }
                else
                {
                    Console.WriteLine("Draw!");
                }
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
