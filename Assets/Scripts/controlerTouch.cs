using UnityEngine;
public class controlerTouch : MonoBehaviour
{
    public float lado = 10.0f;
    public void direita() 
    {
        transform.Translate(Vector3.left * Time.deltaTime * lado);
    }
    public void esquerda() 
    { 
        transform.Translate(Vector3.right * Time.deltaTime * lado); 
    }
}
