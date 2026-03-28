using UnityEngine;

public class BolaController : MonoBehaviour
{
    public float fuerzaLanzamiento = 600f;
    public Transform direccionLanzamiento;

    Rigidbody rb;
    Vector3 posicionInicial;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        posicionInicial = transform.position;
    }

    void Update()
    {
        
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(direccionLanzamiento.forward * fuerzaLanzamiento);
        }

        
        if (transform.position.y < -5f)
        {
            ReiniciarBola();
        }
    }

    void ReiniciarBola()
    {
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.position = posicionInicial;
    }
}
