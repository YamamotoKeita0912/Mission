using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //インスタンスを作成初期化
        Vector2 startPos = new Vector2(2.0f, 1.0f);
        Vector2 endPos = new Vector2(8.0f, 5.0f);
        //減算
        Vector2 dir = endPos - startPos;
        Debug.Log(dir);
        //magnitudeメンバ変数を使いベクトルdirの長さを求める
        float len = dir.magnitude;
        Debug.Log(len);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
