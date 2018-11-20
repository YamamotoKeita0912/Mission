using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onpiece : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string[] chara = {"ルフィ", "チョッパー", "バギー", "エース", "ロビン" ,"ブルック" };
        string[] akuma = { "ゴムゴム", "ヒトヒト", "バラバラ", "メラメラ", "ハナハナ", "ヨミヨミ" };

        for (int i = 0; i < chara.Length; i++)
        {
            for (int j = 0; j < akuma.Length; j++)
            {
                if (chara[i] == "ルフィ" && akuma[j] =="ゴムゴム")
                {
                    Debug.Log(string.Format("{0}の悪魔のみは{1}の実だよ", chara[i], akuma[j]));
                }
                if(chara[i] == "チョッパー" && akuma[j] == "ヒトヒト")
                {
                    Debug.Log(string.Format("{0}の悪魔のみは{1}の実だよ", chara[i], akuma[j]));
                }
                if (chara[i] == "バギー" && akuma[j] == "バラバラ")
                {
                    Debug.Log(string.Format("{0}の悪魔のみは{1}の実だよ", chara[i], akuma[j]));
                }
                if (chara[i] == "エース" && akuma[j] == "メラメラ")
                {
                    Debug.Log(string.Format("{0}の悪魔のみは{1}の実だよ", chara[i], akuma[j]));
                }
                if (chara[i] == "ロビン" && akuma[j] == "ハナハナ")
                {
                    Debug.Log(string.Format("{0}の悪魔のみは{1}の実だよ", chara[i], akuma[j]));
                }
                if (chara[i] == "ブルック" && akuma[j] == "ヨミヨミ")
                {
                    Debug.Log(string.Format("{0}の悪魔のみは{1}の実だよ", chara[i], akuma[j]));
                }
            }
        }

        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
