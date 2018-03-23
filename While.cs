using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While : MonoBehaviour {
    int numero = 0;
    [SerializeField] int exercicio;
    public int numeroPrimo;
    bool primo;
    // Use this for initialization
    void Start() {
        switch (exercicio)
        {

            case 1:
                while (numero <= 150)
                {

                    print(numero);
                    numero++;
                }
                break;
            
            case 2:
                while (numero <= 1000)
                {
                    if (numero >= 150 && numero <= 160)
                    {
                        print(numero);
                    }
                    numero++;
                }
                break;
            case 3:
                while(numero <= 1000)
                {
                    if(numero % 2 != 0)
                    {
                        print(numero);
                    }
                    numero++;
                }
                break;
            case 4:
                int aux = numeroPrimo - 1;

                while(aux > 0)
                {
                    if(numeroPrimo % aux == 0)
                    {
                        primo = false;
                        break;
                    }
                }
                if (primo)
                {
                    print("Primo");
                }
                else
                {
                    print("não");
                }
                break;
        }
    }
	
	// Update is called once per frame
	void Update () {

    }
}
