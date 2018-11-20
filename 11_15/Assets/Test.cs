using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{ 
 
    //メンバー変数を定義
    private int su_;

	// Use this for initialization
	void Start () {


        su_ = (100);

        if (su_ > 1000)
        {
            Debug.Log(su_);
        }
            Debug.Log(su_ + 1000);
	}
	
	// Update is called once per frame
	void Update () {
        //su_ += 100;
		
	}
}
