const materials = [
  {
      "id": 1,
      "name": "Aluminum"
  },
  {
      "id": 2,
      "name": "Brass #2"
  },
  {
      "id": 3,
      "name": "Stainless Steel"
  }
];

const transactions = [
  {
      "materialId": 1,
      "amount": 100,
      "unitPrice": 0.2,
  },
  {
      "materialId": 2,
      "amount": 100.25,
      "unitPrice": 0.21,
  },
  {
      "materialId": 3,
      "amount": 100.5,
      "unitPrice": 0.22,
  },
  {
      "materialId": 1,
      "amount": 100.75,
      "unitPrice": 0.23,
  },
  {
      "materialId": 2,
      "amount": 101,
      "unitPrice": 0.24,
  },
  {
      "materialId": 3,
      "amount": 101.25,
      "unitPrice": 0.25,
  },
  {
      "materialId": 1,
      "amount": 101.5,
      "unitPrice": 0.26,
  },
  {
      "materialId": 2,
      "amount": 101.75,
      "unitPrice": 0.27,
  },
  {
      "materialId": 3,
      "amount": 102,
      "unitPrice": 0.28,
  },
  {
      "materialId": 1,
      "amount": 102.25,
      "unitPrice": 0.29,
  }
];

/*
for each material, provide the following facts for each material, in this form:

{
"Aluminum": {
  "totalSpend": ($)
  "inventoryOnHand": (lb)
  "avgCost": ($/lb)
},
"Brass #2": {
  // same as above
},
"Stainless Steel": {
  // same as above
},
}

Keep in mind that this code should work for arbitrarily many materials, and a different list of transactions.
Eg, don't hardcode any values from above!
*/
function getMaterialAmount(array, id) {
    let sum = 0
    for(a of array) {
        if(a.materialId === id) {
            sum += a.amount
        }
    }
    return sum
}

function getMaterialSales(array, id) {
    let sum = 0
    for(a of array) {
        if(a.materialId === id) {
            sum += a.unitPrice
        }
    }
    return sum
}

returnResults = (materials) => {
    let resultArray = []
    for(material of materials) {
        const name = material.name
        let obj = {
            "totalSpend": ,
            "inventoryOnHand": ,
            "avgCost":
        }
    }
}

const computeAverages = (materials, transactions) => {
    const result = {
    /* Aluminum is just an example */

    };
}

getMaterialAmount(transactions, 1)
getMaterialSales(transactions, 1)

// No need to change the following code, from here down
// This is all we need to do:
// console.log(JSON.stringify(result, null, 2));

// return result;
// }

computeAverages();
