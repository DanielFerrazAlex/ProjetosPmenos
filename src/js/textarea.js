document.querySelector('#cpf')
    .addEventListener('keydown', cpf, false);

function cpf(){
    var resultado = cpf.replace(/(\d{3})(\d{3})(\d{3})(\d{2})/, "$1.$2.$3-$4");
    return resultado;
}
