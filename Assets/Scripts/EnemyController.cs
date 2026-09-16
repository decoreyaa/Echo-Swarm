using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject player;
    private float distance;
    private Rigidbody2D rb;
    public float moveSpeed;
    public float timer = 0f;
    public float directionChangeInterval = 3f;
    public Vector2 moveDirection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //PickNewDirection(); // Pick an initial direction to move in
    }

    // Update is called once per frame
    void Update()
    {
        
        //timer += Time.deltaTime; // count up in seconds

        // if (timer >= directionChangeInterval)
        // {
        //     PickNewDirection(); // pick a new direction
        //     timer = 0f; // reset the timer
        // }
        
        //Gets distance between target and current object
        distance = Vector2.Distance(transform.position, player.transform.position);
        //gets the direction of target
        Vector2 direction = player.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position,player.transform.position, moveSpeed + Time.deltaTime);
        

    }
    void FixedUpdate()
    {
        //rb.MovePosition(rb.position + moveDirection * moveSpeed * Time.fixedDeltaTime);
    }

    public void PickNewDirection()
    {
        // Pick a random direction to move in
        moveDirection = Random.insideUnitCircle.normalized;
    }

    public void AiChase()
    {
        //Gets distance between target and current object
        distance = Vector2.Distance(transform.position, player.transform.position);
        //gets the direction of target
        Vector2 direction = player.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position,player.transform.position, moveSpeed + Time.deltaTime);
    }
}
