// In this kata you are required to, given a string, replace every letter with its position in the alphabet.

// If anything in the text isn't a letter, ignore it and don't return it.

// "a" = 1, "b" = 2, etc.
// Example

// alphabetPosition("The sunset sets at twelve o' clock.")

// Should return "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11" ( as a string )

function alphabetPosition(text) {
    var result = ""; //create empty strng
    for (var i = 0; i < text.length; i++){ //iterate thrpugh text
      var code = text.toUpperCase().charCodeAt(i) // chatcodat returns utf 16 code
      if (code > 64 && code < 91) result += (code - 64) + " "; // capital code starts at 64 so subtracting with 64 gives position
    }
  
    return result.trim(); // remove space at end
  }