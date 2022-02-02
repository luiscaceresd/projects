// first example

movePlayer(100,'Left')
    .then(()=>movePlayer(400,'Left'))
    .then(()=>movePlayer(10,'right'))
    .then(()=>movePlayer(330,'Left'))

async function playerStar(){
    const first = await movePlayer(100,'Left')
    const second = await movePlayer(400,'Left') //pause
    await movePlayer(10,'right') //pause
    await movePlayer(330,'Left') //pause
}

//second example

async function fetchUsers(){
    const resp = await fetch("https://jsonplaceholder.typicode.com/users")
    const data = await resp.json()
    console.log(data)
}

//third example

const urls = [
    "https://jsonplaceholder.typicode.com/users",
    "https://jsonplaceholder.typicode.com/posts",
    "https://jsonplaceholder.typicode.com/albums"
]

async function getData(){
    try{
        const[users, posts, albums] = await Promise.all(urls.map(url=>
            fetch(url).then(resp=>resp.json())
        ))
        console.log('users', users)
        console.log('posts', posts)
        console.log('albums', albums)
    }catch(error){
        console.log('oops',error)
    }
}