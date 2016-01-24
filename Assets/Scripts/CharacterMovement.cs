using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour
{
    public float _MoveForce;
    public float _JumpForce;

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * _MoveForce;
        if(!GetComponent<CharacterController>().SimpleMove(new Vector3(moveX, 0.0f, 0.0f)))
        {
            GetComponent<CharacterController>().Move(new Vector3(moveX * 0.0025f, 0.0f, 0.0f));
        }

        if(Input.GetButtonDown("Jump"))
        {
            GetComponent<CharacterController>().Move(new Vector3(0.0f, _JumpForce, 0.0f));
        }
    }
}
