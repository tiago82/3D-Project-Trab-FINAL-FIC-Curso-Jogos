using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Personagem;
    public float altura;
    public float distanciaCamera;
    public float delay;

    void Update()
    {
        float x = Personagem.transform.position.x - transform.position.x;
        float z = Personagem.transform.position.z - distanciaCamera - transform.position.z;
        transform.Translate(x * Time.deltaTime * delay, 0, z);
    }
}
