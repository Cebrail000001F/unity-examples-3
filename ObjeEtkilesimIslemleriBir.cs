using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjeEtkilesimIslemleriBir : MonoBehaviour
{
    public int hp;
    public int saldırı;
    public int savuma;
    public int temelSaldırı;
    public int temelSavunma;
    private string seviyeBirAskerAdı = "baltalı piyade";
    private string seviyeİkiAskerAdı= "kargılı piyade";
    private string seviyeUcAskerAdı= "kalkanlı piyade";
    private string seviyeDortAskerAdı= "mızraklı piyade";
    public int[] askerSeviyeleri1;
    public List<string> askerSeviyeleri;
    

    void Start()
    {
        askerSeviyeleri.Add(seviyeBirAskerAdı);
        askerSeviyeleri.Add(seviyeİkiAskerAdı);
        askerSeviyeleri.Add(seviyeUcAskerAdı);
        askerSeviyeleri.Add(seviyeDortAskerAdı);


        foreach (var item in askerSeviyeleri)
        {
            Debug.Log(item);
            
        }


    }

    
    void Update()
    {
        
    }
}
