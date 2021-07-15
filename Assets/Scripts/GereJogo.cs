using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum EstadosDoJogo {INICIAL, JOGANDO, PAUSADO };
public class GereJogo : MonoBehaviour
{

    public EstadosDoJogo estados = EstadosDoJogo.INICIAL;
    public GameObject[] interfaceInicial;
    public GameObject gereInterface;
    // Start is called before the first frame update

    public void IniciaJogo() 
    {
        //desativa interface
        foreach (GameObject elem in interfaceInicial) 
        {
            elem.SetActive(false);
        }

        //Ativa o gerenciador de obstaculos
        gereInterface.SetActive(true);

        Debug.Log("Iniciou Jogo!"); 


    }
}
