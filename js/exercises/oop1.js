let purchase1 = {
  shoes: 100,
  stateTax: 1.2,
  totalPrice : function() {
    let calculation = this.shoes * this.stateTax
    console.log('Total Price:', calculation)
  }
}

purchase1.totalPrice()

var bird = {
  hasWings: true,
  canFly: true,
  hasFeathers: true
}

var eagle1 = Object.create(bird) // returns eagle1:{}

var penguin1 = Object.create(bird)
penguin1.canFly = false // RETURNS penguin1: {canFly:false}

