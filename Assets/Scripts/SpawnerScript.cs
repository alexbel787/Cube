using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerScript : MonoBehaviour
{
    public GameObject cubePrefab;
    [SerializeField] private float time;
    [SerializeField] private float speed;
    [SerializeField] private float distance;

    public InputField[] inputFields;

    private void Start()
    {
        inputFields[0].text = time.ToString();
        inputFields[1].text = speed.ToString();
        inputFields[2].text = distance.ToString();
        StartCoroutine(SpawnCoroutine());
    }

    private IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            GameObject cube = Instantiate(cubePrefab, transform.position, Quaternion.identity);
            var cubeScript = cube.GetComponent<CubeScript>();
            cubeScript.speed = speed;
            cubeScript.distance = distance;
            float timer = 0;
            while (timer < time)
            {
                timer += Time.deltaTime;
                yield return null;
            }
        }
    }

    public void SetTime()
    {
        time = float.Parse(inputFields[0].text);
    }

    public void SetSpeed()
    {
        speed = float.Parse(inputFields[1].text);
    }

    public void SetDistance()
    {
        distance = float.Parse(inputFields[2].text);
    }
}
