using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] cochesPrefab;
    public float tiempoEspera;
    private float inicio = 0.1f;
    

    // Start is called before the first frame update
    void Start()
    {
        tiempoEspera = Random.Range(0,3);
        InvokeRepeating("Spawn", inicio, tiempoEspera);

    }

    
    void Spawn()
    {
       
        int cochesIndex = Random.Range(0, cochesPrefab.Length);
        Instantiate(cochesPrefab[cochesIndex].transform);

    }
}