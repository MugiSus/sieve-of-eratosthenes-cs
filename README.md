# Sieve of Eratosthenes in C#

This is a simple implementation of the Sieve of Eratosthenes in C#.

## Results

### Console
```
[uint]  sieved 1 in 227.792 ms, found 1 primes
[uint]  sieved 2 in 0.001 ms, found 1 primes
[uint]  sieved 4 in 0 ms, found 1 primes
[uint]  sieved 8 in 0 ms, found 3 primes
[uint]  sieved 16 in 0 ms, found 6 primes
[uint]  sieved 32 in 0 ms, found 10 primes
[uint]  sieved 64 in 0 ms, found 18 primes
[uint]  sieved 128 in 0.001 ms, found 30 primes
[uint]  sieved 256 in 0.001 ms, found 54 primes
[uint]  sieved 512 in 0.001 ms, found 97 primes
[uint]  sieved 1024 in 0.002 ms, found 172 primes
[uint]  sieved 2048 in 0.003 ms, found 309 primes
[uint]  sieved 4096 in 0.007 ms, found 564 primes
[uint]  sieved 8192 in 0.013 ms, found 1027 primes
[uint]  sieved 16384 in 0.027 ms, found 1900 primes
[uint]  sieved 32768 in 0.06 ms, found 3512 primes
[uint]  sieved 65536 in 0.118 ms, found 6542 primes
[uint]  sieved 131072 in 0.239 ms, found 12250 primes
[uint]  sieved 262144 in 0.487 ms, found 23000 primes
[uint]  sieved 524288 in 1.039 ms, found 43389 primes
[uint]  sieved 1048576 in 2.062 ms, found 82025 primes
[uint]  sieved 2097152 in 4.242 ms, found 155611 primes
[uint]  sieved 4194304 in 9.011 ms, found 295947 primes
[uint]  sieved 8388608 in 18.713 ms, found 564163 primes
[uint]  sieved 16777216 in 38.183 ms, found 1077871 primes
[uint]  sieved 33554432 in 78.783 ms, found 2063689 primes
[uint]  sieved 67108864 in 162.273 ms, found 3957809 primes
[uint]  sieved 134217728 in 327.907 ms, found 7603553 primes
[uint]  sieved 268435456 in 808.792 ms, found 14630843 primes
[uint]  sieved 536870912 in 2241.371 ms, found 28192750 primes
[uint]  sieved 1073741824 in 5404.926 ms, found 54400028 primes
[uint]  sieved 2147483648 in 11813.827 ms, found 105097564 primes
[uint]  sieved 4294967296 in 26358.775 ms, found 203280221 primes
[uint]  sieved 8589934592 in 57891.347 ms, found 393615806 primes
[uint]  sieved 17179869184 in 115117.979 ms, found 5057906407 primes
[uint]  sieved 34359738368 in 240130.263 ms, found 14365108167 primes
[uint]  sieved 68719476736 in 555070.253 ms, found 32939169587 primes
```

