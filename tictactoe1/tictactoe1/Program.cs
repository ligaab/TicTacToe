


using static tictactoe1.Game;
using static tictactoe1.Player;

Console.WriteLine("Laipni lugts spele TicTacToe");

tictactoe1.Player diferntPlayer = tictactoe1.Player.Player1;

char charValue = (char)Player1;
Console.WriteLine($"Spēlētājs 1 ir {charValue}");

char charValue2 = (char)Player2;
Console.WriteLine($"Spēlētājs 2 ir {charValue2}");


    Console.WriteLine("Katram speletajam ir simbols X vai O. Uzvar tas kurs pirmais savac tris vienadus simbolus rinda, kolonna, pa diognali");
    Console.WriteLine();
    Console.WriteLine();







do
{
   
    Console.WriteLine("speletaja 1 gajiens");
    step = int.Parse(Console.ReadLine());
    pos[step] = "X";
    bool correctInput = true;
    Console.Clear();
    DrawBoard();

    flag = CheckWin();
    

    Console.WriteLine("speletaja 2 gajiens");
    step = int.Parse(Console.ReadLine());
    pos[step] = "O";
    bool correctInput1 = true;
    Console.Clear();
    DrawBoard();

    flag = CheckWin();
    
}
while (flag !=1 && flag != -1);

if (flag == 1)
{
    Console.WriteLine($"Player  {charValue} has von");

}
else if (flag == 0)
{
    Console.WriteLine("player has von");

}
else
{
    Console.WriteLine("DrawBoard");
}


// jāizveido pārbaudes katrai rindai ar uzvaru
// spēles nobeigums










