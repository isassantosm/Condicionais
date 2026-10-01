//Tem que exibir:
//-------------------------- JOKENPÔ ------------------------------
//Escolha sua jogada:
//1 - Pedra 
//2 - Papel
//3 - Tesoura

//Sua opção:


Console.WriteLine("""
------- JOKENPÔ -------
  Escolha sua jogada:
      1 - Pedra
      2 - Papel
      3 - Tesoura
      
""");
Console.Write("sua opção: ");
var opcaoUsuario = Convert.ToUInt32(Console.ReadLine());
while (opcaoUsuario < 1 || opcaoUsuario > 3)
{
 Console.Write("Opção invalida! escolha novamente: ");
 opcaoUsuario = Convert.ToUInt32(Console.ReadLine());
}
var aleatorio = new Random();
int opcaoComputador = aleatorio.Next(1, 4);
// Estrutura Switch-Case
string escolhaUsuarioTexto;
string escolhaComputadorTexto;
switch (opcaoUsuario)
{
    case 1:
        escolhaUsuarioTexto = "Pedra";
        break;
    case 2:
        escolhaUsuarioTexto = "Papel";
        break;
    case 3: 
        escolhaUsuarioTexto = "tesoura";
        break;
    default:
        escolhaUsuarioTexto = "nenhum";
        break;
           
}
switch (opcaoComputador)
{
    case 1:
        escolhaComputadorTexto = "Pedra";
        break;
    case 2:
        escolhaComputadorTexto = "Papel";
        break;
    case 3: 
        escolhaComputadorTexto = "tesoura";
        break;
    default:
        escolhaComputadorTexto = "nenhum";
        break;
        
}


Console.WriteLine($"O usuario escolheu {escolhaUsuarioTexto} e o computador escolheu {escolhaComputadorTexto}");    