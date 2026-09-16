using UnityEngine;

public class AiChase : MonoBehaviour
{
    public GameObject player;
    private float distance;
    public float moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         //Gets distance between target and current object
        distance = Vector2.Distance(transform.position, player.transform.position);
        //gets the direction of target
        Vector2 direction = player.transform.position - transform.position;
        direction = direction.normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, moveSpeed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(Vector3.forward * angle);
    }
}
