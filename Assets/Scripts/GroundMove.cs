using UnityEngine;

public class GroundMove : MonoBehaviour
{
    public Vector3 vel;
    public float distanciaDoSwapChao = 60.0f;
    public float tamanhododeCadaChao = -10.0f;
    void Update()
    {
        transform.Translate(vel * Time.deltaTime);
        if (transform.position.z < tamanhododeCadaChao)
        {
            float repos = distanciaDoSwapChao - (tamanhododeCadaChao - transform.position.z);
            transform.position = new Vector3(0.0f, 0.0f, repos);
        }
    }
}
