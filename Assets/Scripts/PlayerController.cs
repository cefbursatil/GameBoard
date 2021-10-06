using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int playerCoins = 3;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(4, 2, 1);
        transform.localScale = new Vector3(0.5f,0.5f,0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-1, 0, 0);
    }
}
