using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cold : MonoBehaviour
{

    public float duration = 600;

    private float _currentDuration;

    private bool _isColliding = true;


    // Start is called before the first frame update
    void Start()
    {
        _currentDuration = duration;
    }

    // Update is called once per frame
    void Update()
    {
        if (_isColliding) 
        {
            _currentDuration -= Time.deltaTime;
        }
        if (_currentDuration < 0)
        {
            Exit();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            _isColliding = false;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            _isColliding = true;
    }

    public void AddTime(float addition)
    {
        _currentDuration += addition;
    }

    private void Exit()
    {

    }
}
