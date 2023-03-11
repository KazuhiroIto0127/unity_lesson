using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    public string title;
    private int hp;
    private int attackPower;
    private int defensePower;
    public int Lucky { get; set; } // ���������v���p�e�B

    // �R���X�g���N�^
    public Slime(string name = "�X���C��", int hp = 10, int attackPower = 15, int defensePower = 20)
    {
        this.title = name;
        this.hp = hp;
        this.attackPower = attackPower;
        this.defensePower = defensePower;
    }

    public void printDetail()
    {
        Debug.Log($"{this.title}��hp:{this.hp}, attackPower:{this.attackPower}, defensePower:{this.defensePower}");
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
