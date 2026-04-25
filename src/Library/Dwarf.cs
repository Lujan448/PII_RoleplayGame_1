using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Reflection;
using System.Runtime.Intrinsics.X86;

namespace Ucu.Poo.RolePlayGame
{
public class Dwarf
{
//atributos:, nombre, vida, atk inicial, def inicial

private string name;
public string Name
        {
            get {return name;}
        }


private int health;
public int Health
    {
        get { return health; }
        set { health = value; }
    }
private int BaseAtk;
private int BaseDef;
private Axe axe;
private Shield shield;

public int Atk
        {
            get
            {
                int total = BaseAtk;
                if (axe != null)
                {
                    total += axe.Damage;  
                }
            return total;
            }       
        }
public int Def
        {
            get
            {
                int total = BaseDef;
                if (shield != null)
                {
                    total += shield.Defense;
                }
            return total;

            }
        }



//constructor

public Dwarf (string name, int BaseAtk, int BaseDef)
        {
            this.name = name;
            this.health = 100;
            this.BaseAtk= BaseAtk;
            this.BaseDef = BaseDef;
            this.axe = null;
            this.shield = null;
        }


//metodos: recive ataque, ataque 
public void ReceiveAtk (int enemyAtk )
        {
            int damage = enemyAtk - this.Def;

            if (damage < 0)
            {
                damage = 0;
            }

            this.health -= damage;
            if (this.health < 0)
            {
                this.health = 0;
            }


        }
public void Attack (Dwarf enemy)
        {
            enemy.ReceiveAtk(this.Atk);
        }
    
}

}