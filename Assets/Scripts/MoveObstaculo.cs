using UnityEngine;

public class MoveObstaculo : MonoBehaviour
{
    public Vector3 velObstaculo;
    void Update()
    {
        transform.Translate(velObstaculo * Time.deltaTime);
        if (transform.position.z < -9.5f)
        {
            Object.Destroy(gameObject);
        }
    }
}
