using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponentParentChild : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //GetComponentInParent<MeshCollider>().convex = true;
        // GetComponentInChildren<MeshCollider>().convex = false;
        /*
        MeshCollider[] degis = GetComponentsInParent<MeshCollider>();
        foreach (var parent in degis)
        {
            parent.GetComponentInParent<MeshCollider>().convex = true;
        }
        */
        MeshCollider[] degis = GetComponentsInChildren<MeshCollider>();
        foreach (var parent in degis)
        {
            parent.GetComponentInParent<MeshCollider>().convex = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
