using System;
using System.Linq;

namespace FromBinaryToNextNumSystem
{
    class Program
    {
        private static void BinaryToTernary(ref long Binary, ref long Decimal, ref long Ternary)
        {
            long p = 1, i = 1, j, d;
            for (j = Binary; j > 0; j = j / 10)
            {
                d = j % 10;
                if (i == 1)
                    p = p * 1;
                else
                    p = p * 2;
                Decimal = Decimal + (d * p);
                i++;
            }
            i = 1;
            for (j = Decimal; j > 0; j = j / 3)
            {
                Ternary = Ternary + (j % 3) * i;
                i = i * 10;
                Binary = Binary / 3;
            }
        }
        private static void BinaryToQuaternary(ref long Binary, ref long Decimal, ref long Quaternary)
        {
            long p = 1, i = 1, j, d;
            for (j = Binary; j > 0; j = j / 10)
            {
                d = j % 10;
                if (i == 1)
                    p = p * 1;
                else
                    p = p * 2;
                Decimal = Decimal + (d * p);
                i++;
            }
            i = 1;
            for (j = Decimal; j > 0; j = j / 4)
            {
                Quaternary = Quaternary + (j % 4) * i;
                i = i * 10;
                Binary = Binary / 4;
            }
        }
        private static void BinaryToQuinary(ref long Binary, ref long Decimal, ref long Quinary)
        {
            long p = 1, i = 1, j, d;
            for (j = Binary; j > 0; j = j / 10)
            {
                d = j % 10;
                if (i == 1)
                    p = p * 1;
                else
                    p = p * 2;
                Decimal = Decimal + (d * p);
                i++;
            }
            i = 1;
            for (j = Decimal; j > 0; j = j / 5)
            {
                Quinary = Quinary + (j % 5) * i;
                i = i * 10;
                Binary = Binary / 5;
            }
        }
        private static void BinaryToSenary(ref long Binary, ref long Decimal, ref long Senary)
        {
            long p = 1, i = 1, j, d;
            for (j = Binary; j > 0; j = j / 10)
            {
                d = j % 10;
                if (i == 1)
                    p = p * 1;
                else
                    p = p * 2;
                Decimal = Decimal + (d * p);
                i++;
            }
            i = 1;
            for (j = Decimal; j > 0; j = j / 6)
            {
                Senary = Senary + (j % 6) * i;
                i = i * 10;
                Binary = Binary / 6;
            }
        }
        private static void BinaryToSeptenary(ref long Binary, ref long Decimal, ref long Septenary)
        {
            long p = 1, i = 1, j, d;
            for (j = Binary; j > 0; j = j / 10)
            {
                d = j % 10;
                if (i == 1)
                    p = p * 1;
                else
                    p = p * 2;
                Decimal = Decimal + (d * p);
                i++;
            }
            i = 1;
            for (j = Decimal; j > 0; j = j / 7)
            {
                Septenary = Septenary + (j % 7) * i;
                i = i * 10;
                Binary = Binary / 7;
            }
        }
        private static void BinaryToOctal(ref long Binary, ref long Decimal, ref long Octal)
        {
            long p = 1, i = 1, j, d;
            for (j = Binary; j > 0; j = j / 10)
            {
                d = j % 10;
                if (i == 1)
                    p = p * 1;
                else
                    p = p * 2;
                Decimal = Decimal + (d * p);
                i++;
            }
            i = 1;
            for (j = Decimal; j > 0; j = j / 8)
            {
                Octal = Octal + (j % 8) * i;
                i = i * 10;
                Binary = Binary / 8;
            }
        }
        private static void BinaryToNonary(ref long Binary, ref long Decimal, ref long Nonary)
        {
            long p = 1, i = 1, j, d;
            for (j = Binary; j > 0; j = j / 10)
            {
                d = j % 10;
                if (i == 1)
                    p = p * 1;
                else
                    p = p * 2;
                Decimal = Decimal + (d * p);
                i++;
            }
            i = 1;
            for (j = Decimal; j > 0; j = j / 9)
            {
                Nonary = Nonary + (j % 9) * i;
                i = i * 10;
                Binary = Binary / 9;
            }
        }
        private static void BinaryToDecimal(ref long Binary, ref long Decimal)
        {
            long p = 1, i = 1, j, d;
            for (j = Binary; j > 0; j = j / 10)
            {
                d = j % 10;
                if (i == 1)
                    p = p * 1;
                else
                    p = p * 2;
                Decimal = Decimal + (d * p);
                i++;
            }
        }
        static void userMenu()
        {
            Console.WriteLine("****************MENU*****************");
            Console.WriteLine("Choice '2' Palindrome");
            Console.WriteLine("Choice '3' Convert To Ternary");
            Console.WriteLine("Choice '4' Convert To Quaternary");
            Console.WriteLine("Choice '5' Convert To Quinary");
            Console.WriteLine("Choice '6' Convert To Senary");
            Console.WriteLine("Choice '7' Convert To Septenary");
            Console.WriteLine("Choice '8' Convert To Octal");
            Console.WriteLine("Choice '9' Convert To Nonary");
            Console.WriteLine("Choice '10'Convert To Decimal");
            Console.WriteLine("Choice '11'Convert To Undecimal");
            Console.WriteLine("Choice '12'Convert To Duodecimal");
            Console.WriteLine("Choice '13'Convert To Tridecimal");
            Console.WriteLine("Choice '14'Convert To Tetradecimal");
            Console.WriteLine("Choice '15'Convert To Pentadecimal");
            Console.WriteLine("Choice '16'Convert To Hexadecimal");
            Console.WriteLine("Choice '17'Exit from Menu");
            Console.WriteLine("*************************************");
        }
        public static string BinaryToUndecimal(Int64 d)
        {
            var r = d % 11;
            string result;
            if (d - r == 0)
                result = ConvertToChar(Convert.ToInt32(r));
            else
                result = BinaryToUndecimal((d - r) / 11) + ConvertToChar(Convert.ToInt32(r));
            return result;
        }
        public static string BinaryToDuodecimal(Int64 d)
        {

            var r = d % 12;
            string result;
            if (d - r == 0)
                result = ConvertToChar(Convert.ToInt32(r));
            else
                result = BinaryToDuodecimal((d - r) / 12) + ConvertToChar(Convert.ToInt32(r));
            return result;
        }
        public static string BinaryToTridecimal(Int64 d)
        {
            var r = d % 13;
            string result;
            if (d - r == 0)
                result = ConvertToChar(Convert.ToInt32(r));
            else
                result = BinaryToTridecimal((d - r) / 13) + ConvertToChar(Convert.ToInt32(r));
            return result;
        }
        public static string BinaryToTetradecimal(Int64 d)
        {
            var r = d % 14;
            string result;
            if (d - r == 0)
                result = ConvertToChar(Convert.ToInt32(r));
            else
                result = BinaryToTetradecimal((d - r) / 14) + ConvertToChar(Convert.ToInt32(r));
            return result;
        }
        public static string BinaryToPentadecimal(Int64 d)
        {
            var r = d % 15;
            string result;
            if (d - r == 0)
                result = ConvertToChar(Convert.ToInt32(r));
            else
                result = BinaryToPentadecimal((d - r) / 15) + ConvertToChar(Convert.ToInt32(r));
            return result;
        }
        public static string BinaryToHexdecimal(Int64 d)
        {
            var r = d % 16;
            string result;
            if (d - r == 0)
                result = ConvertToChar(Convert.ToInt32(r));
            else
                result = BinaryToHexdecimal((d - r) / 16) + ConvertToChar(Convert.ToInt32(r));
            return result;
        }
        public static string ConvertToChar(int n)
        {
            const string alpha = "0123456789ABCDEF";
            return alpha.Substring(n, 1);
        }
        static void Main(string[] args)
        {
            string a = string.Empty;
            int Index = 0;
            string BinaryStr, Undecimal, Duodecimal,
                Tridecimal, Tetradecimal, Pentadecimal, Hexadecimal;
            long Temp, Binary;
            long Ternary = 0;
            long Quaternary = 0;
            long Quinary = 0;
            long Senary = 0;
            long Septenary = 0;
            long Octal = 0;
            long Nonary = 0;
            long Decimal = 0;
            int userChoice = 0;
            do
            {
                userMenu();
                Console.Write("Please Enter a Number:");
                userChoice = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (userChoice)
                {
                    case 2:
                        Console.Write("Enter a Text :");
                        a = Console.ReadLine();

                        char[] temp = a.ToCharArray();
                        Array.Reverse(temp);
                        string b = new string(temp);

                        if (a.ToLower().Equals(b.ToLower()))
                        {
                            Console.WriteLine("Palindrom !");
                        }
                        else
                        {
                            Console.WriteLine("Isn't Palindrom !");
                        }
                        for (int i = 0; i < temp.Length / 2; i++)
                        {
                            if (temp[i] == temp[temp.Length - 1 - i])
                                continue;
                            Console.WriteLine("Remove " + temp[i] + " or " + temp[temp.Length - 1 - i]);
                        }
                        break;
                    case 3:
                        Console.Write("Input a binary number :");
                        Binary = Convert.ToInt32(Console.ReadLine());
                        Temp = Binary;
                        BinaryToTernary(ref Binary, ref Decimal, ref Ternary);
                        Console.Write("\nThe Binary Number : {0}\nThe equivalent Ternary  Number is : {1} \n\n", Temp, Ternary);
                        Console.ReadKey(); break;
                    case 4:
                        Console.Write("Input a binary number :");
                        Binary = Convert.ToInt32(Console.ReadLine());
                        Temp = Binary;
                        BinaryToQuaternary(ref Binary, ref Decimal, ref Quaternary);
                        Console.Write("\nThe Binary Number : {0}\nThe equivalent Quaternary  Number is : {1} \n\n", Temp, Quaternary);
                        Console.ReadKey(); break;
                    case 5:
                        Console.Write("Input a binary number :");
                        Binary = Convert.ToInt32(Console.ReadLine());
                        Temp = Binary;
                        BinaryToQuinary(ref Binary, ref Decimal, ref Quinary);
                        Console.Write("\nThe Binary Number : {0}\nThe equivalent Quinary  Number is : {1} \n\n", Temp, Quinary);
                        Console.ReadKey(); break;
                    case 6:
                        Console.Write("Input a binary number :");
                        Binary = Convert.ToInt32(Console.ReadLine());
                        Temp = Binary;
                        BinaryToSenary(ref Binary, ref Decimal, ref Senary);
                        Console.Write("\nThe Binary Number : {0}\nThe equivalent Senary  Number is : {1} \n\n", Temp, Senary);
                        Console.ReadKey(); break;
                    case 7:
                        Console.Write("Input a binary number :");
                        Binary = Convert.ToInt32(Console.ReadLine());
                        Temp = Binary;
                        BinaryToSeptenary(ref Binary, ref Decimal, ref Septenary);
                        Console.Write("\nThe Binary Number : {0}\nThe equivalent Septenary  Number is : {1} \n\n", Temp, Septenary);
                        Console.ReadKey(); break;
                    case 8:
                        Console.Write("Input a binary number :");
                        Binary = Convert.ToInt32(Console.ReadLine());
                        Temp = Binary;
                        BinaryToOctal(ref Binary, ref Decimal, ref Octal);
                        Console.Write("\nThe Binary Number : {0}\nThe equivalent Octal  Number is : {1} \n\n", Temp, Octal);
                        Console.ReadKey(); break;

                    case 9:

                        Console.Write("Input a binary number :");
                        Binary = Convert.ToInt32(Console.ReadLine());
                        Temp = Binary;
                        BinaryToNonary(ref Binary, ref Decimal, ref Nonary);
                        Console.Write("\nThe Binary Number : {0}\nThe equivalent Nonary  Number is : {1} \n\n", Temp, Nonary);
                        Console.ReadKey(); break;
                    case 10:
                        Console.Write("Input a binary number :");
                        Binary = Convert.ToInt32(Console.ReadLine());
                        Temp = Binary;
                        BinaryToDecimal(ref Binary, ref Decimal);
                        Console.Write("\nThe Binary Number : {0}\nThe equivalent Decimal  Number is : {1} \n\n", Temp, Decimal);
                        Console.ReadKey(); break;
                    case 11:
                        Console.Write("Input a binary number :");
                        BinaryStr = Console.ReadLine();
                        foreach (char Char in BinaryStr.Reverse())
                        {
                            if (Index != 0)
                            {
                                Decimal += Index * 2 * Convert.ToInt32(Char.ToString());
                                Index = Index * 2;
                            }
                            else
                            {
                                Decimal += Convert.ToInt32(Char.ToString());
                                Index++;
                            }
                        }
                        Undecimal = BinaryToUndecimal(Convert.ToInt64(Decimal));
                        Console.WriteLine("Undecimal = " + Undecimal);
                        break;
                    case 12:
                        Console.Write("Input a binary number :");
                        BinaryStr = Console.ReadLine();
                        foreach (char Char in BinaryStr.Reverse())
                        {
                            if (Index != 0)
                            {
                                Decimal += Index * 2 * Convert.ToInt32(Char.ToString());
                                Index = Index * 2;
                            }
                            else
                            {
                                Decimal += Convert.ToInt32(Char.ToString());
                                Index++;
                            }
                        }
                        Duodecimal = BinaryToDuodecimal(Convert.ToInt64(Decimal));
                        Console.WriteLine("Duodecimal = " + Duodecimal);
                        break;
                    case 13:
                        Console.Write("Input a binary number :");
                        BinaryStr = Console.ReadLine();
                        foreach (char Char in BinaryStr.Reverse())
                        {
                            if (Index != 0)
                            {
                                Decimal += Index * 2 * Convert.ToInt32(Char.ToString());
                                Index = Index * 2;
                            }
                            else
                            {
                                Decimal += Convert.ToInt32(Char.ToString());
                                Index++;
                            }
                        }
                        Tridecimal = BinaryToTridecimal(Convert.ToInt64(Decimal));
                        Console.WriteLine("Tridecimal = " + Tridecimal);
                        break;
                    case 14:
                        Console.Write("Input a binary number :");
                        BinaryStr = Console.ReadLine();
                        foreach (char Char in BinaryStr.Reverse())
                        {
                            if (Index != 0)
                            {
                                Decimal += Index * 2 * Convert.ToInt32(Char.ToString());
                                Index = Index * 2;
                            }
                            else
                            {
                                Decimal += Convert.ToInt32(Char.ToString());
                                Index++;
                            }
                        }
                        Tetradecimal = BinaryToTetradecimal(Convert.ToInt64(Decimal));
                        Console.WriteLine("Tetradecimal = " + Tetradecimal);
                        break;
                    case 15:
                        Console.Write("Input a binary number :");
                        BinaryStr = Console.ReadLine();
                        foreach (char Char in BinaryStr.Reverse())
                        {
                            if (Index != 0)
                            {
                                Decimal += Index * 2 * Convert.ToInt32(Char.ToString());
                                Index = Index * 2;
                            }
                            else
                            {
                                Decimal += Convert.ToInt32(Char.ToString());
                                Index++;
                            }
                        }
                        Pentadecimal = BinaryToPentadecimal(Convert.ToInt64(Decimal));
                        Console.WriteLine("Pentadecimal = " + Pentadecimal);
                        break;
                    case 16:
                        Console.Write("Input a binary number :");
                        BinaryStr = Console.ReadLine();
                        foreach (char Char in BinaryStr.Reverse())
                        {
                            if (Index != 0)
                            {
                                Decimal += Index * 2 * Convert.ToInt32(Char.ToString());
                                Index = Index * 2;
                            }
                            else
                            {
                                Decimal += Convert.ToInt32(Char.ToString());
                                Index++;
                            }
                        }
                        Hexadecimal = BinaryToHexdecimal(Convert.ToInt64(Decimal));
                        Console.WriteLine("Hexadecimal = " + Hexadecimal);
                        break;
                }

            } while (userChoice == 17);


        }
    }

}
