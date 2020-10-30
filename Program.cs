﻿using System;

namespace IDP_MJU20_Souzet_Tadros
{
    class Program
    {
        static void Main(string[] args)
        {
            string perNr;
            Console.WriteLine("Ange ditt 12 siffriga personnummer: ");
            perNr = Console.ReadLine();
            if (perNr.Length != 12)
            {
                Console.WriteLine("Personnummer måste vara 12 siffror");
            }
            else
            {
                Console.WriteLine(" Rätt antal personnummer");
                string yearID = perNr.Substring(0, 4);
                int year = int.Parse(yearID);
                if (year < 1753 || year > 2020)
                {
                    Console.WriteLine("fel årtalet");
                }
                else
                {
                    Console.WriteLine("Rätt årtalet");
                    string monthID = perNr.Substring(4, 2);
                    int month = int.Parse(monthID);
                    if(month <1 || month > 12)
                    {
                        Console.WriteLine(" Fel månadtalet");
                    }
                    else
                    {
                        Console.WriteLine("Rätt månadtalet");
                        string dayID = perNr.Substring(6, 2);
                        int day = int.Parse(dayID);
                        if ((day < 1 && day > 31) && (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12))
                        {
                            Console.WriteLine(" Felaktig dag");
                        }                            
                        else if ((day < 1 || day > 30) && (month == 4 || month == 6 || month == 9 || month == 11))
                        {
                            Console.WriteLine(" Felaktig dag");
                        }                           
                        else if ((day < 1 || day > 28) && (month == 2))
                        {
                            Console.WriteLine(" Felaktig dag");
                        }                            
                        else if (day == 29 && month == 2 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)))
                        {

                        }

                        else
                        {
                            Console.WriteLine(" Rätt dag");
                            string nnN = perNr.Substring(8, 3);
                            int nNN = int.Parse(nnN);
                            if (nNN < 000 || nNN > 999)
                            {
                                Console.WriteLine(" Fel personnummer");
                            }
                            else
                            {
                                Console.WriteLine(" Rätt personnummer");
                                string cNum = perNr.Substring(11, 1);
                                int numC = int.Parse(cNum);
                                if (numC % 2 == 0)
                                {
                                    Console.WriteLine("Personnummer är till man");
                                }
                                else
                                {
                                    Console.WriteLine("Personnummer är till kvinna");
                                }

                            }

                                


                        }

                    }
                }
        }
        }
    }
}
