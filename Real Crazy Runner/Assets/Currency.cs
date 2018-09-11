using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Currency : MonoBehaviour {

    public int gold;

	// Use this for initialization
	void Start () {
        {
            currencyUI = GameObject.Find("Currency");
        }
        
	}
	
	// Update is called once per frame
	void Update () {
        currencyUI.GetComponent<Text>().text = gold.ToString(); 
        if (gold < 0)
        {
            gold = 0; 
        }
	}
}
