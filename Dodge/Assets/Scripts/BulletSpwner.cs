using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpwner : MonoBehaviour
{
    public GameObject bulletPerfab;
    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 3f;

    private Transform target;
    private float spawnRata;
    private float timeAfterSpawn;
    // Start is called before the first frame update
    void Start()
    {
        timeAfterSpawn = 0f;

        spawnRata = Random.Range(spawnRateMin, spawnRateMax);

        target = FindObjectOfType<PlayerController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;

        if(timeAfterSpawn >= spawnRata)
        {
            timeAfterSpawn = 0f;

            GameObject bullet = Instantiate(bulletPerfab, transform.position, transform.rotation);

            bullet.transform.LookAt(target);

            spawnRata = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}
