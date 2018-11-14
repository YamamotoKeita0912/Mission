using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    class Name
    {
        //メンバー変数
        private string x;
        private string y;


        public string Myouji()
        {
            return x;
        }
        public string Namae()
        {
            return y;
        }
        // Use this for initialization
        void Start(string x, string y)
        {
            Name sougou = new Name();
            sougou.x = "Yamamoto";
            sougou.y = "Keita";
            Debug.Log(x);
            Debug.Log(y);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
