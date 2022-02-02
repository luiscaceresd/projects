// Callback queue - task queue - second priority
setTimeout(() => {
    console.log(1), 0
})
setTimeout(() => {
    console.log(2), 10
})
//2 Job Queue - microtask queue (Higher priority) gets checked first
Promise.resolve('hi').then((data) => {
    console.log('2',data) 
})

//3 gets consoled out immediatly because it is synchronous
    console.log('3','is a crowd')