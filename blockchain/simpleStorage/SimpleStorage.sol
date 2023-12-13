// SPDX-License-Identifier: MIT
pragma solidity ^0.8.18; //stating our version

contract SimpleStorage {
    // favoriteNumber gets initialized to 0 by default
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

    function store(uint256 _favoriteNumber) public {
        myFavoriteNumber = _favoriteNumber;
    }

    //view, pure => don't need a transaction to call, view state. We cannot modify anything here
    //calling view or pure function only cost gas when a gas cost transaction is calling them
    function retrieve() public view returns(uint256) {
        return myFavoriteNumber;
    }

    function addPerson( uint256 _favoriteNumber, string memory _name) public {
        listOfPeople.push(Person(_favoriteNumber, _name));
    }
}