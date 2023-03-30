using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float temps = 350;
    public TMP_Text timertext;
      

    // Update is called once per frame
    void Update()
    {
        if (temps >= 0) {
            temps -= Time.deltaTime;
            timertext.text = temps.ToString();
        }
        
    }
}
