using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectWithTag : MonoBehaviour
{
    public GameObject [] nesne;
    // Start is called before the first frame update
    void Start()
    {
        nesne=GameObject.FindGameObjectsWithTag("seviye");
        
        foreach (var item in nesne)
        {
            item.GetComponent<SphereCollider>().isTrigger = true;
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
