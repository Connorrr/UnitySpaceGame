using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CrewData", menuName = "ScriptableObjects/crew", order = 1)]
public class Crew : ScriptableObject
{
    //Identifying stats
    public string firstname;
    public string nickname;
    public uint age;
    public string gender;
    public float height;
    public string sexpref;
    public float bounty;
    public uint trigger; //event trigger byte

    //Health
    public int mentalpoints;
    public int healthpoints;
    public int fitness;
    public int energy;
    public uint[] injuries;

    //Key attributes
    public uint backstory;
    public uint[] traits;
    public uint[] buffs;
    public uint[] debuffs;
    public string title;
    public string location;
    public string shiprole;
    public bool hero;
    public int allignment;
    
    //Primary Skills
    public int charisma;
    public int agility;
    public int strength;

    //Secondary/social skills
    public int willpower;
    public int attitude;
    public int intelligence;
    public int social;
    public int humour;
    public int fortitude;
    public int aesthetic;
    




}
