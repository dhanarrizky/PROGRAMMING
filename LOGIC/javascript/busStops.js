function busStops(arr){
    let result = 0;
    for(let i = 0; i < arr.length; i++){
        result += arr[i][0]
        result -= arr[i][1]
    };

    return result;
}

console.log(busStops([[15,0],[2,4],[0,5],[10,2],[4,10],[1,0]]))


