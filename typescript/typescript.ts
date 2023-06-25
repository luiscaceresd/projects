// boolean
const isCool: boolean = true

// number
let age: number = 55

// string
let eyeColor: string = 'brown'
let favoriteQuote: string = `I'm not old, I'm only ${age}`

// arrays
const pets: string[] = ['dog','cat']
const pets2: Array<string> = ['lion', 'dragon']

// Object

const wizard: object = {
  a: 'John'
}

// null and undefined
const meh: undefined = undefined
const noo: null = null

// Tuple
let basket: [string, number]
basket = ['ball', 5]

// Enum
enum Size { Small = 1, Medium = 2, Large = 3}
let sizeName: number = Size.Small

// Any
const whatever: any = 'aasdfsadas  sadasdsadsad'

// void
let sing = (): void => {
  console.log('lalal')
}

// never - never returns or variable is never true or doesn't have an endpoint
let error = (): never => {
  throw Error('oops')
}

// interface
interface RobotArmy {
  count: number,
  type: string,
  magic?: string
}

let fightRoboArmy = (robots: RobotArmy) => {
  console.log('Fight!')
}

fightRoboArmy({count: 1, type:'dragon'})

let fightRoboArmy2 = (robots: {count: number, type:string, magic: string}) => {
  console.log('Fight!')
}

// type assertions
interface CatArmy {
  count: number,
  type: string,
  magic: string
}

let dog = {} as CatArmy
dog.count

// Function

let fightRoboArmy3 = (robots: RobotArmy): void => {
  console.log('Fight!')
}

let fightRoboArmy4 = (robots: {count: number, type:string, magic: string}): number => {
  console.log('Fight!')
  return 5
}

// Class
class Animal {
  sing: string = 'lalalalal'
  constructor(sound: string) {
    this.sing = sound
  }

  greet() {
    return `Hello ${this.sing}`
  }
}

let lion = new Animal("RAAAWR")
lion.sing

// Union
let confused: string | number = "Hello"

let x = 4
x = 'hello'