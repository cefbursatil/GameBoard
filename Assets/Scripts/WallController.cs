using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    [SerializeField] private Vector3 rangeMovement = new Vector3(2f, 2f, 2f);
    [SerializeField] private float stayTime = 2;
    private float collisionTime=0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay(Collision collision)
    {
        float maxX = rangeMovement.x;
        float maxY = rangeMovement.y;
        float maxZ = rangeMovement.z;
        Vector3 randVector= new Vector3(Random.Range(-maxX, maxX), Random.Range(-maxY, maxY), Random.Range(-maxZ, maxZ));
        collisionTime += Time.deltaTime;
        if (collisionTime >= stayTime && collision.gameObject.CompareTag("Player"))
        {
            
            transform.position = randVector;
            Vector3 vectorRot = randVector;
            Quaternion rotation = Quaternion.LookRotation(vectorRot);
            transform.rotation = rotation;
            collisionTime = 0f;
        }
    }
}
