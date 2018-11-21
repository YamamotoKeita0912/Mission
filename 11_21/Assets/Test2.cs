using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int[] points = { 65, 72, 80, 84, 100, 104, 88, 95, -1000, 0 };
       
        int sum = 0;

        for(int i = 0; i < points.Length; i++)
        {
            if(points[i] > 80 && points[i] < 100)
            {
                    sum += points[i];
               
            }
        }

        int average = sum / points.Length;
        Debug.Log(string.Format("average = {0}", average));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
