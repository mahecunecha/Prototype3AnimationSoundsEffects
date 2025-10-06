using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// antes de empezar, que queremos ser? y que elementos, y componentes tenemos para poder lograrlo.

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb; // al estar privada no conocer a nadie, ni al rigibody 
    public float jumpForce = 10; // definimos fuerza de salto   
    public float gravityModifier; // guardamos en esta variable la gravedad que se maneje

    public bool isOnGround = true;

    // Start is called before the first frame update
    void Start()
    {
        // como el player contiene el rigibody, se lo asignamos a ese componente rigibody que tiene en el inspector
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier; // uno = uno * dos; === uno *= dos;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {

            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // este metodo me ayuda a aplicar fuerzas a un rigibody(fuerza, dirección)
            
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}
