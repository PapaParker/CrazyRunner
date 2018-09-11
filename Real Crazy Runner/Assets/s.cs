using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s : MonoBehaviour
{

    Currency script;
    public int addAmount;

    // Use this for initialization
    void Start()
    {
        {
            script = GameObject.FindWithTag("GameController").GetComponent<Currency>();
        }
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.tag == "Player")
        {
            script.gold += addAmount;
            Destroy(gameObject);
        }
    }



}

