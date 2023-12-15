// SPDX-License-Identifier: SEE LICENSE IN LICENSE
pragma solidity ^0.8.18;

contract FundMe {

    uint256 public minimumUsd = 5;

    function fund () public payable {
        //reverts if minimum amount isn't 5 USD
        require(msg.value >= minimumUsd, "Didn't send enough ETH");
    }

    // function withdraw () public {

    // }
}