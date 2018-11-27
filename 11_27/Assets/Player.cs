using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

  

	// Use this for initialization
	void Start () {

        Test test = new Test();
        test.Attack();
        test.Damage(30);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public class Test
{
    private int hp = 100;
    private int power = 50;

    public void Attack(){

        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Damage(int damage){

        this.hp -= damage;
        Debug.Log(damage + "のダメージを受けた");
    }
}