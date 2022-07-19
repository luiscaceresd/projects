function getLongestWord(text) {
  let longestWordLength = 0
  let textArr = text.replace(/[^A-Za-z0-9\s]/g, "").split(" ") // removes punctuations and converts text into an array separating by spaces

  sortByLength(textArr)

  //getting the longest word length
  longestWordLength = textArr[0].length 
  //creating an array with longest words found
  let longestWords = textArr.filter((word) => {
    return word.length === longestWordLength
  })

  sortByVowels(longestWords)

  console.log(longestWords[0])
}

// sorts array by length
function sortByLength(array) {
  return array.sort((a,b) => b.length - a.length)
}  

//sorts array by # of vowels
function sortByVowels(array) {
  return array.sort((a,b) => countVowels(b) - countVowels(a))
}  

// counts vowels in a word
function countVowels(word){
  const count = (word.match(/[aeiou]/gi) || []).length //uses gi so it is case insensitive, if not vowel found returns 0
  return count
}

getLongestWord("Smart people learn from everything and everyone, average people from their experience, stupid people already, have all the answers")
getLongestWord("اربك تكست هو اول موقع يسمح لزواره الكرام بتحويل الكتابة العربي الى كتابة مفهومة من قبل اغلب برامج التصميم مثل الفوتوشوب و")
getLongestWord("État-nation ancien, où l'influence de l'Église catholique a longtemps été prééminente, la France a eu un rôle déterminant dans l'histoire mondiale par l'influence de sa culture")
getLongestWord("experiencce!!! expereience!!, stable!!? rice? and apples!!")