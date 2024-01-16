using System;
using System.Runtime.CompilerServices;

namespace ClassLibrary1
{
    public class TestModule03
    {
        public int getPositionOf2Cir(int firstRadius, int secRadius, int distance)
        {
            if (distance == 0)
            {
                if (firstRadius == secRadius)
                {
                    return 0;
                }
                else if (firstRadius < secRadius)
                {
                    return 1;
                }
                else if (firstRadius > secRadius)
                {
                    return 2;
                }
            }

            if (distance > 0)
            {
                return 3;
            }
            return -1;
        }
        public char checkValues(int X, int Y, int Z)
        {
            if (X == 1 || X == 2)
            {
                return 'A';
            }
            else
            {
                if (Y <= 10)
                {
                    return 'B';
                }
                else
                {
                    if (Z < 5)
                    {
                        return 'C';
                    }
                    else
                    {
                        return 'D';
                    }
                }
            }
        }
        public int max(int a, int b, int c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                int max = a;
                if (b > max)
                {
                    max = b;
                }
                if (c > max)
                {
                    max = c;
                }
                return max;
            }
            else
            {
                throw new ArgumentException("a, b, and c must be greater than 0");
            }
        }

        public string Triangle(int a, int b, int c)
        {
            int match = 0;
            if (a == b)
                match = match + 1;
            if (a == c)
                match = match + 2;
            if (b == c)
                match = match + 3;
            if (match == 0)
                if ((a + b) <= c)
                    return ("Not a Triangle");
                else if ((b + c) <= a)
                    return ("Not a Triangle");
                else if ((a + c) <= b)
                    return ("Not a Triangle");
                else return ("Triangle is Scalene");
            else if (match == 1)
                    if ((a + c) <= b)
                        return ("Not a Triangle");
                    else return ("Triangle is Isosceles");
                else if (match == 2)
                        if ((a + c) <= b)
                            return ("Not a Triangle");
                        else return ("Triangle is Isosceles");
                    else if (match == 3)
                            if ((b + c) <= a)
                                return ("Not a Triangle");
                            else return ("Triangle is Isosceles");
                    else return ("Triangle is Equilateral");
        }
        public double Average(double Sum, int Count)
        {
            if (Count == 1)
            {
                return Sum;
            }
            else if (Count > 0)
            {
                return Sum / Count;
            }
            else
            {
                return 0.0;
            }
        }
        public int daysInMonth(int year, int month)
        {
            if (month < 1 || month > 12)
            {
                return 0;
            }

            if (month == 2)
            {
                if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
                {
                    return 29; 
                }
                else
                {
                    return 28; 
                }
            }

            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30; 
            }

            return 31;
        }
        public string Solve(float a, float b, float c)
        {
            if (a == 0)
            {
                throw new ArgumentException("Coefficient 'a' cannot be zero");
            }

            float delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                return "no results";
            }
            else if (delta == 0)
            {
                float root = -b / (2 * a);
                return root.ToString(); 
            }
            else
            {
                float root1 = (-b - (float)Math.Sqrt(delta)) / (2 * a);
                float root2 = (-b + (float)Math.Sqrt(delta)) / (2 * a);
                return root1 + ", " + root2;
            }
        }
        public float checkRange(float a, float b, float x)
        {
            if (a > b)
            {
                throw new ArgumentException("a must be less than or equal to b");
            }

            if (x < a)
            {
                return a;
            }
            else if (x > b)
            {
                return b;
            }

            return x;
        }
        public bool isTriangle(float a, float b, float c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return false;
            }

            if (a + b > c && a + c > b && b + c > a)
            {
                return true;
            }

            return false;
        }
        public float[] centerImage(float w, float h, float ww, float wh)
        {
            if (w <= 0 || h <= 0 || ww <= 0 || wh <= 0)
            {
                throw new ArgumentException("Invalid input values");
            }

            float x, y;

            if (w > ww)
            {
                x = 0;
            }
            else
            {
                x = (ww - w) / 2;
            }

            if (h > wh)
            {
                y = 0;
            }
            else
            {
                y = (wh - h) / 2;
            }

            return new float[] { x, y };
        }

    }
}