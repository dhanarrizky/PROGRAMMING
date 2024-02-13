const testEvent = (e) => {
    return e%2===0 ? true:false
}

// can do like this too

// function testEven(n){
//     return !(n % 2);
//   }

console.log(testEvent(-4))
console.log(testEvent(2))
console.log(testEvent(0.5))