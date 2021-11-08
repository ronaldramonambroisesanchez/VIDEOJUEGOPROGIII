using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{

    public GameManager manager;
    //tiempo inicial en segundos
    public static float timeStart = 30f; 
    public static bool jugando = false;
    public static bool sumar = false;
    public Text textBox;
    // Start is called before the first frame update
    void Start()
    {
       textBox.text = "Tiempo: 0:00:00";
       jugando = true;
    }
    // Update is called once per frame
    void Update()
    {
        if(sumar){
            sumar = false;
            timeStart += 10;
        }

        if(jugando){
            timeStart -= Time.deltaTime;

            int seconds = (int)(timeStart % 60);
            int minutes = (int)(timeStart / 60);
            int hours = (int)(timeStart / 3600);

            string timerStr = string.Format("{0:0}:{1:00}:{2:00}",hours,minutes,seconds);

            textBox.text = "Tiempo: " + timerStr;

        }else{
            timeStart = 30f;
        }
        
        if(timeStart <= 0){
            manager.GameOver();
        }
    }
}
