using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("3の2乗=" + Pow2(6));

        bool mikan = Mikan(12);

        if(mikan == true)
        {
            Debug.Log("食べ過ぎ");
        }
        else
        {
            Debug.Log("程々");
        }
	}

    public int Pow2 (int a)
    {
        return a * a;
    }

    public bool Mikan(int a)
    {
        if(10 < a)
        {
            return true;
        }

        return false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
