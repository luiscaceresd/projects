const promise = new Promise((resolve, reject)=>{
    if(true){
        resolve('Stuff Worked')
    }
    reject('Error, it broke')
})


const promise2 = new Promise((resolve,reject)=>{    
    setTimeout(resolve, 100, 'HII')
})

const promise3 = new Promise((resolve,reject)=>{
    setTimeout(resolve,1000,'POO')
})

const promise4 = new Promise((resolve,reject)=>{
    setTimeout(resolve,3000,'Whatever')
})

Promise.all([promise, promise2, promise3, promise4])
    .then(values =>{
        console.log(values)
    })

promise
.then(result => result + '!')
.then(result2 => result2 + '?')
.catch(()=>console.log('ERROR'))
.then(result3 => console.log(result3 + '!'))