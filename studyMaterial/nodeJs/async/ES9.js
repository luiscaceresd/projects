const animals = {
    tiger: 34,
    lion: 5,
    monkey: 2
}

function objectSpread(p1,p2,p3){
    console.log(p1)
    console.log(p2)
    console.log(p3)
}

const { tiger, lion, ...rest} = animals

objectSpread(tiger,lion,rest)

//finally

const urls = [
    "https://swapi.co/api/people/1",
    "https://swapi.co/api/people/2",
    "https://swapi.co/api/people/3",
    "https://swapi.co/api/people/4"
]

Promise.all(urls.map(url => {
    return fetch(url).then(resp => resp.json())
})).then(results => {
    console.log('1', results[0])
    console.log('2', results[1])
    console.log('3', results[2])
    console.log('4', results[3])
}).catch(err =>console.log('error', err))
.finally(() => console.log('extra'))

// for await of

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

const getData = async function(){
    const promisesArray = urls.map(url => fetch(url))
    for await (promise of promisesArray){
        const data = await promise.json()
        console.log(data)
    }
}
