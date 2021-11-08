using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarreraDestroyer : MonoBehaviour
{
    public GameManager manager;
    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("ovni")){
            manager.GameOver();
        }
    }

}
