const checkPrims = (num) => {
    if(num === 2){
        return true
    }
    for(let i = 2; i < num; i++){
        if(num%i !== 0){
            return true
            // console.log(num)
            // console.log(true)
        } else {
            // console.log(num)
            // console.log(false)
            return false
        }
    }
}

const divisors = (integer) => {
    let result = []
    for(let i = 2; i < integer ; i++){
        if(integer%i=== 0){
            if(checkPrims(i)){
                result.push(i)
            }
        }
    }
    
    console.log(result)
};


divisors(12); // should return [2,3,4,6]
divisors(25); // should return [5]
divisors(13); // should return "13 is prime"