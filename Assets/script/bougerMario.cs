using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bougerMario : MonoBehaviour{

    public static bougerMario instance;
    public int currentHealth;
    public int maxHealth = 3;

    public void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    //quand le jeu ce lance ca va excuter tout ce qui est dans start
    //quand sa ce lance une seule et unique fois
    void Start(){

        currentHealth = maxHealth;

    }

    // Update is called once per frame
    // image par seconde sa ce lance
    // quand je veux que ca ce lance tt le temps 
    void Update()
    {

    }
}



