using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionadorCoches : MonoBehaviour
{
    
void Start(){

    
}
   private void OnTriggerEnter(Collider other)   
    {
        
        Destroy(gameObject);
      
    }
}
