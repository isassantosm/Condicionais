//Crie uma variável chamada "idade" e atribua o valor 18 a ela 
var idade = 18;
// Crie uma variável chamda "valorIngresso" e atribua o valor 30.00 a ela 
double valorIngresso = 30.00;
// Crie uma variavel chamada "ehEstudante"
var ehEstudante = true;

var clienteVIP = true;
// Criar um bloco de condiçao testando se a idade e menor ou igual a 7

if (clienteVIP)
{
    valorIngresso *= 0.4;

}
else if (idade <= 7 || idade >= 60 || ehEstudante)
{
        valorIngresso = valorIngresso * 0.5; 
};
//Dentro do bloco da condiçao, voce tera que calcular a metade do valor do ingresso e atribui-lo novamente a variavel "valorIngresso"

//Exiba a informação abaixo:
 Console.Write($"O valor do ingresso a pagar é de R${valorIngresso}");