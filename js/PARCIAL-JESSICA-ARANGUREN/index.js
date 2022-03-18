const myInput = document.getElementById("psw")
const letter = document.getElementById("letter")
const capital = document.getElementById("capital")
const number = document.getElementById("number")
const length = document.getElementById("length")
const button = document.getElementById("button")

myInput.onkeyup = function() {
  const lowerCaseLetters = /[a-z]/g
  if(myInput.value.match(lowerCaseLetters)) {
    letter.classList.remove("invalid")
    letter.classList.add("valid")
  } else {
    letter.classList.remove("valid")
    letter.classList.add("invalid")
}

  const upperCaseLetters = /[A-Z]/g
  if(myInput.value.match(upperCaseLetters)) {
    capital.classList.remove("invalid")
    capital.classList.add("valid")
  } else {
    capital.classList.remove("valid")
    capital.classList.add("invalid")
  }

  const numbers = /[0-9]/g
  if(myInput.value.match(numbers)) {
    number.classList.remove("invalid")
    number.classList.add("valid")
  } else {
    number.classList.remove("valid")
    number.classList.add("invalid")
  }

  if(myInput.value.length >= 8) {
    length.classList.remove("medium")
    length.classList.add("valid")
  } else if(myInput.value.length > 4 && myInput.value.length < 8){
    length.classList.remove("invalid")
    length.classList.add("medium")
  } else {
    length.classList.remove("valid")
    length.classList.add("invalid")
  }

  if(myInput.value.match(lowerCaseLetters) && myInput.value.match(upperCaseLetters) && myInput.value.match(numbers) && myInput.value.length >= 8) {
    button.disabled = false
  }
}