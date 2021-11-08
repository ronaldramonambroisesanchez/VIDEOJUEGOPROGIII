using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{

    public GameObject LoadingScreen;
    public Slider slider;
    public Text progressText;

    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsyn(sceneIndex));
    }

    public void SalirJuego(){
        Application.Quit();
        Debug.Log("Saliendo del juego");
    }
        
    IEnumerator LoadAsyn(int sceneIndex){
        
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        
        LoadingScreen.SetActive(true);
        
        while(!operation.isDone){

            float progress = Mathf.Clamp01(operation.progress / .9f);
            
            slider.value = progress;
            progressText.text = progress * 100f + "%";

            yield return null;
        }
        
    }
    
}
