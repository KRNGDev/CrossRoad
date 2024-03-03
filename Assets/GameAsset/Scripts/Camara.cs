using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{


    public Transform positionPlayer;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (positionPlayer != null)
        {
            Vector3 camara = transform.position;
            Vector3 player = positionPlayer.position;
            Vector3 nuevaPosition = new Vector3(37, 65, player.z+(-64));
            transform.position = nuevaPosition;

        }

    }
}
