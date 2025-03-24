using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandon : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject gamePrefabs;
    [SerializeField] float timeSpawn;
    [SerializeField] float minX;
    [SerializeField] float maxX;
    private float timeCooldown;
    void Start()
    {
        gamePrefabs = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        Spawn();
        
    }

    public void Spawn()
    {
        timeCooldown -= Time.deltaTime;
        if (timeCooldown < 0)
        {
            Vector3 position = new Vector3(Random.Range(minX, maxX), 10f, 0);
            Instantiate(gamePrefabs, position, Quaternion.identity);
        }
    }
}
