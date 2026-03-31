using UnityEngine;

public class scMovementWASD : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float velocidade = 15f;
    public float rotacion = 150f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * vertical * velocidade * Time.deltaTime);
        transform.Rotate(Vector3.up * horizontal * rotacion * Time.deltaTime);

    }
}
