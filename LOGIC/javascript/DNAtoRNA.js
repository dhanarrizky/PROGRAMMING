function DNAtoRNA(dna) {
    let result = ''
    for(let element of dna) {
        if(element === 'T') { result += 'U'} else { result += element }
    }
    console.log(result)
}

// // we can use this one too

// // function DNAtoRNA(dna){
// //     return dna.replace(/T/g, 'U');
// //   }

DNAtoRNA("TTTT")
DNAtoRNA("GCAT")
DNAtoRNA("GACCGCCGCC")
