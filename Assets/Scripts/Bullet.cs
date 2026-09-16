using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float cooldownTimer = 3f;
    public float timer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;

        timer += Time.deltaTime; // count up in seconds

        if (timer >= cooldownTimer)
        {
            Destroy(gameObject);
            timer = 0f; // reset the timer
        }
        
    }
}
