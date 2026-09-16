using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed  = 3f;
    public float timer = 0f;
    public float directionChangeInterval = 3f;
   Vector2 moveDirection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        PickNewDirection(); // Pick an initial direction to move in
    }

    // Update is called once per frame
    void Update()
    {
        
        timer += Time.deltaTime; // count up in seconds

        if (timer >= directionChangeInterval)
        {
            PickNewDirection(); // pick a new direction
            timer = 0f; // reset the timer
        }
        

    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveDirection * moveSpeed * Time.fixedDeltaTime);
    }

    public void PickNewDirection()
    {
        // Pick a random direction to move in
        moveDirection = Random.insideUnitCircle.normalized;
    }
}
