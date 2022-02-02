// Create a function that renders the three team images
// Use a for loop, template strings (``), plus equals (+=)
// .innerHTML to solve the challenge.
let divEl = document.querySelector("#container")
const imgs = [
    "img/hip1.jpg",
    "img/hip2.jpg",
    "img/hip3.jpg"
]

function render(img){
    let imgDOM = ""
    for(let i=0; i<img.length; i++){
        imgDOM += `<img alt="company employee picture" class="team-img" src="${img[i]}">`
    }
    divEl.innerHTML = imgDOM
}

render(imgs)