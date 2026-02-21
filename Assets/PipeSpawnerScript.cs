using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
    
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 0.1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        } else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {   
        float lowestPoint = -7.5f;
        float highestPoint = 7.5f;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
