using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, Action
{
    public void Onpress()
    {
        Toggledoor();
    }

    public Animator DoorAnimation;

  

    public bool isopen;

    public void Toggledoor()
    {
        if (isopen)
        {
            DoorAnimation.Play("Doorclose");
            isopen = false;
        }
        else
        {
            DoorAnimation.Play("DoorOpen_");
            isopen=true;
        }
    }
}