```
[ulong] sieved 1 in 228.932 ms, found 1 primes
[ulong] sieved 2 in 0.001 ms, found 1 primes
[ulong] sieved 4 in 0 ms, found 1 primes
[ulong] sieved 8 in 0.001 ms, found 3 primes
[ulong] sieved 16 in 0 ms, found 6 primes
[ulong] sieved 32 in 0 ms, found 10 primes
[ulong] sieved 64 in 0 ms, found 18 primes
[ulong] sieved 128 in 0.001 ms, found 30 primes
[ulong] sieved 256 in 0.001 ms, found 54 primes
[ulong] sieved 512 in 0.001 ms, found 97 primes
[ulong] sieved 1024 in 0.001 ms, found 172 primes
[ulong] sieved 2048 in 0.003 ms, found 309 primes
[ulong] sieved 4096 in 0.006 ms, found 564 primes
[ulong] sieved 8192 in 0.013 ms, found 1027 primes
[ulong] sieved 16384 in 0.027 ms, found 1900 primes
[ulong] sieved 32768 in 0.057 ms, found 3512 primes
[ulong] sieved 65536 in 0.114 ms, found 6542 primes
[ulong] sieved 131072 in 0.251 ms, found 12250 primes
[ulong] sieved 262144 in 0.49 ms, found 23000 primes
[ulong] sieved 524288 in 1.038 ms, found 43389 primes
[ulong] sieved 1048576 in 2.109 ms, found 82025 primes
[ulong] sieved 2097152 in 4.376 ms, found 155611 primes
[ulong] sieved 4194304 in 9.116 ms, found 295947 primes
[ulong] sieved 8388608 in 19.328 ms, found 564163 primes
[ulong] sieved 16777216 in 38.71 ms, found 1077871 primes
[ulong] sieved 33554432 in 79.535 ms, found 2063689 primes
[ulong] sieved 67108864 in 163.466 ms, found 3957809 primes
[ulong] sieved 134217728 in 329.325 ms, found 7603553 primes
[ulong] sieved 268435456 in 751.592 ms, found 14630843 primes
[ulong] sieved 536870912 in 2239.276 ms, found 28192750 primes
[ulong] sieved 1073741824 in 5281.832 ms, found 54400028 primes
[ulong] sieved 2147483648 in 11914.545 ms, found 105097564 primes
[ulong] sieved 4294967296 in 25185.29 ms, found 203280221 primes
[ulong] sieved 8589934592 in 55886.526 ms, found 393615806 primes
[ulong] sieved 17179869184 in 113307.299 ms, found 762939111 primes
[ulong] sieved 34359738368 in 261819.588 ms, found 1480206279 primes
[ulong] sieved 68719476736 in 587293.734 ms, found 2874398515 primes
```

### Tables

| 2<sup>n</sup> | Sieve Size | ms (uint) | ms (ulong) | primes (uint) | primes (ulong) |
|----|----|----|----|----|----|
| 10 | 1024 | 0.002 | 0.001 | 168 | 168 |
| 11 | 2048 | 0.003 | 0.003 | 303 | 303 |
| 12 | 4096 | 0.007 | 0.006 | 561 | 561 |
| 13 | 8192 | 0.013 | 0.013 | 1024 | 1024 |
| 14 | 16384 | 0.027 | 0.027 | 1897 | 1897 |
| 15 | 32768 | 0.06 | 0.057 | 3509 | 3509 |
| 16 | 65536 | 0.118 | 0.114 | 6539 | 6539 |
| 17 | 131072 | 0.239 | 0.251 | 12247 | 12247 |
| 18 | 262144 | 0.487 | 0.49 | 22997 | 22997 |
| 19 | 524288 | 1.039 | 1.038 | 43386 | 43386 |
| 20 | 1048576 | 2.062 | 2.109 | 82022 | 82022 |
| 21 | 2097152 | 4.242 | 4.376 | 155608 | 155608 |
| 22 | 4194304 | 9.011 | 9.116 | 295944 | 295944 |
| 23 | 8388608 | 18.713 | 19.328 | 564160 | 564160 |
| 24 | 16777216 | 38.183 | 38.71 | 1077868 | 1077868 |
| 25 | 33554432 | 78.783 | 79.535 | 2063686 | 2063686 |
| 26 | 67108864 | 162.273 | 163.466 | 3957806 | 3957806 |
| 27 | 134217728 | 327.907 | 329.325 | 7603549 | 7603549 |
| 28 | 268435456 | 808.792 | 751.592 | 14630839 | 14630839 |
| 29 | 536870912 | 2241.371 | 2239.276 | 28192746 | 28192746 |
| 30 | 1073741824 | 5404.926 | 5281.832 | 54400024 | 54400024 |
| 31 | 2147483648 | 11813.827 | 11914.545 | 105097560 | 105097560 |
| 32 | 4294967296 | 26358.775 | 25185.29 | 203280217 | 203280217 |
| 33 | 8589934592 | 57891.347 | 55886.526 | 393615802 | 393615802 |
| 34 | 17179869184 | 115117.979 | 113307.299 | 5057906403 | 762939107 |
| 35 | 34359738368 | 240130.263 | 261819.588 | 14365108163 | 1480206275 |
| 36 | 68719476736 | 555070.253 | 587293.734 | 32939169583 | 2874398511 |
