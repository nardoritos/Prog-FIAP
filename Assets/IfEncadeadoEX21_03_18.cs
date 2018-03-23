using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfEncadeadoEX21_03_18 : MonoBehaviour {
    [SerializeField] string turno;
    [SerializeField] int hMensais;
    double salario;
	// Use this for initialization
	void Start () {
        /*
        Um trabalhador recebe por hora R$ 50,00, porém o mesmo reveza o turno entre dia e noite. 
        Trabalhando no horario da noite, será acrescido 10% sobre a hora trabalhada caso o mesmo já 
        tenha trabalhado até 10 horas no mês e no horário da manhã será acrescido 8% a partir de 
        15º hora. Exiba o total a receber no dia trabalhado.
        */
        salario = 50.00;
        if (turno == "dia")
        {
            if (hMensais >= 15)
            {
                print((salario * hMensais) + (hMensais - 15 * (salario + (salario * 0.08))));
            }
            else
            {
                print(salario * hMensais);
            }
        }
        else if (turno == "noite")
        {
            if(hMensais >= 10)
            {
                print((salario * hMensais) + (hMensais - 10 * (salario + (salario * 0.10))));
            }
            else
            {
                print(salario * hMensais);
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
