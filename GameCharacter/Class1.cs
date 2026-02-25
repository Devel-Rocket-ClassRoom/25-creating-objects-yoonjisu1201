using System;
using System.Collections.Generic;
using System.Text;

class GameCharacter
{
    public string Name;
    public string Job;
    private int Level = 1;
    private int Exp = 0;

  

    public void GainExp(int amount)
    {
        Exp += amount;
        if (Exp >= 100)
        {
            Level++;
            Exp -= 100;
            Console.WriteLine($"레벨 업! {Name} Lv.{Level} 달성!");
        }
        else
        {
            Console.WriteLine($"경험치 획득! 현재 EXP: {Exp}/100");
        }
    }

    public void ShowStatus()
    {
        Console.WriteLine($"[{Job}] {Name} - Lv.{Level} (EXP: {Exp}/100)");
    }

}
