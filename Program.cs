using System;

namespace Game
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Slot();
        }

        public static bool ValidateAge(int age, int ageLimit)
        {
            return age >= ageLimit;
        }

        public static bool ValidateBet(int bet, int lowerBound, int upperBound, int x)
        {
            return bet >= lowerBound && bet <= upperBound && bet % x == 0;
        }

        public static double Coefficient(int one, int two, int three)
        {
            if (one == two && two == three && one == three)
            {
                if (one == 7)
                {
                    return 150 * 1.5;
                }

                else
                {
                    return 10 * one * 1.5;
                }
            }

            else if (one == two)
            {
                if (one == 7)
                {
                    return 15 * 2.5;
                }

                else
                {
                    return one * 1.25;
                }
            }

            else if (one == 7 || two == 7 || three == 7)
            {
                return 1.6;
            }

            else if (one == 9 || two == 9 || three == 9)
            {
                return 1.35;
            }

            return 0;
        }

        public static double WinningAmount(int bet, double coefficient)
        {
            return bet * coefficient;
        }

        public static string finalMassage(double win)
        {
            if (Math.Abs(0 - win) > 0.01)
            {
                return $" Вы выиграли {Math.Round(win, 2)}";
            }

            else
            {
                return "Вы проиграли";
            }
        }


        public static void SlotRemased()
        {
            Console.WriteLine("Ваше имя");
            Console.ReadLine();
            Console.WriteLine("Возраст");
            int age = int.Parse(Console.ReadLine());
            Console.Clear();

            if (ValidateAge(age, 18))
            {
                Console.WriteLine("Ваша ставка");
                int bet = int.Parse(Console.ReadLine());
                Console.Clear();

                if (ValidateBet(bet, 5, 100, 5))
                {
                    Random r = new Random();

                    int one = r.Next(1, 10), two = r.Next(1, 10), three = r.Next(1, 10);

                    double coefficient = Coefficient(one, two, three);
                    double win = WinningAmount(bet, coefficient);

                    Console.WriteLine(finalMassage(win));
                }

            }
            else
            {
                Console.WriteLine("Приходи когда подрастешь");
            }

        }


        public static void Slot()
        {
            Console.WriteLine("Ваше имя");
            Console.ReadLine();
            Console.WriteLine("Возраст");
            int age = int.Parse(Console.ReadLine());
            Console.Clear();


            if (age <= 17)
            {
                Console.WriteLine("Приходи когда подрастешь");
                if (age < 0)
                {
                    throw new Exception("Неверная ставка");
                }
            }

            else
            {
                Console.WriteLine("Ваша ставка");
                int bet = int.Parse(Console.ReadLine());
                Console.Clear();

                if (bet < 5 || bet > 100 || bet % 5 != 0)
                {
                    Console.WriteLine("Неверная ставка");

                }

                else
                {
                    double win = 0;

                    Random r = new Random();
                    int one = r.Next(1, 10); int two = r.Next(1, 10); int three = r.Next(1, 10);
                    Console.WriteLine($"{one} {two} {three}");

                    if (one == two && two == three && one == three)
                    {
                        if (one == 7)
                        {
                            win = bet * 150 * 1.5;
                        }

                        else
                        {
                            win = bet * 10 * one * 1.5;
                        }
                    }

                    else if (one == two)
                    {
                        if (one == 7)
                        {
                            win = bet * 15 * 2.5;
                        }

                        else
                        {
                            win = bet * one * 1.25;
                        }
                    }

                    else if (one == 7 || two == 7 || three == 7)
                    {
                        win = bet * 1.6;
                    }

                    else if (one == 9 || two == 9 || three == 9)
                    {
                        win = bet * 1.35;
                    }

                    if (Math.Abs(0 - win) > 0.01)
                    {
                        Console.WriteLine($" Вы выиграли {Math.Round(win, 2)}");
                    }

                    else
                    {
                        Console.WriteLine("Вы проиграли");
                    }
                }
            }
        }
    }
}
