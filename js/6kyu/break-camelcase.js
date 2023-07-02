// Complete the solution so that the function will break up camel casing, using a space between words.
// Example

// "camelCasing"  =>  "camel Casing"
// "identifier"   =>  "identifier"
// ""             =>  ""


function solution(string){
    // p string
    // return string separated at uppercase
    // p make an emtpy string
    let brokenString = ''
    // use for of to comare every letter to its capital
    for (letter of string){
        if (letter === letter.toUpperCase()){
            brokenString += ''  //add space
            brokenString += letter //add letter
        }
    }
}