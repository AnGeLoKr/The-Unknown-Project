using UnityEngine;
using System.Collections;

public class ObjectMovement : MonoBehaviour
{

    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
       //controlla se l'oggetto che si sta controllando sta collidendo con il terreno
        if (controller.isGrounded)
        {
            //sposta l'oggetto tramite input
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            //moltiplica la velocità di spostamento per la velocità assegnatagli
            moveDirection *= speed;
            //se il bottone che viene premuto è la barra, allora l'oggetto salta a seconda della velocità del salto assegnatagli
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;

        }
        //se l'oggetto che si sta controllando non sta collidendo con il terreno allora, ad esso gli viene applicata la forza di gravità assegnatagli
        moveDirection.y -= gravity * Time.deltaTime;
        //comando effettivo che fa spostare il personaggio sullo schermo
        controller.Move(moveDirection * Time.deltaTime);
    }
}
