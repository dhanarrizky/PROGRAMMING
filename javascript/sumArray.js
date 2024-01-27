// console.log("test")

const findMax = (arr) => {
    let max = arr[0]
    arr.forEach(element => {
        if(element > max){
            max = element
        }
    });

    return max
}

const findMin = (arr) => {
    let min = arr[0]
    arr.forEach(element => {
        if(element < min){
            min = element
        }
    });

    return min
}


const sumArray = (arr) => {
    if((arr == [ ]) || (arr == null) || (arr.length  == 1)){
        return 0
    }

    let maxVal = findMax(arr)
    let minVal = findMin(arr)
    let result = 0

    // console.log("max val : ",maxVal)
    // console.log("max val : ",minVal)

    for(let element of arr) {
        // if((element != minVal) && (element != maxVal)){
        // console.log(true)
        // }

        // console.log(arr)
        if((element !== minVal) && (element !== maxVal)){
            result += element
            // console.log(result)
        }
        
        if(element == minVal){
            minVal = minVal - 1000
        }
        
        if(element == maxVal){
            maxVal = maxVal +1000
        }
        
    };
    
    // console.log(result)
    return result
}


const test = (val1, val2) => {
    // console.log(val1, " : ", val2)
    return val1 == val2 ? true: false
}

// console.log(sumArray([ 6, 2, 1, 8, 10 ]))

// sumArray([ -6, 20, -1, 10, -12 ])

console.log(test(sumArray(null), 0 ))
console.log(test(sumArray([ ]), 0 ))
console.log(test(sumArray([ 3 ]), 0 ))
console.log(test(sumArray([ 3, 5 ]), 0 ))
console.log(test(sumArray([ 6, 2, 1, 8, 10 ]), 16 ))
console.log(test(sumArray([ 0, 1, 6, 10, 10 ]), 17 ))
console.log(test(sumArray([ -6, -20, -1, -10, -12 ]), -28 ))
console.log(test(sumArray([ -6, 20, -1, 10, -12 ]), 3 ))