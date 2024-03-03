using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCoche : MonoBehaviour
{
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        velocidad=Random.Range(10,100);
        transform.Translate(Vector3.right*velocidad*Time.deltaTime);
    }
}
