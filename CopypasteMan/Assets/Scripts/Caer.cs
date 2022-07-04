using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caer : MonoBehaviour
{
    /*
    void OnCollisionExit(Collision col)
    {
        
        if (col.gameObject.tag == "Jugador")
        {
            Destroy(gameObject);
        }
      
    }
    */
    void OnTriggerExit(Collider col){
        if (col.gameObject.tag == "Jugador")
        {
            Destroy(gameObject);
        }
    }

}
