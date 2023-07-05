// Given a string of digits, you should replace any digit below 5 with '0' and any digit 5 and above with '1'. Return the resulting string.

// Note: input will never be an empty string

function fakeBin(x) {
    return x.split('').map(n => n < 5 ? 0 : 1).join('');
}

function fakeBin(x){
    // p string of nums
    //r string of 0 1
    let str = []
    for(let i = 0; i<x.length; i++){
      if(x[i] < 5){
        str.push(0)
      }else{
        str.push(1)
      }
    }
    return str.join('').toString()
  }