const duplicateCount = (text) => {
    let arr = new Map()
    for(let c of text){
        let findC = arr.get(c.toLowerCase())
        if(findC != undefined){
            arr.set(c.toLowerCase(),false)
        } else {
            arr.set(c.toLowerCase(),true)
        }
    }

    // console.log(arr)
    let result = 0
    arr.forEach(val =>{
        if(!val){
            result++
        }
    });

    return result
}

// function duplicateCount(text){
//     return (text.toLowerCase().split('').sort().join('').match(/([^])\1+/g) || []).length;
//   }

console.log(duplicateCount("abcde")) // -> 0 // no characters repeats more than once
console.log(duplicateCount("aabbcde")) // -> 2 // 'a' and 'b'
console.log(duplicateCount("aabBcde")) // -> 2 // 'a' occurs twice and 'b' twice (`b` and `B`)
console.log(duplicateCount("indivisibility")) // -> 1 // 'i' occurs six times
console.log(duplicateCount("Indivisibilities")) // -> 2 // 'i' occurs seven times and 's' occurs twice
console.log(duplicateCount("aA11")) // -> 2 // 'a' and '1'
console.log(duplicateCount("ABBA")) // -> 2 // 'A' and 'B' each occur twice