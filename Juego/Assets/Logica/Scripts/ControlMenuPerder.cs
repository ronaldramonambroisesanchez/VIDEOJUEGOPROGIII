using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ControlMenuPerder : MonoBehaviour
{
    public GameManager manager;
    public void CargarMenuPrincipal(){
        manager.GameOver();
        manager.Jugar();
        SceneManager.LoadScene("Main");
    }

    public void SalirJuego(){
        Debug.Log("Saliendo del juego");
        Application.Quit();
    }

    public void Reiniciar(){
        manager.Jugar();
        SceneManager.LoadScene("Game");
    }

    
}
