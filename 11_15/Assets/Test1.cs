using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int a = 1;
        int b = 1;

        for (int i=0; i < 10; i++) 
        {
            a += 3;
            b += 10;

            if (a == 31)
            {
                Debug.Log(string.Format("a = {0} ", a));
            }

            if (b == 101)
            {
                Debug.Log(string.Format("b = {0} ", b));
            }

        }
      
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
