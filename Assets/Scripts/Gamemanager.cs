using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;

public class Gamemanager : MonoBehaviour
{

    public int wood;
    public static Gamemanager instance;
    public UnityEvent updateWood;

    private void Awake()
    {
        instance=this;
    }
    public int GetWood()
    {
        return wood;
    }
    public void updateWoodValue(int i)
    {
        wood=i;
        updateWood.Invoke();
    }

    void Start()
    {
        updateWoodValue(GetWood());
    } 
    
    void Update()
    {
        
    }
}
