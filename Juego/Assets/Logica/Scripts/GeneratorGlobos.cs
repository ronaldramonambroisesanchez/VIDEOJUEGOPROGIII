using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorGlobos : MonoBehaviour
{
    public GameObject globo;
    public float generatorTimerspanw = 4.75f;
    public float generatortimerstar = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateGlobos", generatortimerstar, generatorTimerspanw);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateGlobos()
    {
        Instantiate(globo, transform.position, Quaternion.identity);
    }











}

