using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 3f;
    public int health = 1;
    private Rigidbody2D rb2d;
    public GameObject balasonido;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        balasonido = (GameObject) Instantiate(balasonido);
        //Invocar el destruir objeto cada 1 segundo
        Invoke("DestroySelf", 1f);
         
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb2d.velocity = new Vector2(speed * -1,0);
    }

    //Destruir Objeto
    //Metodo Default (de unity) para detectar una colision
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("balloon")){
            DestroySelf();
            Score.score = true;
        }
        if(collision.gameObject.CompareTag("balloonBlue")){
            DestroySelf();
            Score.score = true;
            Timer.sumar = true;
        }
    }

    //Metodo para destruir objeto
    private void DestroySelf(){
        Destroy(gameObject);
        Destroy(balasonido);
    }
}
