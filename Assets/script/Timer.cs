using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float temps = 10;
    public TMP_Text timertext;
      

    // Update is called once per frame
    void Update()
    {
        timertext.text = (temps + "secondes");
        if (temps >= 0) {
            temps -= Time.deltaTime; 
        }
        
    }
}
