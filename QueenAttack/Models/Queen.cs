using System;
 
namespace QueenAttack
{

public class Queen
{
    public static string Result { get; set; }
    public static string CanAttack(float[] queen, float[] enemy)
    {
        float queenX = queen[0];
        float queenY = queen[1];
        float enemyX = enemy[0];
        float enemyY = enemy[1];

        bool queenCanAttack = false;
        string result = "";

        if ((queenX == enemyX) || (queenY == enemyY))
        {
        queenCanAttack = true;
        }
        else if (Math.Abs(((queenY - enemyY)/(queenX - enemyX))) == 1)
        {
        queenCanAttack = true;
        }
        else 
        {
        queenCanAttack = false;
        }

        if (queenCanAttack)
        {
        result = "You dead";
        }
        else 
        {
        result = "Curse you! You got away...for now.";
        }
        return result;
    }
//    static void Main()
//    {
//        Console.WriteLine("Enter the Queen's coordinates. (plz separate with a comma!!!)");
//        string queenString = Console.ReadLine();
//        Console.WriteLine("Enter your combatant's coordinates. (plz separate with a comma!!!)");
//        string enemyString = Console.ReadLine();
//        string [] queenCoords = queenString.Split(new Char  [] {','});
//        string [] enemyCoords = enemyString.Split(new Char [] {','});

//        float queenXFloat = float.Parse(queenCoords[0]);
//        float enemyXFloat = float.Parse(enemyCoords[0]);
//        float queenYFloat = float.Parse(queenCoords[1]);
//        float enemyYFloat = float.Parse(enemyCoords[1]);

//        float [] queen = {queenXFloat, queenYFloat};
//        float [] enemy = {enemyXFloat, enemyYFloat};

//         CanAttack(queen, enemy);


//    }
 }
}


