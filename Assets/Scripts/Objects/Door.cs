using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, Action
{
    public string CloseAnim = "Doorclose";
    public string OpenAnim = "DoorOpen_";

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
            DoorAnimation.Play(CloseAnim);
            isopen = false;
        }
        else
        {
            DoorAnimation.Play(OpenAnim);
            isopen=true;
        }
    }
}
