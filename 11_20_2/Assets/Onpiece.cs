using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onpiece : MonoBehaviour {

    // Use this for initialization
    void Start() {
        string[] chara = { "ルフィ", "チョッパー", "バギー", "エース", "ロビン", "ブルック" };
        string[] akuma = { "ゴムゴム", "ヒトヒト", "バラバラ", "メラメラ", "ハナハナ", "ヨミヨミ" };

        for (int i = 0; i < chara.Length; i++)
        {
            Debug.Log(string.Format("{0}の悪魔のみは{1}の実だよ", chara[i], akuma[i]));
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
