using System;

class Program
{
    static void Main()
    {
        string[] name = new string[3];
        int[,] score = new int[3, 3];
        int[] total = new int[3];
        int choice;

        do
        {
            Console.Clear();
            Console.WriteLine("\n== FUN RUN RANKING ==");
            Console.WriteLine("[1] RECORD SCORES");
            Console.WriteLine("[2] SHOW PARTICIPANT SCORES");
            Console.WriteLine("[3] SHOW RANKING");
            Console.WriteLine("[4] EXIT");
            Console.Write("ENTER CHOICE: ");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("Participant's Namee: ");
                    name[i] = Console.ReadLine();
                    total[i] = 0;
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write("Round " + (j + 1) + ": ");
                        score[i, j] = Convert.ToInt32(Console.ReadLine());
                        total[i] += score[i, j];
                    }
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("\nPARTICIPANT\tR1\tR2\tR3\tTOTAL");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(name[i] + "\t\t" +
                        score[i, 0] + "\t" +
                        score[i, 1] + "\t" +
                        score[i, 2] + "\t" +
                        total[i]);
                }
                Console.ReadKey();
            }
            else if (choice == 3)
            {
                for (int pass = 1; pass <= 2; pass++)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        if (total[i] < total[i + 1])
                        {
                            int t = total[i];
                            total[i] = total[i + 1];
                            total[i + 1] = t;
                            string n = name[i];
                            name[i] = name[i + 1];
                            name[i + 1] = n;
                            for (int j = 0; j < 3; j++)
                            {
                                int s = score[i, j];
                                score[i, j] = score[i + 1, j];
                                score[i + 1, j] = s;
                            }
                        }
                    }
                    Console.Write("Pass " + pass + ": ");
                    for (int i = 0; i < 3; i++)
                        Console.Write(total[i] + " ");
                    Console.WriteLine();
                }
                Console.WriteLine("\nFUN RUN RANKING");
                for (int i = 0; i < 3; i++)
                        Console.WriteLine((i + 1) + ". " + name[i] + " - " + total[i]);
                    Console.ReadKey();
                }
            } while (choice != 4) ;
            Console.WriteLine("Thank you!");
        }
    }
