let value_cpf = document.querySelector('#campo_cpf')
  .addEventListener(onclick ="href.location='http://127.0.0.1:5500/page2.html'");

 value_cpf.addEventListener("keydown", function() {
   if (key > "a" && key < "z") {
     preventDefault();
   }
 });
value_cpf.addEventListener("blur", function() {
     let validar_cpf = this.value.replace( /\D/g , "");

     if (validar_cpf.length==11){
      var Soma;
      var Resto;

      Soma = 0;
      for (i=1; i<=9; i++) Soma = Soma + parseInt(validar_cpf.substring(i-1, i)) * (11 - i);
         Resto = (Soma * 10) % 11;

      if ((Resto == 10) || (Resto == 11))  Resto = 0;
      if (Resto != parseInt(validar_cpf.substring(9, 10)) ) return alert("CPF Inválido!");

      Soma = 0;
      for (i = 1; i <= 10; i++) Soma = Soma + parseInt(validar_cpf.substring(i-1, i)) * (12 - i);
      Resto = (Soma * 10) % 11;

      if ((Resto == 10) || (Resto == 11))  Resto = 0;
      if (Resto != parseInt(validar_cpf.substring(10, 11) ) ) return alert("CPF Inválido!");

     } 
     else {
       alert("CPF Inválido! É esperado 11 dígitos numéricos.")
     }   

 })
