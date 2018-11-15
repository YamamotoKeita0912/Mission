using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TestKato : MonoBehaviour
{
    // メンバー変数を定義.
    private string str_ = "";

    // Use this for initialization
    void Start()
    {
        str_ = "メンバー変数に文字を代入してログに出力するテスト";
        Debug.Log(str_);
    }

}
