


using tictactoe1;
using static tictactoe1.Game;
using static tictactoe1.Simbol;




Console.WriteLine("Laipni lugts spele TicTacToe");

HumanPlayer player1 = new HumanPlayer();

player1.GetPlayerName();
player1.Simbol = Simbol.X;

HumanPlayer player2 = new HumanPlayer();
player2.GetPlayerName();
player2.Simbol = Simbol.O;

//tictactoe1.Player diferntPlayer = tictactoe1.Player.Player1;

//char charValue = (char)Player1;
Console.WriteLine($"Spēlētājs 1 ir {player1.Simbol}, tavs vards ir {player1.Name}");

//char charValue2 = (char)Player2;
Console.WriteLine($"Spēlētājs 2 ir {player2.Simbol}, tavs vards ir {player2.Name}");


    Console.WriteLine("Katram speletajam ir simbols X vai O. Uzvar tas kurs pirmais savac tris vienadus simbolus rinda, kolonna, pa diognali");
    Console.WriteLine();
    Console.WriteLine();

DrawBoard();

do
{

    Console.WriteLine("speletaja 1 gajiens");
    step = int.Parse(Console.ReadLine());
    pos[step] = "X";
    
    Console.Clear();
    DrawBoard();
  

    if (flag  !=0)

    {
        break;
    }
    flag = CheckWin();

    input = Game.correctInput();
    if (input == false)
    {
        Console.WriteLine("izvēlies citu skaitli!");
    }
    else if (input == true)
    {
        Console.WriteLine("turpini spēli!");
    }

    Console.WriteLine("speletaja 2 gajiens");
        step = int.Parse(Console.ReadLine());
        pos[step] = "O";
        
        Console.Clear();
        DrawBoard();
    

    flag = CheckWin();

    input = Game.correctInput();
    if (input == false)
    {
        Console.WriteLine("izvēlies citu skaitli!");
    }
    else if (input == true)
    {
        Console.WriteLine("turpini spēli!");
    }

}
while (flag == 0);

    if (flag == 1)
    {
        Console.WriteLine($"Player  {player2.Name} has von");

    }
     if (flag == 2)
    {

        Console.WriteLine($"Player  {player1.Name} has von");

    }
    else
    {
        flag = 0;
    }


//if (input == false)
//{
//    Console.WriteLine("izvēlies citu skaitli!");
//}
//else
//{
//    Console.WriteLine("turpini spēli!");
//}







// jāizveido pārbaudes katrai rindai ar uzvaru
// spēles nobeigums










