using System;

namespace IO2_TDD_Kata
{
    public class StringCalculator
    {

        public int Parse(string text)
        {
            if(null==text)
            {
                return 0;
            }

            int sum = 0;
            var potentialNumbers = text.Split(new char[] { ',', '\n' });
            foreach (var num in potentialNumbers)
            {
                var value = int.Parse(num);
                if(value<0)
                {
                    throw new ArgumentException("All numbers should be >= 0");
                }
                if(value>1000)
                {
                    value = 0;
                }
                sum += value;
            }
            return sum;
        }
    }
}
