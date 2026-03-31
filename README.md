# PrimerTerreno
Archivo del trabajo "Taller: Desarrollo de terrenos y programación del movimiento de un cubo en Unity"

Para el movimiento del cubo, se le añadió y editó un script, declarando la velocidad y la rotación. Nos permite mover el objeto con "W" y "S" para adelante y atrás, mientras que "A" y "D" rota al estilo de un volante. Además que se unió la cámara con el cubo para que esta le siga. Teniendo en cuenta este método, dentro del proyecto se realizó el siguiente cambio: Edit > Project Settings > Player > Other Settings. En la opción "Active Input Handling" se cambió para que sea "both" (ambos), ya que con el script realizado, choca con el nuevo Input manager de Unity al ser el sistema anterior.

- A continuación, el script:

using UnityEngine;

public class MovimientoWASD : MonoBehaviour

{

public float velocidad = 5f;

public float rotacion = 200f;


void Update()

  {

  float moverZ = Input.GetAxis("Vertical");
  
  float rotarx = Input.GetAxis("Horizontal");
  
  
  transform. Translate(Vector3.forward * moverZ * velocidad * Time.deltaTime);
  
  transform.Rotate(Vector3.up * rotarx * rotacion * Time.deltaTime);
  
  }
  
}


