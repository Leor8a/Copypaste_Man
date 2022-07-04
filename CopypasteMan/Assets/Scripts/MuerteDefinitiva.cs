using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuerteDefinitiva : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemigo")
        {
            Destroy(col.gameObject);
        }
    }
}
