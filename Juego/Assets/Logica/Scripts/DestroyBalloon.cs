using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBalloon : MonoBehaviour
{
    public int health = 1;
    //private Material matWhite;
    //private Material matDefault;
    private SpriteRenderer sR;
    // Start is called before the first frame update
    void Start()
    {
        sR = GetComponent<SpriteRenderer>();
        //Carga los recursos
        //matWhite = Resources.Load("WhiteFlash", typeof(Material)) as Material;
        //matDefault = sR.material;
        Invoke("KillSelf",8f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("bullet")){
            //Destruye la bala
            //Destroy(collision.gameObject);
            health--;
            //Cambia el material a blanco
            //sR.material = matWhite;
            if(health <= 0){
                KillSelf();
            }/*else{
                Invoke("ResetMaterial", .5f);
            }*/
        }
    }
/*
    //Resetea el material al original
    private void ResetMaterial(){
        sR.material = matDefault ;
    }
*/
    private void KillSelf(){
        //Destruye el globo
        Destroy(gameObject);
    }
}
