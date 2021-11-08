using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject ovni;
    public GameObject MenuPerder;
    public static bool jPerder = false;
    //public Bullet bullet;
    public ControlMenuPausa menuPausa;
    public GameObject MusicaFondo;
    public GameObject GeneradorGeneral;

    public static bool plusTenStatus = false;
    public void GameOver(){
        jPerder = true;
        Animator anim = ovni.GetComponent<Animator>();
        anim.SetBool("Explotar",true);
        MenuPerder.SetActive(true);
        MusicaFondo.SetActive(false);
        Time.timeScale = 0f;
        GeneradorGeneral.SetActive(false);
        menuPausa.enabled = false;
        Timer.jugando = false;
    }

    public void Jugar(){
        jPerder = false;
        MenuPerder.SetActive(false);
        MusicaFondo.SetActive(true);
        Time.timeScale = 1f;
        GeneradorGeneral.SetActive(true);
        menuPausa.enabled = true;
    }

}
