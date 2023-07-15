// The number 898989 is the first integer with more than one digit that fulfills the property partially introduced in the title of this kata. What's the use of saying "Eureka"? Because this sum gives the same number: 89=81+9289 = 8^1 + 9^289=81+92

// The next number in having this property is 135135135:

// See this property again: 135=11+32+53135 = 1^1 + 3^2 + 5^3135=11+32+53
// Task

// We need a function to collect these numbers, that may receive two integers aaa, bbb that defines the range [a,b][a, b][a,b] (inclusive) and outputs a list of the sorted numbers in the range that fulfills the property described above.
// Examples

// Let's see some cases (input -> output):

// 1, 10  --> [1, 2, 3, 4, 5, 6, 7, 8, 9]
// 1, 100 --> [1, 2, 3, 4, 5, 6, 7, 8, 9, 89]

// If there are no numbers of this kind in the range [a,b][a, b][a,b] the function should output an empty list.

// 90, 100 --> []

function sumDigPow(a, b) {
    var arr = []; //make empty array
    for (var i = a; i <= b; i++) { // iterate through the given range of numbers
      var sum = 0; // variable for equation
      for (var j = 0; j < String(i).length; j++) { //iterate through each digit . convert to string 
        sum += Math.pow((String(i)[j]), j+1);  // for every single digit of number check if it passes the equation math.pow(string)(i)[j] is eg '89'[0] => 8,1 and then '89'[1] => 9,2
        if (sum == i) arr.push(i); // if true oush to araray
      }
    }
    return arr;
  }