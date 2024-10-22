using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour, Action
{
    public void Onpress()
    {
        Gamemanager.instance.updateWoodValue(Gamemanager.instance.GetWood()+1);
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
