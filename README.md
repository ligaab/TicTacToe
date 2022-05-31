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
   
