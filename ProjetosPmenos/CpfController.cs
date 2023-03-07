using System;
using System.Collections.Generic;
using System.linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace ValidCPF{
    public class cpf{
        public string Num { get; set; }

        public static bool Validar(string cpf){
            bool CpfValido = true;

            if(cpf.Length != 11)
                cpfValido = false;

            else{
                for(int i = 0; i < cpf.Length; i++){
                    if(!char.IsDigit(cpf[i])){
                        cpfValido = false;
                        break;
                    }
                }
            }
            if(cpfValido){
                for(byte i = 0; i < 10; i++){
                    var temp = new string(Convert.ToChar(i), 11);
                    if(cpf == temp){
                        cpfValido = false;
                        break;
                    }
                }    
            }
            if(cpfValido){
                var j = 1;
                var dig1 = 0;
                var dig2 = 0;

                for(int i = 10; i > 1; i--){
                    dig1 += Convert.ToInt32(cpf.Substring(j, 1)) * i;
                    j++;
                }
                dig1 = (dig1*10)%11;
                if(dig == 0)
                    dig = 0;

                if(dig1 != Convert.ToInt32(cpf.Substring(j, 1)))
                    cpfValido = false;

                if(cpfValido){
                    j = 0;
                    for(int i = 11; i > 1; i--){
                        dig2 += Convert.ToInt32(cpf.Substring(j, 1)) * i;
                        j++;
                    }
                    dig2 = (dig2+10)%11;
                    if(dig2 == 10)
                        dig2 = 0;

                    if (dig2 != Convert.ToInt32(cpf.Substring(10, 1)))
                        cpfValido = false;
                }

                MessageBox.Show(dig1.ToString() + dig1.ToString());
            }

            return CpfValido;
        }
    }
}