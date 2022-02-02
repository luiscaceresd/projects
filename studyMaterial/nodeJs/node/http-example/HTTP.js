// const { request } = require('https')
const { get } = require('https')


const req = get('https://www.google.com', (res) => {
  res.on('data', (chunk) => {
    console.log(`Data chunk: ${chunk}`)
  })
  res.on('end', () => {
    console.log('No more data')
  })
})

// req.end() not needed when using get instead of request (only when getting info)