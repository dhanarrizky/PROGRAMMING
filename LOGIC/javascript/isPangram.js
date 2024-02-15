const isPangram = (text) => {
    let character = ['a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z']
    for(let i of text){
        let index = character.indexOf(i.toLowerCase())
        character[index] = null
    }

    let result = false

    for(let i of character){
        if(i == null){
            result = true
        } else {
            result = false
            break
        }
    }

    return result

}

// we can do it too
// const isPangram = (string) => {
//     return 'abcdefghijklmnopqrstuvwxyz'
//       .split('')
//       .every((x) => string.toLowerCase().includes(x));
//   }


console.log(isPangram("The quick brown fox jumps over the lazy dog"))