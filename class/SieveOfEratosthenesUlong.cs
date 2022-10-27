using System.Numerics;

namespace SieveOfEratosthenesCS;

class SieveOfEratosthenesUlong {
    public ulong[] Sieve;
    public ulong Length;
    const int bpe = 64; // bits per element

    public SieveOfEratosthenesUlong(ulong end) {
        if (end < 3) {
            Sieve = new ulong[0];
            Length = 0;
            return;
        }

        Length = (end - 3) / 2;
        Sieve = new ulong[Length / bpe + 1];

        ulong lengthSqrt = (ulong)Math.Sqrt(Length);

        for (ulong i = 0; i < lengthSqrt; i++) {
            if ((Sieve[i / bpe] & (1ul << (int)(i % bpe))) == 0) {
                ulong realNumber = (i * 2) + 3;
                for (ulong j = i + realNumber * (i + 1); j < Length; j += realNumber)
                    Sieve[j / bpe] |= 1ul << (int)(j % bpe);
            }
        }
    }

    public ulong CountPrimes() {
        ulong count = 0;
        for (ulong i = 0; i < (ulong)Sieve.Length; i++)
            count += (ulong)BitOperations.PopCount(Sieve[i]);
        return Length - count + 1;
    }

    public ulong[] ToPrimeArray() {
        ulong[] primeArray = new ulong[CountPrimes()];
        ulong index = 0;

        for (ulong i = 0; i < Length; i++) {
            if ((Sieve[i / bpe] & (1ul << (int)(i % bpe))) == 0) {
                primeArray[index] = (i * 2) + 3;
                index++;
            }
        }

        return primeArray;
    }
}