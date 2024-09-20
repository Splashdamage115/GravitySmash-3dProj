using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    private Vector3 move;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        move.x = movementVector.x;
        move.z = movementVector.y;
        move.y = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        rb.AddForce(move * speed * Time.deltaTime);
    }
}
