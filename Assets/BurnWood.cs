using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnWood : MonoBehaviour,Action
{
    Gamemanager g;
    public GameObject Fire;
    MeshRenderer mr;
    public void Onpress()
    {
        if(g.wood <= 0)
        {
            Fire.SetActive(false);
            return;
        }
        g.updateWoodValue(g.GetWood()-1);
        Fire.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        g = GameObject.FindGameObjectWithTag("Manager").GetComponent<Gamemanager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
