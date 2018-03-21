using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IfEncadeado : MonoBehaviour {
    public Button gasolina, alcool;
    string combustivel;
    double preco;
    int qtde;
    public Text total,qtdeText;
    void Start()
    {
        CalculaTotal();    
    }
    void Update()
    {
        total.text = "Total = R$" + (preco * qtde).ToString();
    }
    public void TrocarCombustivel(string tipo)
    {
        combustivel = tipo;
        CalculaTotal();
    }
    public void AddSub(string which)
    {
        if (which == "Mais")
        {
            qtde++;
            qtdeText.text = qtde.ToString();
        }
        if(which == "Menos")
        {
            qtde--;
            qtdeText.text = qtde.ToString();
        }
        CalculaTotal();
    }
    public void CalculaTotal()
    {
        
        if (combustivel == "G")
        {
            if (qtde <= 20)
            {
                preco = 3;
            }
            else
            {
                preco = 2.50;
            }

        }
        else if (combustivel == "A")
        {
            if (qtde <= 20)
            {
                preco = 2.50;
            }
            else
            {
                preco = 1.80;
            }
        }
        qtdeText.text = qtde.ToString();
    }

}
