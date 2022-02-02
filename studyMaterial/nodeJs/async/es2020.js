const promiseOne = new Promise((resolve,reject) =>
    setTimeout(resolve, 3000))

const promiseTwo = new Promise((resolve,reject) =>
    setTimeout(reject, 3000))

 // this executes only if ALL promises are resolved, in this case we should get an error   
promiseOne.all([promiseOne,promiseTwo]).then(data => console.log(data))
    .catch(e => console.log('something failed', e))

// does not care about resolve and reject RUNS ALL PROMISES, it only comes back until all promises are returned
promiseOne.allSettled([promiseOne,promiseTwo]).then(data => console.log(data))
    .catch(e => console.log('something failed', e))