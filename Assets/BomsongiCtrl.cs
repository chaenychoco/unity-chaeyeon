using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomsongiCtrl : MonoBehaviour {

    float timer = 0.0f;
    bool is_shot = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
    }

    public void Shoot(Vector3 dir){
        GetComponent<Rigidbody>().AddForce(dir);
    }
    void OnCollisionEnter(Collision other){
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
        Vector3 collided_position = transform.position;
        float distance = collided_position.x * (collided_position.y - 6.5f);
        distance = Mathf.Sqrt(distance);
        Debug.Log(collided_position);
        Debug.Log(distance);
    }

}