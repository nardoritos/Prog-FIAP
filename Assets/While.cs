using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While : MonoBehaviour {
    int numero = 0;
	// Use this for initialization
	void Start () {
        //EX1 - Crie um programa que exiba os números de 0 até 150
        #region EX1
        /*while (numero <= 150)
        {

            print(numero);
            numero++;
        }*/
        #endregion
        //EX2 - Crie um programa que conte de 0 até 1000, exibindo apenas os números no intervalo de 150 até 160
        #region EX2
        while(numero <= 1000)
        {
            if(numero >= 150 && numero <= 160)
            {
                print(numero);
                numero++;
            }
        }
        #endregion  
    }
	
	// Update is called once per frame
	void Update () {

    }
}
