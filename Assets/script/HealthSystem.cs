using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{

    [SerializeField] Sprite fullHeart, emptyHeart;
    [SerializeField] TMP_Text life1, life2, life3;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ennemy"))
        {
            if (string.IsNullOrEmpty(life2.text))
            {
                life1.text = "";
            }
            if (string.IsNullOrEmpty(life1.text))
            {
                life1.text = "GAME OVER";
            }
            if (string.IsNullOrEmpty(life3.text))
            {
                life2.text = "";
            }
           
           

            life3.text = "";
        }
    }
}
