var carro = {
    Marca : "Ford",
    Modelo : "Ka",
    Caracteristicas : ["Preto", 1.0, "2 portas"],

    exibirDetalhes : function(){
      console.log("Marca: " + this.Marca + " - Modelo: " + this.Modelo + " - Caracteristica: "+ this.Caracteristicas[0]);
    }
}
carro.exibirDetalhes();
