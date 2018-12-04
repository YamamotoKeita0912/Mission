using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batter
{
    public int Bpower()
    {
        System.Random r = new System.Random(1000);
        int power = r.Next(10);

        return power;
    }
}

public class Pitcher
{
    public enum ThrowType
    {
        straight,
        curve,
        fork,
        palm,
        slider
    }

    public int Ppower()
    {
        System.Random r = new System.Random();
        int power2 = r.Next(10);

        return power2;
    }
    
    
    public ThrowType Throw()
    {
        System.Random r = new System.Random();
        ThrowType type = (ThrowType)r.Next(4);

        return type;
    }
}

public class Baseball1 : MonoBehaviour {

    enum result
    {
        StruckOut,
        Homerun,
        Hit,
        TwoBase,
        ThreeBase
    }

	// Use this for initialization
	void Start () {
        Batter batter = new Batter();
        Pitcher pitcher = new Pitcher();
        int bpower = batter.Bpower();
        int ppower = pitcher.Ppower();
        

		if(bpower < ppower)
        {
            
            //Debug.Log("三振");
        }
        else
        {
            
            //Debug.Log("ホームラン");
        }

        System.Random r = new System.Random();
        int ran = r.Next(4);
        result res = (result)ran;
        Debug.Log(ran);
        Debug.Log(res);

        Debug.Log("結果は・・・");

        switch (res)
        {
            case result.StruckOut:
                Debug.Log("三振");
                break;
            case result.Homerun:
                Debug.Log("ホームラン");
                break;
            case result.Hit:
                Debug.Log("ヒット");
                break;
            case result.TwoBase:
                Debug.Log("ツーベース");
                break;
            case result.ThreeBase:
                Debug.Log("スリーベース");
                break;
            default:
                Debug.Log("アウト");
                break;
        }
        
        Pitcher.ThrowType type  = pitcher.Throw();
        switch (type)
        {
            case Pitcher.ThrowType.curve:
                Debug.Log("カーブ");
                break;
            case Pitcher.ThrowType.fork:
                Debug.Log("フォーク");
                break;
            case Pitcher.ThrowType.palm:
                Debug.Log("パーム");
                break;
            case Pitcher.ThrowType.slider:
                Debug.Log("スライダー");
                break;
            case Pitcher.ThrowType.straight:
                Debug.Log("ストレート");
                break;
            default:
                Debug.Log("ボーク");
                break;
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
