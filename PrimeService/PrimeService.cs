using System;

namespace PrimeService
{
    public class PrimeService {

        public bool IsPrime(int x) {

            if (x < 2) return false;

            var upper = Math.Floor(Math.Sqrt(x));

            for (int y = 2; y <= upper; y++) {
                if (x % y == 0) return false; 
            }

            return true;
        }
    }
}
