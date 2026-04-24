using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menospontos : MonoBehaviour
{
    public LixoSapawner lixosapawner;
    private void OnCollisionEnter(Collision collision){

        if (collision.gameObject.CompareTag("Lixo"))
        {
            lixosapawner.AddToPoints(-1);            
            Destroy(collision.gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}