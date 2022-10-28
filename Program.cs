namespace SieveOfEratosthenesCS;

class Program {
    static void Main(string[] args) {
        ulong end;
        long startTick, endTick;

        for (long i = 0; i < 37; i++) {
            end = (ulong)Math.Pow(2, i);

            startTick = DateTime.Now.Ticks;
            SieveOfEratosthenesUlong sieveUlong = new SieveOfEratosthenesUlong(end);
            endTick = DateTime.Now.Ticks;

            Console.WriteLine("[ulong] sieved {0} in {1} ms, found {2} primes", end, (endTick - startTick) / 10000d, sieveUlong.CountPrimes());

            startTick = DateTime.Now.Ticks;
            SieveOfEratosthenesUint sieveUint = new SieveOfEratosthenesUint(end);
            endTick = DateTime.Now.Ticks;

            Console.WriteLine("[uint]  sieved {0} in {1} ms, found {2} primes", end, (endTick - startTick) / 10000d, sieveUint.CountPrimes());
        }
    }
}