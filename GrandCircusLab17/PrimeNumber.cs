using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircusLab17
{
    public class PrimeNumber
    {
        public bool isPrimeNumber(int userNumber)
        {
            int counter = 0;
            for (int i = 2; i < userNumber; i++)
            {
                if (userNumber % i == 0)
                {
                    counter = 1;
                    break;
                }
            }
            if (counter == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
