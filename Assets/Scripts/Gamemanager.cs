using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{

    public int wood;
    public static Gamemanager instance;
    public UnityEvent updateWood;
    public List<GameObject> coldControlers;

    public float duration = 600;
    public float _currentDuration;
    [HideInInspector]
    public bool _isColliding = true;

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
        _currentDuration = duration;
    } 
    
    void Update()
    {
        _isColliding = Check();
        if (_isColliding)
        {
            _currentDuration -= Time.deltaTime;
        }
        if (_currentDuration < 0)
        {
            Exit();
        }
    }

    private bool Check()
    {
        return coldControlers.Count > 0 ? false : true;
    }

    public void AddTime(float addition)
    {
        _currentDuration += addition;
    }

    private void Exit()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene("Main Menu");
    }
}
