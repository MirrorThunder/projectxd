
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public float velocidad = 10f;

    void Update()
    {
        transform.position += transform.forward * velocidad * Time.deltaTime;

        if (transform.position.x > 5 || transform.position.x < -5 ||
            transform.position.z > 5 || transform.position.z < -5)
        {
            Destroy(gameObject);
        }
    }
}
