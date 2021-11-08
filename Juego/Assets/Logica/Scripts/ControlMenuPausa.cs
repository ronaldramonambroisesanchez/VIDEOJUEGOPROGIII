using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ControlMenuPausa : MonoBehaviour
{
    public GameManager manager;
    public GameObject MenuPausa;
    public AudioSource Musica;
    public static bool jpausa = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (jpausa == true)
            {
                QuitarPausa();
            }
            else
            {
                Pausa();

            }
        }
    }
    public void Pausa()
    {

        jpausa = true;
        Musica.mute = true;
        Time.timeScale = 0f;
        MenuPausa.SetActive(true);

    }

    public void QuitarPausa()
    {
        jpausa = false;
        Musica.mute = false;
        Time.timeScale = 1f;
        MenuPausa.SetActive(false);
    }

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
        manager.GameOver();
        manager.Jugar();
        SceneManager.LoadScene("Game");
    }

}
