using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private PlayerInput playerInput;
    private PlayerInput playerInputActions;
    public float moveSpeed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        playerInputActions = new PlayerInput();
        playerInputActions.Player.Enable();
           
        //playerInputActions.Player.Movement.performed += Movement_Performed;

    }


    void FixedUpdate()
    {
        Vector2 movementInput = playerInputActions.Player.Movement.ReadValue<Vector2>();
        rb.AddForce(new Vector2(movementInput.x, movementInput.y) * moveSpeed, ForceMode2D.Force);
    }



}
