function sum(matrix) {
    let n = matrix.length / 2
    let qSums = []
    let maxSum = 0

    function addQ(matrix) {
        for(let i=0; i<n; i++) {
            for(let j=0; j<n; j++) {
                sum += matrix[i][j]
            }
        }
    }

    function reverse(matrix) {
        for(let i=0; i<matrix.length; i++) {
            for(let j=0; j<matrix.length; j++) {
                qSums.push(addQ())
            }
            matrix[i].reverse
            qSums.push(addQ())
        }

        for(let j=0; j<matrix.length; j++) {
            for(let i=0; i<matrix.length; i++) {
                qSums.push(addQ())
            }
            matrix[j].reverse
            qSums.push(addQ())
        }
    }

    reverse()

    maxSum = Math.max(qSums)

    return maxSum
}