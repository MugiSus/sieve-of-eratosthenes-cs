namespace SieveOfEratosthenesCS;

class SieveOfEratosthenesBool {
    public bool[] Sieve;
    public ulong Length;

    public SieveOfEratosthenesBool(ulong end) {
        if (end < 2) {
            Sieve = new bool[0];
            Length = 0;
            return;
        }

        Length = (end - 3) / 2;
        Sieve = new bool[Length];

        ulong lengthSqrt = (ulong)Math.Sqrt(Length);

        for (ulong i = 0; i < lengthSqrt; i++) {
            if (!Sieve[i]) {
                ulong realNumber = (i * 2) + 3;
                for (ulong j = i + realNumber * (i + 1); j < Length; j += realNumber)
                    Sieve[j] = true;
            }
        }
    }

    public ulong CountPrimes() {
        return Length - (ulong)Sieve.Count(x => x) + 1;
    }

    public ulong[] ToPrimeArray() {
        ulong[] primeArray = new ulong[CountPrimes()];
        int index = 0;

        for (ulong i = 0; i < Length; i++) {
            if (!Sieve[i]) {
                primeArray[index] = (i * 2) + 3;
                index++;
            }
        }

        return primeArray;
    }

    public bool IsPrime(ulong n) {
        if (n == 2) 
            return true;
        else if (n % 2 == 0 || n < 2) 
            return false;
        else
            return !Sieve[(n - 3) / 2];
    }
}