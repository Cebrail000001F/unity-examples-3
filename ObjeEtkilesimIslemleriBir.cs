using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjeEtkilesimIslemleriBir : MonoBehaviour
{
    public int hp;
    public int sald�r�;
    public int savuma;
    public int temelSald�r�;
    public int temelSavunma;
    private string seviyeBirAskerAd� = "baltal� piyade";
    private string seviye�kiAskerAd�= "karg�l� piyade";
    private string seviyeUcAskerAd�= "kalkanl� piyade";
    private string seviyeDortAskerAd�= "m�zrakl� piyade";
    public int[] askerSeviyeleri1;
    public List<string> askerSeviyeleri;
    

    void Start()
    {
        askerSeviyeleri.Add(seviyeBirAskerAd�);
        askerSeviyeleri.Add(seviye�kiAskerAd�);
        askerSeviyeleri.Add(seviyeUcAskerAd�);
        askerSeviyeleri.Add(seviyeDortAskerAd�);


        foreach (var item in askerSeviyeleri)
        {
            Debug.Log(item);
            
        }


    }

    
    void Update()
    {
        
    }
}
