using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjeEtkilesimIslemleriBir : MonoBehaviour
{
    public int hp;
    public int saldýrý;
    public int savuma;
    public int temelSaldýrý;
    public int temelSavunma;
    private string seviyeBirAskerAdý = "baltalý piyade";
    private string seviyeÝkiAskerAdý= "kargýlý piyade";
    private string seviyeUcAskerAdý= "kalkanlý piyade";
    private string seviyeDortAskerAdý= "mýzraklý piyade";
    public int[] askerSeviyeleri1;
    public List<string> askerSeviyeleri;
    

    void Start()
    {
        askerSeviyeleri.Add(seviyeBirAskerAdý);
        askerSeviyeleri.Add(seviyeÝkiAskerAdý);
        askerSeviyeleri.Add(seviyeUcAskerAdý);
        askerSeviyeleri.Add(seviyeDortAskerAdý);


        foreach (var item in askerSeviyeleri)
        {
            Debug.Log(item);
            
        }


    }

    
    void Update()
    {
        
    }
}
