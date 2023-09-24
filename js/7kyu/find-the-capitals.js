// Write a function that takes a single string (word) as argument. The function must return an ordered list containing the indexes of all capital letters in the string.
// Example (Input --> Output)

// "CodEWaRs" --> [0,3,4,6]

var capitals = function (word) {
	let allCaps = word.toUpperCase().split('')
  let wordArr = word.split('')
  let result = []
  for(let i=0; i< wordArr.length; i++){
      if(allCaps[i] === wordArr[i])
        result.push(i)
  }
  return result
};