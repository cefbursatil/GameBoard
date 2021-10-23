using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerasController : MonoBehaviour
{
    int cameraIndex;
    // Start is called before the first frame update
    public GameObject[] cameras;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            for (int i = 0; i < cameras.Length; i++)
            {
                if (cameras[i].activeInHierarchy)
                {
                    cameras[i].SetActive(false);
                    cameraIndex = i + 1;
                    cameraIndex %= cameras.Length;
                    Debug.Log("camera Index: " + cameraIndex);
                    cameras[cameraIndex].SetActive(true);
                    break;
                }
            }
        }
    }
}
