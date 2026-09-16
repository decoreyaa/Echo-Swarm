using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Bullet bulletPrefab;
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
        rb.linearVelocity = movementInput * moveSpeed;

        
    }
    
    void Update()
    {
        // Handle player input and movement here
        if (playerInputActions.Player.Attack.triggered)
        {
            Shoot();
        }

        MousePosition();
    }

   

    private void Shoot()
    {
        // Implement shooting logic here
        Instantiate(bulletPrefab, transform.position, transform.rotation);
        Debug.Log("Shoot!");
    }

    private void MousePosition()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePos - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

}
