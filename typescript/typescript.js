// boolean
var isCool = true;
// number
var age = 55;
// string
var eyeColor = 'brown';
var favoriteQuote = "I'm not old, I'm only ".concat(age);
// arrays
var pets = ['dog', 'cat'];
var pets2 = ['lion', 'dragon'];
// Object
var wizard = {
    a: 'John'
};
// null and undefined
var meh = undefined;
var noo = null;
// Tuple
var basket;
basket = ['ball', 5];
// Enum
var Size;
(function (Size) {
    Size[Size["Small"] = 1] = "Small";
    Size[Size["Medium"] = 2] = "Medium";
    Size[Size["Large"] = 3] = "Large";
})(Size || (Size = {}));
var sizeName = Size.Small;
// Any
var whatever = 'aasdfsadas  sadasdsadsad';
// void
var sing = function () {
    console.log('lalal');
};
// never - never returns or variable is never true or doesn't have an endpoint
var error = function () {
    throw Error('oops');
};
var fightRoboArmy = function (robots) {
    console.log('Fight!');
};
fightRoboArmy({ count: 1, type: 'dragon' });
var fightRoboArmy2 = function (robots) {
    console.log('Fight!');
};
var dog = {};
dog.count;
// Function
var fightRoboArmy3 = function (robots) {
    console.log('Fight!');
};
var fightRoboArmy4 = function (robots) {
    console.log('Fight!');
    return 5;
};
// Class
var Animal = /** @class */ (function () {
    function Animal(sound) {
        this.sing = 'lalalalal';
        this.sing = sound;
    }
    Animal.prototype.greet = function () {
        return "Hello ".concat(this.sing);
    };
    return Animal;
}());
var lion = new Animal("RAAAWR");
lion.sing;
// Union
var confused = "Hello";
var x = 4;
x = 'hello';
