using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongi_prefab;

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            GameObject bamsongi = Instantiate(bamsongi_prefab) as GameObject;
            Ray screen_ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 shooting_ray = screen_ray.direction;
            bamsongi.GetComponent<BomsongiCtrl>().Shoot(shooting_ray*1000);   //bomsongi로 오타내서 그냥 그걸로함
        }
        
    }
}
