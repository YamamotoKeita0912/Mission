using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

        System.Random r = new System.Random(1000);

        int a = 0;

        while (true)
        {
            a += r.Next(10);
            Debug.Log(a);
            if (a > 100)
            {
                break;
            }
        }
        Debug.Log(a);

        bool age_auth = CheckAge(15);
        if (age_auth == true)
        {
            //OK

            Debug.Log("OK");
        }
        else
        {
            //NG}
            Debug.Log("NG");
        }

        bool is_pro = CheckPro(35);
        if(is_pro == true)
        {
            Debug.Log("Pro");
        }
        else
        {
            Debug.Log("Ama");
        }

        UserInfo user = new UserInfo();
        user.name = "山本";
        user.level = 1;
        user.hp = 85;
        user.attack = 66;
        user.defence = 29;
        user.magic = 37;

        //int total_powar = TotalPowar(user.hp, user.attack, user.defence, user.magic);
        int total_powar = TotalPowar(user);
        Debug.Log(total_powar);
    }

    public int TotalPowar(int hp, int attack, int defence, int magic)
    {
        int all = hp + attack + defence + magic;

        return all;

    }

    public int TotalPowar(UserInfo user_info)
    {
        return user_info.hp + user_info.attack + user_info.defence + user_info.magic;

    }




    public bool CheckAge(int age)
    {

        if (20 < age)
        {

            return true;

        }
        else
        {
            return false;
        }

        

    }

    public bool CheckPro(int level)
    {

        if(30 < level)
        {
            return true;
        }

        return false;

    }
    
    // Update is called once per frame
    void Update () {
		
	}
}

public  class UserInfo{
    public string name;
    public int level;
    public int hp;
    public int attack;
    public int defence;
    public int magic;
}
