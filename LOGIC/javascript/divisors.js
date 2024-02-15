const divisors = (integer) => {
    let result = []
    for(let i = 2; i < integer ; i++){
        if(integer%i=== 0){
            result.push(i)
        }
    }
    
    if(result.length === 0){
        return integer + " is prime"
    } else {
        return result
    }
};


console.log(divisors(12)); // should return [2,3,4,6]
console.log(divisors(25)); // should return [5]
console.log(divisors(13)); // should return "13 is prime"