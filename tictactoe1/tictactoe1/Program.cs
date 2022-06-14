


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

DrawBoard();

do
{

    Console.WriteLine("speletaja 1 gajiens");
    step = int.Parse(Console.ReadLine());
    pos[step] = "X";
    
    Console.Clear();
    DrawBoard();
   
    flag = CheckWin();
    //input = correctInput();
   


    Console.WriteLine("speletaja 2 gajiens");
        step = int.Parse(Console.ReadLine());
        pos[step] = "O";
        
        Console.Clear();
        DrawBoard();
    
    flag = CheckWin();
    //input = correctInput();
      
}
while (flag != 1 && flag != -1 && flag != 2);

    if (flag == 1)
    {
        Console.WriteLine($"Player  {charValue2} has von");

    }
    else if (flag == 2)
    {

        Console.WriteLine($"Player  {charValue} has von");

    }
    else
    {
        flag = 0;
    }


//if (input == true)
//{
//    Console.WriteLine("Izvēlies citu skaitli!");
//}
//else
//{
//    Console.WriteLine("Turpini spēli!");
//}







// jāizveido pārbaudes katrai rindai ar uzvaru
// spēles nobeigums










