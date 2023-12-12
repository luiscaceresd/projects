// SPDX-License-Identifier: MIT
pragma solidity ^0.8.18; //stating our version

contract SimpleStorage {
    //Basic Types: boolean, uint (+), int(+ or -), address, bytes
    bool hasFavoriteNumber = true;
    uint256 favoriteNumber = 88;
    int256 favoriteNum = -88;
    string favoriteNumberInText = "eighty-eight";
    address myAddress = 0x0CBee4Abc3443810670256e1373c32857C3cCC93;
    bytes32 favoriteBytes = "cat";
}