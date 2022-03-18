using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public float speed;
    public float distance;
    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + Time.deltaTime * speed);
        if (Vector3.Distance(startPos, transform.position) >= distance) Destroy(gameObject);
    }
}
