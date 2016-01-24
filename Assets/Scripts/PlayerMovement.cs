using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float _MovementForce;

    private Rigidbody _Rigidbody = null;

    private void Awake()
    {
        _Rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        _Rigidbody.velocity = new Vector3(moveX * _MovementForce, -2.0f, 0.0f);
    }
}
