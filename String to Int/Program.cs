﻿using System;

namespace String_to_Int
{
    internal class Program
    {
        public static int MyAtoi(string s)
        {
            var isNumStarted = false;
            var isNegative = false;
            var result = 0;

            var c = 0;
            while (c++ < s.Length)
            {
                var ch = s[c - 1];
                if (ch == ' ' && !isNumStarted)
                {
                    continue;
                }

                if (ch == '0' && !isNumStarted)
                {
                    isNumStarted = true;
                    continue;
                }

                if (ch == '-' && !isNumStarted)
                {
                    isNumStarted = true;
                    isNegative = true;
                    continue;
                }

                if (ch == '+' && !isNumStarted)
                {
                    isNumStarted = true;
                    continue;
                }

                if (
                    ch == '0' ||
                    ch == '1' ||
                    ch == '2' ||
                    ch == '3' ||
                    ch == '4' ||
                    ch == '5' ||
                    ch == '6' ||
                    ch == '7' ||
                    ch == '8' ||
                    ch == '9'
                )
                {
                    isNumStarted = true;

                    if (isNegative)
                    {
                        checked
                        {
                            try
                            {
                                result = result * 10 - (int)char.GetNumericValue(ch);
                            }
                            catch (OverflowException)
                            {
                                return int.MinValue;
                            }
                        }
                    }
                    else
                    {
                        checked
                        {
                            try
                            {
                                result = result * 10 + (int)char.GetNumericValue(ch);
                            }
                            catch (OverflowException)
                            {
                                return int.MaxValue;
                            }
                        }
                    }
                }
                else
                {
                    break;
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
           Console.WriteLine(MyAtoi("  -42"));
        }
    }
}
