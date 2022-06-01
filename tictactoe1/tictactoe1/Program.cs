


using static tictactoe1.Game;


    Console.WriteLine("Laipni lugts spele TicTacToe");
    Console.WriteLine("Katram speletajam ir simbols X vai O. Uzvar tas kurs pirmais savac tris vienadus simbolus rinda, kolonna, pa diognali");
    Console.WriteLine();
    Console.WriteLine();

    string player1 = "X";
    string player2 = "O";
    Console.WriteLine($"Speletajs 1 ir {player1}, speletajs 2 ir {player2}");






do
{
    DrawBoard();
    if (player % 2 == 0)
    {
        Console.WriteLine("speletaja 2 gajiens");

    }
    else
    {
        Console.WriteLine("speletaja1 gajiens");
    }


    step = int.Parse(Console.ReadLine());

    if (pos[step] != "X" && pos[step] != "O")

    {
        if (player % 2 == 0)
        {
            pos[step] = "O";
            player++;
        }
        else
        {
            pos[step] = "X";
            player++;
        }
    }
    else
    {


    }
    flag = CheckWin();

}
while (flag != true && flag != false);









