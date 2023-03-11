using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    public string title;
    private int hp;
    private int attackPower;
    private int defensePower;
    public int Lucky { get; set; } // 自動実装プロパティ

    // コンストラクタ
    public Slime(string name = "スライム", int hp = 10, int attackPower = 15, int defensePower = 20)
    {
        this.title = name;
        this.hp = hp;
        this.attackPower = attackPower;
        this.defensePower = defensePower;
    }

    public void printDetail()
    {
        Debug.Log($"{this.title}のhp:{this.hp}, attackPower:{this.attackPower}, defensePower:{this.defensePower}");
    }

    public int GetHp()
    {
        return this.hp;
    }

    public void SetHp(int hpArg)
    {
        if(hpArg < 0)
        {
            this.hp = 0;
        }
        else
        {
            this.hp = hpArg;
        }
    }
}
