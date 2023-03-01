//mostrar diagonal principa e diagonal secundaria

let matriz = [[1,2,3],[4,5,6],[7,8,9]];
let dimensao = matriz.length;
let diagonalPrincipal = [];
let diagonalSecundaria = [];

for(let i = 0; i < dimensao; i++){
  diagonalPrincipal.push(matriz[i][i]);
}
for(let i = 0; i < dimensao; i++){
  diagonalSecundaria.push(matriz[i][dimensao - 1 - i]);
}
console.log(`Diagonal principal: ${diagonalPrincipal}`);
console.log(`Diagonal secundária: ${diagonalSecundaria}`);