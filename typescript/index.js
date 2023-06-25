let label = jQuery('.car-rental-summary-price-total').html().trim().replace('C','').replace('H','').replace('$','').replace('.','').replace('.','')
let number = parseInt(label)
let monthlyPrice = Math.round(number/365)

function addDots(n){
    var rx=  /(\d+)(\d{3})/;
    return String(n).replace(/^\d+/, function(w){
        while(rx.test(w)){
            w= w.replace(rx, '$1.$2');
        }
        return w;
    });
}

let monthlyPriceDots = addDots(monthlyPrice)
let monthlyPriceString = monthlyPriceDots.toString()
let monthlyPriceStringFinal = 'CH$' + monthlyPriceString

// test it out
console.log(monthlyPriceStringFinal)