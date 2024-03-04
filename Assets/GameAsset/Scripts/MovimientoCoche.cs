using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCoche : MonoBehaviour
{
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        velocidad=Random.Range(20,40);
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.right*velocidad*Time.deltaTime);
    }
}
