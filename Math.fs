module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.

let collatz n =
  let rec iter (i:int) (n:int64) : int =
    if n = 1 then i
    elif n % 2L = 0 then iter (i+1) (n/2L)
    else iter (i+2) ((3L * n + 1L) / 2L)
  iter 0 n
