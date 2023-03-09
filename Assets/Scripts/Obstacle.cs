using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Obstacle : MonoBehaviour
{
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    

    private void OnBecameInvisible()
    {
        
        //Destroy obstacle when its off camera
        Destroy(gameObject);
    }
}
