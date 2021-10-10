using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordController : MonoBehaviour
{
    public string nameSword = "Muramasa";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string GetSwordName()
    {
        return nameSword;
    }

    public void SetSwordName(string newSwordName)
    {
        nameSword = newSwordName;
    }

}
