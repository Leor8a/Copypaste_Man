using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Empezamos con Ciclos para UnityEngine
/*
*
*
*
*
CICLOS: SENTENCIAS DE CICLOS EN C#
FECHA: 14 DE JUNIO DE 2022
ELABORADO POR: OCHOA RIOS LUIS ERNESTO
*
*
*
*
*/



public class Ciclos : MonoBehaviour
{
    //Se pueden crear varias variables a la vez
    public float varUno, varDos, varTres;
    public int[] vars = new int[2];
    //public float varDos;
    public bool comprobador = true;

    // Start is called before the first frame update
    void Start()
    {
        //Esto esta cagado !
        varDos = varUno = 5.0f;
        //if (comprobador)
          //Debug.Log("Esta es la Variable uno:"+ varUno.ToString() +"\n\t Esta es la Variable dos:"+ varDos);   //Antes se usaba: varUno.ToString()
        /*
        varDos = 6.0f;

        do {
          Debug.Log(varDos);
        } while (varDos <= varUno);
        */

        /*
        //while(varDos <= varUno)
        while(varDos < 100){
          varDos = varDos + varUno;
          //Debug.Log("Nueva Variable uno:"+ varUno.ToString() +"\n\t Nueva Variable dos:"+ varDos);
          Debug.Log("\n\t Nueva Variable dos:"+ varDos);
          comprobador = false;
        }
        /*

        //Inicializador, Condición y Actualiza Variable
        // i = i + 1
        // i += 1
        // i ++

        /*
        for (int i=0; i<10 ; i++) {
            Debug.Log("Mensaje de "+ (int)(i+1) +" iteraciones.");
        }
        */

        /*
        TOD LO QUE ESTA DENTRO
        SERA IGNORADO Y EJECUTADO POR
        NUESTRO PROGRAMA
        for (Initializer; Condition; Update) {
        }
        */

        /*  CICLO FOR INFINITO
        for (;;) {
        }
        */

        /*
        for (int i=0; varDos <= varUno + 2.0f;i++){
          Debug.Log(varDos);
          varDos += 2.0f;
        }
        */

        vars[0] = (int)varUno;
        vars[1] = (int)varDos;

        foreach (int i in vars) {
          Debug.Log("Valor x del arreglo: " + i);
        }

    }

    // Update is called once per frame
    // SE EJECUTA 60 VECES POR SEGUNDO
    void Update()
    {

    }
}
