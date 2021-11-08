using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobosSpeed : MonoBehaviour
{
    public float velocidadMax = 4f;
    public float velocidad = 4f;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.AddForce(Vector2.up * velocidad);

        float limitedSpeed = Mathf.Clamp(rb2d.velocity.y, -velocidadMax, velocidadMax);
        rb2d.velocity = new Vector2(rb2d.velocity.x,limitedSpeed);
    }
}
