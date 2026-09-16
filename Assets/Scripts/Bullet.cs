using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float cooldownTimer = 3f;
    public float timer = 0f;
    private Vector3 mousePos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePos - transform.position;
        Vector3 rotation = transform.position - mousePos;
        rb.linearVelocity = new Vector2(direction.x, direction.y).normalized * speed;
        float rot = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot + 90);
    }
    // Update is called once per frame
    void Update()
     {
    //     transform.position += Vector3.right * speed * Time.deltaTime;
    //     timer += Time.deltaTime; // count up in seconds

    //     if (timer >= cooldownTimer)
    //     {
    //         Destroy(gameObject);
    //     }
        
    }
}
