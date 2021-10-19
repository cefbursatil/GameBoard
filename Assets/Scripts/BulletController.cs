using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 direction = new Vector3(-0.001f, 0.0f, 0.0f);
    public float speed = 1;
    public float lifetimesecods = 10f;

    float speedBullet;
    void Start()
    {

        speedBullet = speed;
    }

    // Update is called once per frame
    void Update()
    {
        MoveBullet(Vector3.forward);
        lifetimesecods -= Time.deltaTime;
        if (lifetimesecods <= 0) Destroy(gameObject);
    }
    private void MoveBullet(Vector3 direction)
    {
        transform.Translate(speed * Time.deltaTime * direction);
    }
}
