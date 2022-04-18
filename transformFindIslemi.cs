using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformFindIslemi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Find("seviyeBirDusman").GetComponent<BoxCollider>().isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
