// Complete the function/method so that it returns the url with anything after the anchor (#) removed.
// Examples

// "www.codewars.com#about" --> "www.codewars.com"
// "www.codewars.com?page=1" -->"www.codewars.com?page=1"

function removeUrlAnchor(url){
    return url.split('#')[0];
  }

  function removeUrlAnchor(url){
    let urlN = url.split('')
    let target = urlN.indexOf('#')
    if(urlN.includes('#')){
         return urlN.splice(0,target).join('')}
         else return url
  }