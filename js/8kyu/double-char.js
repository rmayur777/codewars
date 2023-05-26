// Given a string, you have to return a string in which each character (case-sensitive) is repeated once
const doubleChar = (str) => str.split("").map(c => c + c).join("");


// my sol

function doubleChar(str) {
    return str.split('').map(function(a){
      return a+a; 
      }).join('');
  }