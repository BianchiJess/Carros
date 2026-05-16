using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private float speed = 15f;
    private float turnSpeed = 100f;

    private Vector2 moveInput;

    public void OnMove(InputValue input)
    {
        moveInput = input.Get<Vector2>();
    }

    private void Update()
    {
        Move();
        
    }

    private void Move()
    {

        //Frente e para trás
        transform.Translate(Vector3.forward * moveInput.y * speed * Time.deltaTime);

        //Girar
        transform.Rotate(Vector3.up * moveInput.x * turnSpeed * Time.deltaTime);
    }
}
