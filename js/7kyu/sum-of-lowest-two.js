// Create a function that returns the sum of the two lowest positive numbers given an array of minimum 4 positive integers. No floats or non-positive integers will be passed.

// For example, when an array is passed like [19, 5, 42, 2, 77], the output should be 7.

// [10, 343445353, 3453445, 3453545353453] should return 3453455.
// Arrays
// Fundamentals


function sumTwoSmallestNumbers(numbers) {  
    //p array of num
  //   r sum of min two
  //   sort and then add index 0 and 1
    numbers.sort((a,b) => a-b)
    return (numbers[0] + numbers[1])
  }


 
  function sumTwoSmallestNumbers(numbers) {
    if( numbers.length < 2 ) return 0;
    
    let minA = numbers[0] < numbers[1] ? numbers[0] : numbers[1],
        minB = numbers[1] == minA ? numbers[0] : numbers[1];
    
    for(let i=2; i<numbers.length; i++){
      if(numbers[i] < minA){
        minB = minA;
        minA = numbers[i];
      }
      else if(numbers[i] < minB){
        minB = numbers[i];
      }
    }
    
    return minA + minB;
  } 