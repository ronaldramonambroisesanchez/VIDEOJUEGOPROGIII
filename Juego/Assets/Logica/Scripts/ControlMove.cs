using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMove : MonoBehaviour
{
    public float velocidadMax = 4f;
    public float velocidad = 4f;
    private Animator anim;
    private Rigidbody2D rb2d;

    Object bulletRef;

    void Start()
    {
        bulletRef = Resources.Load("Bullet");
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb2d.AddForce(Vector2.up * velocidad);
            anim.SetBool("Bajar",false);
            anim.SetBool("Subir",true);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb2d.AddForce(Vector2.up * velocidad * -1);
            anim.SetBool("Subir",false);
            anim.SetBool("Bajar",true);
        }

        if(Input.GetKeyUp(KeyCode.UpArrow)||Input.GetKeyUp(KeyCode.DownArrow))
        {
            anim.SetBool("Subir",false);
            anim.SetBool("Bajar",false);
        }

        float limitedSpeed = Mathf.Clamp(rb2d.velocity.y, -velocidadMax, velocidadMax);
        rb2d.velocity = new Vector2(rb2d.velocity.x,limitedSpeed);
        if(Time.timeScale != 0f){
            if(Input.GetKeyDown(KeyCode.Space)){
            GameObject bullet = (GameObject)Instantiate(bulletRef);
            bullet.transform.position = new Vector3(transform.position.x - 1.6f, transform.position.y - .2f, -1);
        }
        
        }
        
    }
}
