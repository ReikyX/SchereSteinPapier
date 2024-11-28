namespace SchereSteinPapier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool nochmal = true;
            Console.ForegroundColor = ConsoleColor.Blue;
            do
            {
                Console.WriteLine("Willkommen zu dem Spiel Schere, Stein, Papier!");
                Console.WriteLine("\nWähle dein Handzeichen aus.");
                Console.WriteLine("\nEs gibt folgende Auswahlmöglichkeiten (1)Schere - (2)Stein - (3)Papier.");
                int userWahl = 0;

                while (true)
                {
                    string eingabe = Console.ReadLine();
                    if (int.TryParse(eingabe, out userWahl) && (userWahl == 1 || userWahl == 2 || userWahl == 3))
                    {
                        break; // Wenn die Eingabe gültig ist, verlasse die Schleife
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\nUngültige Eingabe! Bitte wähle eine Zahl zwischen 1 und 3.");
                        Console.WriteLine("\nWähle dein Handzeichen erneut aus.\n");
                    }
                }

                Random computer = new Random();
                int npcWahl = computer.Next(1, 4);

                if (userWahl == 1)
                {
                    Console.Write("\nSie haben ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Schere ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("ausgewählt.");
                }
                else if (userWahl == 2)
                {
                    Console.Write("\nSie haben ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Stein ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("ausgewaählt.");
                }
                else
                {
                    Console.Write("\nSie haben ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Papier ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("ausgewählt");
                }


                if (npcWahl == 1)
                {
                    Console.Write("\nDer NPC hat ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Schere ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("ausgewählt");
                }
                if (npcWahl == 2)
                {
                    Console.Write("\nDer NPC hat ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Stein ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("ausgewählt");
                }
                if (npcWahl == 3)
                {
                    Console.Write("\nDer NPC hat ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Papier ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("ausgewählt");
                }


                if (userWahl == npcWahl)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nUnentschieden!");
                }
                else if ((userWahl == 1 && npcWahl == 3) || (userWahl == 2 && npcWahl == 1) || (userWahl == 3 && npcWahl == 2))
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("\nDu hast Gewonnen!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nDu hast leider Verloren");
                }



                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nWollen sie nochmal spielen? (j/n)\n");
                string erneutSpielen = Console.ReadLine().ToLower().Trim();

                if ((erneutSpielen == "n") || (erneutSpielen == "nein"))
                {
                    Console.WriteLine("\nDanke fürs Spielen! Bis zum nächsten mal!");
                    nochmal = false;
                }
                Console.Clear();

            } while (nochmal);



            //Programmieren Sie ein Schere, Stein, Papier Spiel.
            //Der User soll eines der Handzeichen wählen können.
            //Der Computer wählt per Zufall ein eigenes Zeichen. (recherchieren Sie hierzu Random für C#)
            //Dem User wird dann ausgegeben, welches Zeichen der Computer gewählt hat und ob man gewonnen, verloren oder ein Unentschieden hat.
            //Danach kann sich der User entscheiden eine weitere Runde zu spielen, oder nicht.

            /*
            string input;
            Random rnd = new Random();
            int computer;
            bool continueGame;

            do
            {
                continueGame = false;
                Console.Clear();
                Console.WriteLine("Hallo User! Wähle PAPIER STEIN oder SCHERE");
                input = Console.ReadLine().ToLower().Trim();
                computer = rnd.Next(1, 4);

                if (input.Equals("papier") || input.Equals("stein") || input.Equals("schere"))
                {
                    if (computer == 1)
                    {
                        Console.WriteLine("Computer hat PAPIER gewählt");
                        if (input.Equals("papier"))
                        {
                            Console.WriteLine("Unentschieden!");
                        }
                        else if (input.Equals("stein"))
                        {
                            Console.WriteLine("Du hast verloren!");
                        }
                        else
                        {
                            Console.WriteLine("Du hast gewonnen!");
                        }
                    }
                    else if (computer == 2)
                    {
                        Console.WriteLine("Computer hat STEIN gewählt");
                        if (input.Equals("stein"))
                        {
                            Console.WriteLine("Unentschieden!");
                        }
                        else if (input.Equals("schere"))
                        {
                            Console.WriteLine("Du hast verloren!");
                        }
                        else
                        {
                            Console.WriteLine("Du hast gewonnen!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Computer hat SCHERE gewählt");
                        if (input.Equals("schere"))
                        {
                            Console.WriteLine("Unentschieden!");
                        }
                        else if (input.Equals("papier"))
                        {
                            Console.WriteLine("Du hast verloren!");
                        }
                        else
                        {
                            Console.WriteLine("Du hast gewonnen!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Eingabe Inkorrekt!");
                }

                Console.WriteLine("Möchtest du noch eine Runde spielen? J/N");
                input = Console.ReadLine().ToLower().Trim();

                if (input.Equals("j"))
                {
                    continueGame = true;
                }
                else
                {
                    continueGame = false;
                }
            }
            while (continueGame);
            */

            Random rand = new Random();
            string comOut;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hallo User. Bitte gib Papier, Stein oder Schere ein.");
                string input = Console.ReadLine().ToLower().Trim();
                int com = rand.Next(1, 4);

                if (com == 1) comOut = "papier";
                else if (com == 2) comOut = "stein";
                else comOut = "schere";

                if ((input.Equals("papier") && com == 2) || (input.Equals("stein") && com == 3) || (input.Equals("schere") && com == 1))
                {
                    Console.WriteLine($"Computer hat {comOut} gewählt. Du hast gewonnen.");
                }
                else if ((input.Equals("papier") && com == 3) || (input.Equals("stein") && com == 1) || (input.Equals("schere") && com == 2))
                {
                    Console.WriteLine($"Computer hat {comOut} gewählt. Du hast verloren.");
                }
                else if ((input.Equals("papier") && com == 1) || (input.Equals("stein") && com == 2) || (input.Equals("schere") && com == 3))
                {
                    Console.WriteLine($"Computer hat {comOut} gewählt. Unentschieden.");
                }
                else
                {
                    Console.WriteLine("Eingabe ist ungültig");
                }

                Console.WriteLine("Möchtest du noch eine Runde spielen? ");


                if ("j" != Console.ReadLine().ToLower().Trim()) break;
            }


        }
    }
}
