using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyMove : MonoBehaviour
{

    public float ennemySpeed = 52.00f;
    private bool isMovingRight = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        if (isMovingRight)
        {
            
            transform.Translate(Time.deltaTime * 150 * ennemySpeed * Vector3.right * -1);

            if(transform.position.z <= -8)
            {
                Debug.Log("Run False");
                isMovingRight = false;
            }
        }
        
        if (!isMovingRight)
        {
            
            
            transform.Translate(Time.deltaTime * 150 * ennemySpeed * Vector3.left * -1);

            if(transform.position.z >= 83.79348)
            {
                 isMovingRight =  true;
            }
        }
    }
}
