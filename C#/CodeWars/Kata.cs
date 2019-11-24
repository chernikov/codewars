using System.Numerics;

namespace CodeWars
{
    using System;
    using System.Linq;

    public class TotalIncreasingOrDecreasingNumbers
    {
        //https://www.codewars.com/kata/55b195a69a6cc409ba000053/train/csharp
        public static BigInteger TotalIncDec(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            var inc = new BigInteger[9]; 
            var dec = new BigInteger[9];
            BigInteger total = 10;
            for (int i = 1; i < x; i++)
            {
                for (int index = 0; index < inc.Length; index++)
                {
                    BigInteger sum = 0;
                    for (int range = index; range < inc.Length; range++)
                    {
                        if (range > index)
                        {
                            sum++;
                        }
                        sum += inc[range];
                    }
                    inc[index] = sum;
                }
                for (int index = dec.Length - 1; index >= 0; index--)
                {
                    BigInteger sum = 0;
                    for (int range = index; range >= 0; range--)
                    {
                        if (range <= index)
                        {
                            sum++;
                        }
                        sum += dec[range];
                    }
                    dec[index] = sum;
                }
                total += Sum(inc) + Sum(dec) + 9;
            }
            return total;
        }

        private static BigInteger Sum(BigInteger[] array)
        {
            BigInteger total = 0;
            for (int i = 0; i < array.Length; i++)
            {
                total += array[i];
            }
            return total;
        }
    }
}
