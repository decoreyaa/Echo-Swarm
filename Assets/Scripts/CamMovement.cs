using UnityEngine;

public class CamMovement : MonoBehaviour
{
public Transform player;
public float speed;
public Vector3 offset;
    void Start()
    {
        
    }


    void Update()
    {
        Vector3 desiredPos = player.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPos, speed * Time.deltaTime);
        
    }
}
