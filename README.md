# TicTacToe

Sarakstīju iespējamo variantu - Uzvarētāja pārbaudei!
Paskatieties brīvā laikā!
Iespējams, ka to var kaut kā arī saīsināt.

static bool CheckWin() // Pārbaudes metode uzvarētājam.
        {
            if (pos[1] == "O" && pos[2] == "O" && pos[3] == "O" ||
                    pos[4] == "O" && pos[5] == "O" && pos[6] == "O" ||
                    pos[7] == "O" && pos[8] == "O" && pos[9] == "O" ||
                    pos[1] == "O" && pos[5] == "O" && pos[9] == "O" ||
                    pos[7] == "O" && pos[5] == "O" && pos[3] == "O" ||
                    pos[1] == "O" && pos[4] == "O" && pos[7] == "O" ||
                    pos[2] == "O" && pos[5] == "O" && pos[8] == "O" ||
                    pos[3] == "O" && pos[6] == "O" && pos[9] == "O" ||
                    pos[1] == "X" && pos[2] == "X" && pos[3] == "X" ||
                    pos[4] == "X" && pos[5] == "X" && pos[6] == "X" ||
                    pos[7] == "X" && pos[8] == "X" && pos[9] == "X" ||
                    pos[1] == "X" && pos[5] == "X" && pos[9] == "X" ||
                    pos[7] == "X" && pos[5] == "X" && pos[3] == "X" ||
                    pos[1] == "X" && pos[4] == "X" && pos[7] == "X" ||
                    pos[2] == "X" && pos[5] == "X" && pos[8] == "X" ||
                    pos[3] == "X" && pos[6] == "X" && pos[9] == "X")
            {
                return true;
            }
         
            else // Nav uzvarētāja!
            {
                return false;
            }


Gājieni



step = int.Parse(Console.ReadLine());

{
    if (player1.Equals(1))
    {
        return 1;
    }
    else
    {
        return 2;
    }
}    
    
    vai arī
    
    
    if (pos[step] != "X" && pos[step] != "O" 
    {
          if (player % 2== 0)
          {
            pos[step] = "O"
            player++
           }
          else 
          {
           pos[step] = "X";
           player++
          }
     }
    else
   
   Piedāvāju šādu variantu spēles ievada daļai. Varam mēģināt piestrādāt pie tā, lai spēlētājiem atbildes Jā/Nē vietā nebūtu iespēja uzrakstīt kaut kādu ķeburu un, lai spēle, piemēram, sāktos tikai uz atbildi "Jā".
   
   
Console.WriteLine("Esi sveicināts spēlē Tic Tac Toe");
Console.WriteLine();
Console.WriteLine("Ievadiet pirmā spēlētāja vārdu?");

string name1 = Console.ReadLine();
Console.WriteLine();
Console.WriteLine($"{name1}, Tu būsi spēlētājs X ");
Console.WriteLine();
Console.WriteLine("Ievadiet otrā spelētāja vārdu?");
Console.WriteLine();
string name2 = Console.ReadLine();
Console.WriteLine($"{name2}, Tu būsi spēlētājs O ");
Console.WriteLine();
Console.WriteLine("Jūsu uzdevums ir pēc kārtas izvēlēties lauciņus, tādējādi mēģinot izveidot rindu no saviem simboliem.");
Console.WriteLine("Spēles mērķis ir pirmajam izveidot horizintāli, vertikāli vai pa diagonāli 3 simbolu rindu.");
Console.WriteLine();
Console.WriteLine("Vai esat gatavi sākt? Jā/Nē");
Console.WriteLine();
string answer = Console.ReadLine();

