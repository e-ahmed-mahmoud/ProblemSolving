using System;

namespace ProblemSolving
{
    public class StringNumbersComparison
    {
        //validate if first number is greater than second without convert them. 
        public bool GreaterStringNumber(string num1, string num2)
        {
            try
            {
                //free number from left side zeros
                var adjustNum1 = NumberAdjustment(num1);
                var adjustNum2 = NumberAdjustment(num2);

                if (adjustNum1.Length > adjustNum2.Length)
                    return true;

                else if ((adjustNum1.Length < adjustNum2.Length) || adjustNum1.Length ==0 || adjustNum2.Length == 0)
                    return false;

                else                            //at numbers length is equal
                {
                    for (int i = 0; i < adjustNum1.Length; i++)
                    {
                        if (adjustNum1[i] > adjustNum2[i])      //comparison using unicode
                            return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        //remove extra left side zeros, comparison using unicode
        private char[] NumberAdjustment(string num)
        {
            var adjustNumber = num.Trim().ToCharArray();
            int index = 0;                          //hold start of digits > 0
            for (int i = 0; i < adjustNumber.Length; i++)
            {
                //char is digit and greater than '0' and less than '9' unicode
                if (adjustNumber[i] > '0' && adjustNumber[i] < '9')
                    index = i;

                //if num is char not digit then return empty array which will handle and return false  
                if (adjustNumber[i] > '9')
                    return new[] { ' ' };
            }

            return num.Trim()[index..].ToCharArray();
        }
    }
}
