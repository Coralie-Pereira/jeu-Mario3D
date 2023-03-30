using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingCoins : MonoBehaviour
{



    public int coins;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "coin") {
            Debug.Log("coin collected!");
            coins = coins + 1;
            col.gameObject.SetActive(false);
        }
            
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
