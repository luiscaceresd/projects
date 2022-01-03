let saveEl = document.getElementById("save-el")
let countEl = document.getElementById("count-el")
let count = 0

function increment() {
    count += 1
    countEl.textContent = count
}

function decrement() {
    count >= 1 ? count += -1 : console.log('You cannot count negative numbers!')
    countEl.textContent = count
}

function save() {
    let countStr = count + " - "
    saveEl.textContent += countStr
}

function reset(){
    count = 0
    countEl.textContent = count
    saveEl.textContent = "Previous entries: "
}

console.log("Let's count people on the subway!")