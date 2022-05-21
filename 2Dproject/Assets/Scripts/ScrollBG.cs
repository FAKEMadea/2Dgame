using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBG : MonoBehaviour
{
    public Transform MainCam;
    public Transform middleBG;
    public Transform sideBG;
    public float length;

    void Update()
    {
        if (MainCam.position.x > middleBG.position.x)
        {
            sideBG.position = middleBG.position + Vector3.right * length;
        }

        if(MainCam.position.x < middleBG.position.x)
        {
            sideBG.position = middleBG.position + Vector3.left * length;
        }

        if(MainCam.position.x >sideBG.position.x || MainCam.position.x < sideBG.position.x)
        {
            Transform p = middleBG;
            middleBG = sideBG;
            sideBG = p;
        }
    }
}
