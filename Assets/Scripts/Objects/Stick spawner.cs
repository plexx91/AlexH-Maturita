using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stickspawner : MonoBehaviour

{
    public GameObject Stick;
    public GameObject Ground;
    public int spawningamount;

    void Start()
    {
        Spawningstick();
    }

    private void Spawningstick ()
    {
        BoxCollider box = Ground.GetComponent<BoxCollider>();
        RaycastHit hit;
        for (int i = 0; i < spawningamount; i++)
        {

           bool connected= Physics.Raycast(new Vector3(Ground.transform.position.x+Random.Range(-box.size.x,box.size.x), 20, Ground.transform.position.z+ Random.Range(-box.size.z, box.size.z)), Ground.transform.up * -1, out hit, 30);
            Instantiate(Stick, hit.transform.position, hit.transform.rotation);
            Debug.Log(hit.collider.name);
        }
    }


   
  
}
