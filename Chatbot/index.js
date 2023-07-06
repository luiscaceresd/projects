const fs = require('fs');

fs.readFile('response2.json', 'utf-8', (err, data) => {
    if (err) {
        console.error('An error occurred:', err);
        return;
    }
    let parsedData = JSON.parse(data); // parse the data as JSON

    function getUrlAndTitle(obj) {
        let resultsArray = obj.results.map(item => {
            return item.public_url;
        });
        return resultsArray;
    }

    let result = getUrlAndTitle(parsedData);

    fs.writeFile('results2.json', JSON.stringify(result, null, 2), err => {
        if (err) {
            console.error('An error occurred:', err);
            return;
        }
        console.log('Results saved to results.json');
    });
});
