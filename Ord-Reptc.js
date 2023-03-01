//ordenar lista e dizer quantas vezes os numeros se repetiram

let lista = [2,9,4,1,5,6,8,14,6,3,3,7,7,5,8]
let unicos = [...new Set(lista)]

for(let i = 0;i< unicos.length;i++){
  contador = 0
  for(let k = 0 ; k < lista.length; k++){
    if(unicos[i]== lista[k]){
      contador = contador +1
    }
  }
  console.log(`O número ${unicos[i]} apareceu ${contador} vezes`);
}