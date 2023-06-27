// There was a test in your class and you passed it. Congratulations!
// But you're an ambitious person. You want to know if you're better than the average student in your class.

// You receive an array with your peers' test scores. Now calculate the average and compare your score!

// Return True if you're better, else False!
// Note:

// Your points are not included in the array of your class's points. For calculating the average point you may add your point to the given array!

function betterThanAverage(classPoints, yourPoints) {
    //   p array of nums
    //   return if yp > average
    //   find average of class
      let average = (classPoints.reduce((a,b)=> a +b,0) + yourPoints)/(classPoints.length + 1)
    //    console.log(average)
    //   if (yourPoints > average){
    //     return true
    //   }else{
    //     return false
    //   }
       return yourPoints > average ?  true :  false
    }


    function betterThanAverage(classPoints, yourPoints) {
  return yourPoints > classPoints.reduce(function(sum, x){return sum + x},yourPoints)/(classPoints.length+1)
}