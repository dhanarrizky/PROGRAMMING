const oddOrEven = (array) => {
    let result = 0
    array.forEach(element => {
        result += element
    });

    return result%2==0 ? "even":"odd"
 }

//  function oddOrEven(arr) {
//     return arr.reduce((a,b)=>a+b,0) % 2 ? 'odd' : 'even';
//   }



console.log(oddOrEven([0]))
// Output: "even"
console.log(oddOrEven([0, 1, 4]))
// Output: "odd"
console.log(oddOrEven([0, -1, -5]))
// Output: "even"




