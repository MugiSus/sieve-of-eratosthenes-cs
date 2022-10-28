using System.Numerics;

namespace SieveOfEratosthenesCS;

class SieveOfEratosthenesUint {
    public uint[] Sieve;
    public ulong Length;
    const int bpe = 32; // bits per element

    public SieveOfEratosthenesUint(ulong end) {
        if (end < 3) {
            Sieve = new uint[0];
            Length = 0;
            return;
        }

        Length = (end - 3) / 2;
        Sieve = new uint[Length / bpe + 1];

        ulong lengthSqrt = (ulong)Math.Sqrt(Length);

        for (ulong i = 0; i < lengthSqrt; i++) {
            if ((Sieve[i / bpe] & (1u << (int)(i % bpe))) == 0) {
                ulong realNumber = (i * 2) + 3;
                for (ulong j = i + realNumber * (i + 1); j < Length; j += realNumber)
                    Sieve[j / bpe] |= 1u << (int)(j % bpe);
            }
        }
    }

    public ulong CountPrimes() {
        ulong count = 0;
        for (ulong i = 0; i < (ulong)Sieve.Length; i++)
            count += (ulong)BitOperations.PopCount(Sieve[i]);
        return Length - count + 1;
    }

    public uint[] ToPrimeArray() {
        uint[] primeArray = new uint[CountPrimes()];
        uint index = 0;

        for (ulong i = 0; i < Length; i++) {
            if ((Sieve[i / bpe] & (1u << (int)(i % bpe))) == 0) {
                primeArray[index] = (uint)i * 2 + 3;
                index++;
            }
        }

        return primeArray;
    }
}