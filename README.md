# Sieve of Eratosthenes in C#

This is a simple implementation of the Sieve of Eratosthenes in C#.

## Results

### Console
```
[uint]  sieved 1 in 0.139 ms, found 1 primes
[ulong] sieved 1 in 227.119 ms, found 1 primes
[uint]  sieved 2 in 0 ms, found 1 primes
[ulong] sieved 2 in 0.001 ms, found 1 primes
[uint]  sieved 4 in 0.001 ms, found 1 primes
[ulong] sieved 4 in 0 ms, found 1 primes
[uint]  sieved 8 in 0 ms, found 3 primes
[ulong] sieved 8 in 0.001 ms, found 3 primes
[uint]  sieved 16 in 0 ms, found 6 primes
[ulong] sieved 16 in 0 ms, found 6 primes
[uint]  sieved 32 in 0 ms, found 10 primes
[ulong] sieved 32 in 0.001 ms, found 10 primes
[uint]  sieved 64 in 0.001 ms, found 18 primes
[ulong] sieved 64 in 0 ms, found 18 primes
[uint]  sieved 128 in 0 ms, found 30 primes
[ulong] sieved 128 in 0 ms, found 30 primes
[uint]  sieved 256 in 0.001 ms, found 54 primes
[ulong] sieved 256 in 0 ms, found 54 primes
[uint]  sieved 512 in 0.001 ms, found 97 primes
[ulong] sieved 512 in 0.001 ms, found 97 primes
[uint]  sieved 1024 in 0.002 ms, found 172 primes
[ulong] sieved 1024 in 0.002 ms, found 172 primes
[uint]  sieved 2048 in 0.003 ms, found 309 primes
[ulong] sieved 2048 in 0.003 ms, found 309 primes
[uint]  sieved 4096 in 0.006 ms, found 564 primes
[ulong] sieved 4096 in 0.006 ms, found 564 primes
[uint]  sieved 8192 in 0.013 ms, found 1027 primes
[ulong] sieved 8192 in 0.016 ms, found 1027 primes
[uint]  sieved 16384 in 0.027 ms, found 1900 primes
[ulong] sieved 16384 in 0.027 ms, found 1900 primes
[uint]  sieved 32768 in 0.056 ms, found 3512 primes
[ulong] sieved 32768 in 0.056 ms, found 3512 primes
[uint]  sieved 65536 in 0.116 ms, found 6542 primes
[ulong] sieved 65536 in 0.117 ms, found 6542 primes
[uint]  sieved 131072 in 0.239 ms, found 12250 primes
[ulong] sieved 131072 in 0.241 ms, found 12250 primes
[uint]  sieved 262144 in 0.497 ms, found 23000 primes
[ulong] sieved 262144 in 0.497 ms, found 23000 primes
[uint]  sieved 524288 in 1.03 ms, found 43389 primes
[ulong] sieved 524288 in 1.077 ms, found 43389 primes
[uint]  sieved 1048576 in 2.121 ms, found 82025 primes
[ulong] sieved 1048576 in 2.153 ms, found 82025 primes
[uint]  sieved 2097152 in 5.462 ms, found 155611 primes
[ulong] sieved 2097152 in 4.441 ms, found 155611 primes
[uint]  sieved 4194304 in 9.225 ms, found 295947 primes
[ulong] sieved 4194304 in 9.246 ms, found 295947 primes
[uint]  sieved 8388608 in 19.098 ms, found 564163 primes
[ulong] sieved 8388608 in 18.984 ms, found 564163 primes
[uint]  sieved 16777216 in 40.648 ms, found 1077871 primes
[ulong] sieved 16777216 in 39.016 ms, found 1077871 primes
[uint]  sieved 33554432 in 77.525 ms, found 2063689 primes
[ulong] sieved 33554432 in 79.231 ms, found 2063689 primes
[uint]  sieved 67108864 in 157.855 ms, found 3957809 primes
[ulong] sieved 67108864 in 159.976 ms, found 3957809 primes
[uint]  sieved 134217728 in 343.546 ms, found 7603553 primes
[ulong] sieved 134217728 in 345.356 ms, found 7603553 primes
[uint]  sieved 268435456 in 761.607 ms, found 14630843 primes
[ulong] sieved 268435456 in 776.166 ms, found 14630843 primes
[uint]  sieved 536870912 in 2228.986 ms, found 28192750 primes
[ulong] sieved 536870912 in 2407.7 ms, found 28192750 primes
[uint]  sieved 1073741824 in 5945.697 ms, found 54400028 primes
[ulong] sieved 1073741824 in 5424.479 ms, found 54400028 primes
[uint]  sieved 2147483648 in 13569.35 ms, found 105097564 primes
[ulong] sieved 2147483648 in 12456.194 ms, found 105097564 primes
[uint]  sieved 4294967296 in 27051.732 ms, found 203280221 primes
[ulong] sieved 4294967296 in 28320.041 ms, found 203280221 primes
[uint]  sieved 8589934592 in 55885.572 ms, found 393615806 primes
[ulong] sieved 8589934592 in 55454.359 ms, found 393615806 primes
[uint]  sieved 17179869184 in 121964.35 ms, found 762939111 primes
[ulong] sieved 17179869184 in 123207.04 ms, found 762939111 primes
[uint]  sieved 34359738368 in 246910.048 ms, found 1480206279 primes
[ulong] sieved 34359738368 in 248573.688 ms, found 1480206279 primes
[uint]  sieved 68719476736 in 548106.594 ms, found 2874398515 primes
[ulong] sieved 68719476736 in 524288.602 ms, found 2874398515 primes
```

### Tables

| 2<sup>n</sup> | Sieve Size | ms (uint) | ms (ulong) |
| --- | --- | --- | --- |
| 10 | 1024 | 0.002 | 0.002 |
| 11 | 2048 | 0.003 | 0.003 |
| 12 | 4096 | 0.006 | 0.006 |
| 13 | 8192 | 0.013 | 0.016 |
| 14 | 16384 | 0.027 | 0.027 |
| 15 | 32768 | 0.056 | 0.056 |
| 16 | 65536 | 0.116 | 0.117 |
| 17 | 131072 | 0.239 | 0.241 |
| 18 | 262144 | 0.497 | 0.497 |
| 19 | 524288 | 1.03 | 1.077 |
| 20 | 1048576 | 2.121 | 2.153 |
| 21 | 2097152 | 5.462 | 4.441 |
| 22 | 4194304 | 9.225 | 9.246 |
| 23 | 8388608 | 19.098 | 18.984 |
| 24 | 16777216 | 40.648 | 39.016 |
| 25 | 33554432 | 77.525 | 79.231 |
| 26 | 67108864 | 157.855 | 159.976 |
| 27 | 134217728 | 343.546 | 345.356 |
| 28 | 268435456 | 761.607 | 776.166 |
| 29 | 536870912 | 2228.986 | 2407.7 |
| 30 | 1073741824 | 5945.697 | 5424.479 |
| 31 | 2147483648 | 13569.35 | 12456.194 |
| 32 | 4294967296 | 27051.732 | 28320.041 |
| 33 | 8589934592 | 55885.572 | 55454.359 |
| 34 | 17179869184 | 121964.35 | 123207.04 |
| 35 | 34359738368 | 246910.048 | 248573.688 |
| 36 | 68719476736 | 548106.594 | 524288.602 |