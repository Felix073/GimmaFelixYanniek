using System;
using System.Threading;
using YanniekGimma.Models;

namespace YanniekGimma
{
    class Program
    {
        static void Main(string[] args)
        {
            Score result = new Score();
            bool succes = true;
            Random random = new Random();
            Console.WriteLine("Press any key to start the Gimma");
            Console.ReadKey();
            while (succes)
            {
                int randomLetter = random.Next(11);
                string a = "A";
                string b = "B";
                string c = "C";
                string d = "D";
                string e = "E";
                string f = "F";
                string g = "G";
                string h = "H";
                string i = "I";
                string j = "J";
                string k = "K";
                int score = result.Points;
                switch (randomLetter)
                {
                    case 1:
                        if (true)
                        {
                            Console.WriteLine(a);
                            string Input = Console.ReadLine();
                            Input.ToUpper();

                            if (a == Input)
                            {
                                score = result.Points++;
                            }
                            else
                            {
                                Console.Write("Game over");
                                succes = false;
                            }
                        }
                        break;
                    case 2:
                        if (true)
                        {
                            Console.WriteLine(b);
                            string InputB = Console.ReadLine();
                            InputB.ToUpper();
                            if (b == InputB)
                            {
                                score = result.Points++;
                            }
                            else
                            {
                                Console.Write("Game over");
                                succes = false;
                            }
                        }
                        break;
                    case 3:
                        if (true)
                        {
                            Console.WriteLine(c);
                            string InputC = Console.ReadLine();
                            InputC.ToUpper();
                            if (c == InputC)
                            {
                                score = result.Points++;
                            }
                            else
                            {
                                Console.Write("Game over");
                                succes = false;
                            }
                        }
                        break;
                    case 4:
                        if (true)
                        {
                            Console.WriteLine(d);
                            string InputD = Console.ReadLine();
                            InputD.ToUpper();
                            if (d == InputD)
                            {
                                score = result.Points++;
                            }
                            else
                            {
                                Console.Write("Game over");
                                succes = false;
                            }
                        }
                        break;
                    case 5:
                        if (true)
                        {
                            Console.WriteLine(e);
                            string InputE = Console.ReadLine();
                            InputE.ToUpper();
                            if (e == InputE)
                            {
                                score = result.Points++;
                            }
                            else
                            {
                                Console.Write("Game over");
                                succes = false;
                            }
                        }
                        break;

                    case 6:
                        if (true)
                        {
                            Console.WriteLine(f);
                            string Inputf = Console.ReadLine();
                            Inputf.ToUpper();
                            if (f == Inputf)
                            {
                                score = result.Points++;
                            }
                            else
                            {
                                Console.Write("Game over");
                                succes = false;
                            }
                        }
                        break;
                    case 7:
                        if (true)
                        {
                            Console.WriteLine(g);
                            string InputG = Console.ReadLine();
                            InputG.ToUpper();
                            if (g == InputG)
                            {
                                score = result.Points++;
                            }
                            else
                            {
                                Console.Write("Game over");
                                succes = false;
                            }
                        }
                        break;

                    case 8:
                        if (true)
                        {
                            Console.WriteLine(h);
                            string Inputh = Console.ReadLine();
                            Inputh.ToUpper();
                            if (h == Inputh)
                            {
                                score = result.Points++;
                            }
                            else
                            {
                                Console.Write("Game over");
                                succes = false;
                            }
                        }
                        break;
                    case 9:
                        if (true)
                        {
                            Console.WriteLine(i);
                            string Inputi = Console.ReadLine();
                            Inputi.ToUpper();
                            if (i == Inputi)
                            {
                                score = result.Points++;
                            }
                            else
                            {
                                Console.Write("Game over");
                                succes = false;
                            }
                        }
                        break;
                    case 10:
                        if (true)
                        {
                            Console.WriteLine(j);
                            string Inputj = Console.ReadLine();
                            Inputj.ToUpper();
                            if (j == Inputj)
                            {
                                score = result.Points++;
                            }
                            else
                            {
                                Console.Write("Game over");
                                succes = false;
                            }
                        }
                        break;
                    case 11:
                        if (true)
                        {
                            Console.WriteLine(k);
                            string Inputk = Console.ReadLine();
                            Inputk.ToUpper();
                            if (k == Inputk)
                            {
                                score = result.Points++;
                            }
                            else
                            {
                                Console.Write("Game over");
                                succes = false;
                            }
                        }
                        break;
                }
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine(score);

            }
        }

    }
}
