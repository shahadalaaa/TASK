using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probability
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Number Items :");
            int NumberSize = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Your Items :");
            double[] Numbers = new double[NumberSize];
            for (int i = 0; i < Numbers.Length; i++)
            {

                Numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(Numbers);
        
            double Median;
            if (NumberSize % 2 != 0)
            {

                Median = Numbers[NumberSize/ 2];

                Console.WriteLine("median" + Median);
            }
            else
            {
                Median = (Numbers[(NumberSize / 2 - 1)] + Numbers[(NumberSize / 2)]) / 2;
                Console.WriteLine("median" + Median);
            }

            double range = Numbers.Last() - Numbers.First();
            Console.WriteLine("range" + range);


            int FirstQuartileIndex = (int)Math.Floor((double)NumberSize / 4);

            double FirstQuartile;
            if (NumberSize % 4 == 0)
            {
                FirstQuartile = (Numbers[FirstQuartileIndex - 1] + Numbers[FirstQuartileIndex]) / 2;
                Console.WriteLine("Q1=" + FirstQuartile);
                
            }
            else
            {
                FirstQuartile = Numbers[FirstQuartileIndex];
                Console.WriteLine("Q1=" + FirstQuartile);
               
            }

            int ThirdQuartileIndex = (int)Math.Ceiling((double)NumberSize * 3 / 4);
            double ThirdQuartile;
            if (NumberSize % 4 == 0)
            {
                ThirdQuartile = (Numbers[ThirdQuartileIndex - 1] + Numbers[ThirdQuartileIndex]) / 2;
                Console.WriteLine("Q3=" + ThirdQuartile);


            }

            else
            {
                ThirdQuartile = Numbers[ThirdQuartileIndex];
                Console.WriteLine("Q3=" + ThirdQuartile);


            }
            double interquartile = ThirdQuartile - FirstQuartile;
            Console.WriteLine("interquartile" + interquartile);
            double lowerBound = FirstQuartile - (1.5 * interquartile);

            double upperBound = ThirdQuartile + (1.5 * interquartile);
            Console.WriteLine("Outlier Region Boundaries:" + lowerBound + upperBound);
            int counter = 0;
            int max = 0;
           
            double mode = 0;
            double[] U = new double[Numbers.Length];
            Array.Copy(Numbers, U, Numbers.Length);
            for (int i = 0; i < Numbers.Length; i++)
            {
                counter = 0;
               
                for (int p = 0; p < Numbers.Length; p++)
                {
                    if (Numbers[i] == U[p])
                    {
                        counter++; 
                    }
                    if (counter >= 2)
                    {
                        if (counter > max)
                        {
                            max = counter;
                            mode = Numbers[i]; 
                        }

                    }
                }
            }
            if (max >= 2)
            {
                Console.WriteLine("mode is :" + mode);
            }
            else
            {
                Console.WriteLine("there is no mode ");
            }


            double P90 =
            NumberSize % .9;
            Console.WriteLine(P90);


        }


    }
}

