usando o sistema;
usando ExemploPOO. Modelos;

namespace ExemploPOO
{
     Programa de classe
    {
        vazio estático Principal(string[] args)
        {
            // Valores válidos
            Retangulo r = novo Retangulo();
            r. DefinirMedidas(30, 30);

            Sistema. Console. WriteLine($"Área: {r. ObterArea()}" );


            // Valores inválidos
            Retangulo r2 = novo Retangulo();
            r2. DefinirMedidas(0, 0);

            Sistema. Console. WriteLine($"Área: {r2. ObterArea()}" );




            // Pessoa p1 = nova Pessoa();

            // p1. Nome = "Bob";
            // p1. Idade = 20;

            // p1. Apresentar();
        }
    }
}
