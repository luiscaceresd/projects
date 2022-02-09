const path = require('path') // 

function getMessages(req, res) {
  res.render('messages',{
    tittle: 'Messages to my friends',
    friend: 'Elon Musk'
  })
// res.sendFile(path.join(__dirname, '..', 'public','images', 'monkey.png'))
}

function postMessage(req, res) {
  console.log('Updating messages...')
}

module.exports = {
  getMessages,
  postMessage
}