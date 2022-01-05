namespace ExemploPOO. Modelos
{
     classe pública Retangulo
    {
        duplo  comprimento privado;
        largura dupla  privada;

        privado bool válido;

         vazio público DefinirMedidas(duplo comprimento, largura dupla largura) {

           se (comprimento > 0 && largura > 0)
           {
            isso. comprimento = comprimento;
            isso. largura = largura; 
            válido = verdadeiro; 
           } 
           mais {
               Sistema. Console. WriteLine("Valores válidos" );
           }
        }

        público dupla ObterArea() {
            se (válido) {
                retorno comprimento * largura;
            }
            mais {
                Sistema. Console. WriteLine("Preencha valores válidos" );
                retorno 0;
            }  
        }
    }
}
