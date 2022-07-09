using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaveManager : MonoBehaviour
{

    void Start()
    {
        GameManager.count = PlayerPrefs.GetFloat("COUNT", 0);
        GameManager.totalScore = PlayerPrefs.GetFloat("SCORE", 0);
        Clicker.num = PlayerPrefs.GetFloat("NUM", 0);
        Pickaxe.pick = PlayerPrefs.GetInt("PICK", 0);
        Hunmer.hum = PlayerPrefs.GetInt("HUM", 0);
        Drill.dri = PlayerPrefs.GetInt("DRI", 0);
        Machine.mac = PlayerPrefs.GetInt("MAC", 0);
        Plant.pln = PlayerPrefs.GetInt("PLN", 0);
        God.god = PlayerPrefs.GetInt("GOD", 0);
        ButtonClick.pnum = PlayerPrefs.GetFloat("PickPrice", 0);
        ButtonClick.hnum = PlayerPrefs.GetFloat("HumPrice", 0);
        ButtonClick.dnum = PlayerPrefs.GetFloat("DriPrice", 0);
        ButtonClick.mnum = PlayerPrefs.GetFloat("MacPrice", 0);
        ButtonClick.plnum = PlayerPrefs.GetFloat("PlnPrice", 0);
        ButtonClick.gnum = PlayerPrefs.GetFloat("GodPrice", 0);
    }
    
    void OnDestroy()
    {
        PlayerPrefs.SetFloat("COUNT", GameManager.count);
        PlayerPrefs.SetFloat("SCORE", GameManager.totalScore);
        PlayerPrefs.SetFloat("NUM", Clicker.num);
        PlayerPrefs.SetInt("PICK", Pickaxe.pick);
        PlayerPrefs.SetInt("HUM", Hunmer.hum);
        PlayerPrefs.SetInt("DRI", Drill.dri);
        PlayerPrefs.SetInt("MAC", Machine.mac);
        PlayerPrefs.SetInt("PLN", Plant.pln);
        PlayerPrefs.SetInt("GOD", God.god);
        PlayerPrefs.SetFloat("PickPrice", ButtonClick.pnum);
        PlayerPrefs.SetFloat("HumPrice", ButtonClick.hnum);
        PlayerPrefs.SetFloat("DriPrice", ButtonClick.dnum);
        PlayerPrefs.SetFloat("MacPrice", ButtonClick.mnum);
        PlayerPrefs.SetFloat("PlnPrice", ButtonClick.plnum);
        PlayerPrefs.SetFloat("GodPrice", ButtonClick.gnum);
        PlayerPrefs.Save();
    }
}
