// SPDX-License-Identifier: MIT
pragma solidity ^0.8.18; //stating our version

contract SimpleStorage {
    // favoriteNumber gets initialized to 0 by default
    // storage variable because it's outside of a function
    uint256 myFavoriteNumber;
    //uint256[] listOfFavoriteNumbers; // [0, 1, etc]
    struct Person{
        uint256 favoriteNumber;
        string name;
    }

    //dynamic array
    Person[] public listOfPeople; // []

    //static array
    //Person[3] public listOfPeople; // []

    //mapping, dictionary, set of keys with each key returning a special set of information associated to the key
    mapping(string => uint256) public nameToFavoriteNumber;

    function store(uint256 _favoriteNumber) public virtual {
        myFavoriteNumber = _favoriteNumber;
    }

    //view, pure => don't need a transaction to call, view state. We cannot modify anything here
    //calling view or pure function only cost gas when a gas cost transaction is calling them
    function retrieve() public view returns(uint256) {
        return myFavoriteNumber;
    }
    //calldata, memory, storage
    //memory variable can be manipulated, calladata not
    //storage permanent variables that can be modified
    //calldata and memory will only exist temporarily, everytime the function is called, we  cannot  access _name
    //variables within function cannot be storage type
    function addPerson( uint256 _favoriteNumber, string memory _name) public {
        listOfPeople.push(Person(_favoriteNumber, _name));
        nameToFavoriteNumber[_name] = _favoriteNumber;
    }
}