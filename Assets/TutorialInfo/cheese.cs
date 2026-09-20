using UnityEngine;

public class Chesse : MonoBehaviour
{
    public float rotationSpeed = 100f;
    public float moveHeight = 0.5f;
    public float moveSpeed = 2f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Rotate
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);

        // Move up and down
        float newY = startPosition.y +
                     Mathf.Sin(Time.time * moveSpeed) * moveHeight;

        transform.position = new Vector3(
            startPosition.x,
            newY,
            startPosition.z
        );
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}