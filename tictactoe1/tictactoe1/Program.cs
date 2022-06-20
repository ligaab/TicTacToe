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
    step1 = int.Parse(Console.ReadLine());
    pos[step1] = "X";
    Console.Clear();
    DrawBoard();
    flag = Game.CheckWin();
    board = boardFull();
    input = Game.correctInput();

    {
        if (Game.flag == 1)
        {
            break;
        }
       
        else if (input == false)
        {
            Console.Clear();
            DrawBoard();
            Console.WriteLine("izvēlies citu skaitli!");
            step1 = int.Parse(Console.ReadLine());            
        }
        else
        {
            Console.WriteLine("");
        }
        if (board == -1)
        {
            Console.WriteLine("Viss laukums ir aizpildīts - NEZŠĶIRTS REZULTĀTS!");
            break;
        }
    }
   

    Console.WriteLine("speletaja 2 gajiens");
    step2 = int.Parse(Console.ReadLine());
    pos[step2] = "O";
    Console.Clear();
    DrawBoard();
    flag = Game.CheckWin();
    board = boardFull();
    input = Game.correctInput();

    {
        if (Game.CheckWin() == 2)
        {
            break;
        }
        
        else if (input == false)
        {
            Console.Clear();
            DrawBoard();
            Console.WriteLine("izvēlies citu skaitli!");
            step2 = int.Parse(Console.ReadLine());         
        }
        else
        {
            Console.WriteLine("");
        }
    }
    if (board == -1)
    {
        Console.WriteLine("Viss laukums ir aizpildīts - NEZŠĶIRTS REZULTĀTS!");
        break;
    }
    
}
while (flag == 0);
{
    if (flag == 2)
    {
        Console.WriteLine($"Spēlētājs  {player2.Name} ir uzvarējis");      
    }
    else if (flag == 1)
    {
        Console.WriteLine($"Spēlētājs  {player1.Name} ir uzvarējis");     
    }
}
if (flag == 2 || flag == 1 || board == -1)
{
    Console.WriteLine("Ko darīsim tālāk?");
    Console.WriteLine("1. Spēlēt atkal");// pagaidām vēl nestrādā!
    Console.WriteLine("2. Pamest spēli");
    Console.WriteLine("");
    Console.WriteLine("Ievadi savu izvēli: ");
    choice = int.Parse(Console.ReadLine());

    if (choice == 1)
    {
        Console.Clear();
        DrawBoard();
        
    }
    else if (choice == 2)
    {
        Console.Clear();
        Console.WriteLine("Paldies par Spēli!");

    }
}


















// jāizveido pārbaudes katrai rindai ar uzvaru
// spēles nobeigums
