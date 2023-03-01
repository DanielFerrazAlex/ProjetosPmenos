// Mostrar numeros primos em uma lista

listaK = [];
listaP = [];
let numPrimo = 0;
let numDivisores = 0;
for (let i = 0; i < 16; i++) {
    listaK.push(i);
}
for (numPrimo = 0; numPrimo <= listaK.length; numPrimo++) {
    for (let i = 1; i <= numPrimo; i++) {
        if (numPrimo % i == 0) {
            numDivisores++;
        }
    }
    if (numDivisores == 2) {
        listaP.push(numPrimo);
    }
    numDivisores = 0;
}
console.log(listaP);