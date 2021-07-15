using UnityEngine;
public class GereObstaculoDog : MonoBehaviour
{
    public GameObject obstaculo;
    public Vector3 posInicial;
    public float tempIntanciamento;
    public float cronometro;
    public float rotacao;
    void Start()
    {
        Instantiate(obstaculo, posInicial, Quaternion.Euler(0.0f, 90.0f, 0.0f));
        cronometro = 0.0f;
    }
    void Update()
    {
        cronometro += Time.deltaTime;
        if (cronometro > tempIntanciamento)
        {
            posInicial.x = Random.Range(-3.5f, 5.5f);
            //Instantiate(obstaculo, posInicial, Quaternion.identity);         
            Instantiate(obstaculo, posInicial, Quaternion.Euler(0.0f, rotacao, 0.0f));
            cronometro = 0.0f;
        }
    }
}



