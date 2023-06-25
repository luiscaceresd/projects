const car = {
  engine: true,
  steering: true,
  speed: "slow"
}
const sportsCar = Object.create(car)
sportsCar.speed = 'fast'
console.log('The sportcar object: ', sportsCar)

for(prop of Object.keys(sportsCar)){
  console.log(prop + ': ' + sportsCar[prop])
}


