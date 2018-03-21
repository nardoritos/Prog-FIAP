using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IfEncadeado : MonoBehaviour {
    public Button gasolina, alcool;
    public string combustivel;
    double preco;
    public  int qtde;
    public Text text;
	// Use this for initialization
	void Start () {
        if (combustivel == "G")
        {
            if(qtde <=20)
            {
                preco = 3;
            }
            else
            {
                preco = 2.50;
            }

        }
        else if(combustivel == "A")
        {
            if(qtde <= 20)
            {
                preco = 2.50;
            }
            else
            {
                preco = 1.80;
            }
        }

        text.text = "Total = R$" + (preco * qtde).ToString();
        	}

    // Update is called once per frame
    void Update()
    {

    }
}
