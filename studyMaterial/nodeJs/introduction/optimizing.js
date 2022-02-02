// inline caching
function findUser(user){
    return `found ${user.firstName} ${user.lastName}`
}

const userData = {
    firstName: 'Johnson',
    lastName: 'Junior'
}

findUser(userData)

// hidden classes - add properties in the constructor and use the same order

function Animal(x,y){
    this.x = x;
    this.y = y;
}

const obj1 = new Animal(1,2);
const obj2 = new Animal (3,4)

obj1.a = 30;
obj1.b = 100
obj2.b = 30;
obj2.a = 100