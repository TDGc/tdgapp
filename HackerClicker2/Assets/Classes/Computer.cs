using UnityEngine;
using System.Collections;

public class Computer {
    public static string TAG = "Computer";
    private float ghs;
    private int levelUpgade;
    private int levelPC;
    public Computer(float ghs_, int levelUpgrade_, int levelPC_)
    {
        this.ghs = ghs_;
        this.levelPC = levelPC_;
        this.levelUpgade = levelUpgrade_;
    }
    public Computer()
    {
        this.ghs = 0;
        this.levelPC = 0;
        this.levelUpgade = 0;
    }
    public float Ghs
    {
        get { return ghs; }
        set { ghs = value; }
    }


    public int LevelPC
    {
        get { return levelPC; }
        set { levelPC = value; }
    }


    public int LevelUpgade
    {
        get { return levelUpgade; }
        set { levelUpgade = value; }
    }

   
    
};
