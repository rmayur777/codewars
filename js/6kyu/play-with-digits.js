// Some numbers have funny properties. For example:

//     89 --> 8¹ + 9² = 89 * 1

//     695 --> 6² + 9³ + 5⁴= 1390 = 695 * 2

//     46288 --> 4³ + 6⁴+ 2⁵ + 8⁶ + 8⁷ = 2360688 = 46288 * 51

// Given a positive integer n written as abcd... (a, b, c, d... being digits) and a positive integer p

//     we want to find a positive integer k, if it exists, such that the sum of the digits of n taken to the successive powers of p is equal to k * n.

// In other words:

//     Is there an integer k such as : (a ^ p + b ^ (p+1) + c ^(p+2) + d ^ (p+3) + ...) = n * k

// If it is the case we will return k, if not return -1.

// Note: n and p will always be given as strictly positive integers.

function digPow(n, p) {
    var x = String(n).split("").reduce((s, d, i) => s + Math.pow(d, p + i), 0)
    return x % n ? -1 : x / n
  }

  // n is turned into a string and then split
  // .reduce((s,d,i)) -> The reduce method executes a user-supplied "reducer" callback function on each element of the array, the final result is a single value(MDN). This reduce method has 3 parameters: s(previous value), d(current value), i(current index)

  //Now for the return x % n ? -1 : x/n -> This is basically saying, if x % n === 0 it means that x/n = k, because at the same time n * k = x. On the contrary, if x % n !== 0 then (n) doesn't have an integer (k) that you can multiply to get as a result x, in that case, -1 is returned.