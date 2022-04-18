using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class araba : MonoBehaviour
{
    public GameObject motorSeviyesi;
    void Start()
    {
        //GameObject.Find("seviyeBir").GetComponent<seviyeBirMotor>().motorGucu = 50;
        
        motorSeviyesi=GameObject.FindWithTag("dusmanlar");
        motorSeviyesi.GetComponent<SphereCollider>().isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
