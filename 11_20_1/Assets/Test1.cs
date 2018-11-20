using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int[] points = { 83, 99, 52, 93, 15 };

        for(int i = 0; i < points.Length; i++)
        {
            if(points[i] >= 90)
            {
                Debug.Log(string.Format("points = {0}", points[i]));
            }
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
