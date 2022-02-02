// web worker is an outside javascript program working outside our main one

const worker = new Worker('worker.js')
worker.postMessage('Helllooooo')

addEventListener('message')

// concurrency (single core cpu) is working with two threads (not at the same time) but with the ability to switch from one to another when there is a pause
// concurrency + parallelism (multicore) -> execute 2 threads at the same time -> not achievable in javascript but it is possible in node

const {spawn} = require('child_process') // spawn a new process
spawn('git',['stuff'])