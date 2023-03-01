// ordem crescente utilizando method Set() e sort()

let lista = [2,9,4,1,5,6,8,14,6,3,3,7,7,5,8]
let unicos = [...new Set(lista)]

unicos.sort(function(a,b){
    if(a > b){
        return 1;
    }
    if(a < b){
        return -1;
    }
});

console.log(unicos);