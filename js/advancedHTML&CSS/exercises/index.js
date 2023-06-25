'use strict';

const fs = require('fs');

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', function(inputStdin) {
    inputString += inputStdin;
});

process.stdin.on('end', function() {
    inputString = inputString.split('\n');

    main();
});

function readLine() {
    return inputString[currentLine++];
}



/*
 * Complete the 'CardNumberAnalyzer' class below.
 * Add as little or as many functions or extra code blocks as you see fit.
 */

class CardNumberAnalyzer {
    constructor(cardNumber) {
        const cardNumberWoSpaces = cardNumber.trim()
        try {
            if((!/^[0-9]+$/.test(cardNumber)) || (!/^[0-9]+$/.test(cardNumber) && !/\s/g.test(cardNumber)) || !cardNumberWoSpaces.length() === 15 || !cardNumberWoSpaces.length() === 16) throw "Not a valid card number"
            if(!cardNumber.charAt(0) === 3 || !cardNumber.charAt(0) === 4 || !cardNumber.charAt(0) === 5) throw "Unknown card brand"
        } catch(err) {
            console.log(err)
        }
        // Store the card number here. Validate its format and throw
        // an error if necessary.
    }
    
    hasValidCardNumberLength() {
        const firstChar = cardNumber.charAt(0)
        let cardNumberExpectedLength = 0
        
        if(firstChar === 3) {
            cardNumberExpectedLength = 15
            if(cardNumberWoSpaces.length === cardNumberExpectedLength){
                return true
            } else {
                return false
            }
        } else if (firstChar === 4 || firstChar === 5) {
            cardNumberExpectedLength = 16
            if(cardNumberWoSpaces.length === cardNumberExpectedLength){
                return true
            } else {
                return false
            }
        }
        // Return true if the card number's length is valid
        // for the card brand that was detected, otherwise false.
    }
    
    getCardDetails() {
        const bin = cardNumberWoSpaces.substring(0,5)        
        let brand = '' 
        let securityCodeExpectedLength = 0
        let securityCodeLocation = ''
        
        if(firstChar === 3) {
            brand = 'american_express'
            securityCodeExpectedLength = 4
             securityCodeLocation = 'front'
        } else if (firstChar === 4) {
            brand = 'visa'
            securityCodeExpectedLength = 4
            securityCodeLocation = 'back'
        } else {
            brand = 'master_card'
            securityCodeExpectedLength = 4
            securityCodeLocation = 'back'
        }
        
        return {
            card: {
                number: `${cardNumberWoSpaces}`,
                bin: `${bin}`,
                brand: `${brand}`,
                expectedLength: `${cardNumberExpectedLength}`,
                isValid: hasValidCardNumberLength(),                
                // Complete this object.
            },
            securityCode: {
                location: `${securityCodeLocation}`,
                expectedLength: `${securityCodeExpectedLength}`
                // Complete this object.
            }
        }
    }
}
        const creditCard = new CardNumberAnalyzer("8000 8000 8000 8000");