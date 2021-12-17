using System;

namespace stringSearching
{
    class Program
    {
        static string str;
        static int noktaSayisi = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Bir değer giriniz?");
            str = Console.ReadLine();

            gecerliSayiMi(str);
            noktaSayisi = 0;
            Main(args);
        }

        private static void gecerliSayiMi(string str)
        {
            int i;
            if (str[0] == '+' || str[0] == '-' || str[0] == '1' || str[0] == '2' || str[0] == '3' || str[0] == '4' || str[0] == '5' || str[0] == '6' || str[0] == '7' || str[0] == '8' || str[0] == '9')
            {
                for (i = 1; i < str.Length; i++)
                {
                    if (str[i] == '1' || str[i] == '2' || str[i] == '3' || str[i] == '4' || str[i] == '5' || str[i] == '6' || str[i] == '7' || str[i] == '8' || str[i] == '9' || str[i] == '0' || str[i] == '.')
                    {
                        if (str[i] == '.')
                        {
                            noktaSayisi++;
                        }

                    }
                    else
                    {
                        break;
                    }
                }
                if (str[0] == '+' || str[0] == '-')
                {
                    if (i == str.Length && noktaSayisi == 1)
                    {
                        Console.WriteLine($"{str} '{str[0]}' değerli bir ondalıklı sayıdır.");
                    }
                    else if (i == str.Length && noktaSayisi == 0)
                    {
                        Console.WriteLine($"{str} '{str[0]}' değerli bir tam sayıdır.");
                    }
                    else
                    {
                        Console.WriteLine($"{str} geçerli bir ondalıklı sayı değildir.");
                    }
                }
                else
                {
                    if (i == str.Length && noktaSayisi == 1)
                    {
                        Console.WriteLine($"{str} bir ondalıklı sayıdır.");
                    }
                    else if (i == str.Length && noktaSayisi == 0)
                    {
                        Console.WriteLine($"{str} bir tam sayıdır.");
                    }
                    else
                    {
                        Console.WriteLine($"{str} geçerli bir ondalıklı sayı değildir.");
                    }
                }


            }
            else if (str[0] == '0')
            {
                if (str.Length > 1)
                {
                    if (str[1] == '.')
                    {
                        for (i = 1; i < str.Length; i++)
                        {
                            if (str[i] == '1' || str[i] == '2' || str[i] == '3' || str[i] == '4' || str[i] == '5' || str[i] == '6' || str[i] == '7' || str[i] == '8' || str[i] == '9' || str[i] == '0' || str[i] == '.')
                            {
                                if (str[i] == '.')
                                {
                                    noktaSayisi++;
                                }

                            }
                            else
                            {
                                break;
                            }
                        }
                        if (i == str.Length && noktaSayisi == 1)
                        {
                            Console.WriteLine($"{str} bir ondalıklı sayıdır.");
                        }
                        else
                        {
                            Console.WriteLine($"{str} geçerli bir ondalıklı sayı değildir.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{str} geçerli bir ondalıklı sayı değildir.");
                    }
                }
                else if (str.Length == 1)
                {
                    Console.WriteLine($"{str} bir tam sayıdır.");
                }
            }
            else
            {
                Console.WriteLine($"{str} geçerli bir ondalıklı sayı değildir.");
            }
        }
    }
}
