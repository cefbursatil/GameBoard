using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonController : MonoBehaviour
{
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    public float startDelay = 2f;
    public float spawnInterval = 1.5f;
    void Start()
    {

        InvokeRepeating("SpawnBullet", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bulletPrefab.transform.localScale = bulletPrefab.transform.localScale * 2;
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            bulletPrefab.transform.localScale = bulletPrefab.transform.localScale * 0.5f;
        }
    }
    void SpawnBullet()
    {
        Instantiate(bulletPrefab, transform.position, bulletPrefab.transform.rotation);
    }
}
