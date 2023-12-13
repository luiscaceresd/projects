// SPDX-License-Identifier: MIT
pragma solidity ^0.8.18; //stating our version

contract SimpleStorage {
    // favoriteNumber gets initialized to 0 by default
    uint256 public favoriteNumber;

    function store(uint256 _favoriteNumber) public {
        favoriteNumber = _favoriteNumber;
    }

    //view, pure => don't need a transaction to call, view state. We cannot modify anything here
    //calling view or pure function only cost gas when a gas cost transaction is calling them
    function retrieve() public view returns(uint256) {
        return favoriteNumber;
    }
}