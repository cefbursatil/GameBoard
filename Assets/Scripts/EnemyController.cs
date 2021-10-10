using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Dibuja una linea
        Debug.DrawLine(transform.position, new Vector3(5,0,0),Color.red,5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
