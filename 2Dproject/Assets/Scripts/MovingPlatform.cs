using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private Vector3 posA, posB;
    [SerializeField]
    private float speed;
    private Vector3 nextPos;
    [SerializeField]
    private Transform childrenTransform;
    [SerializeField]
    private Transform transformB;
   
    void Start()
    {
        posB = transformB.localPosition;
        nextPos = posB;
        posA = childrenTransform.localPosition;
    }


    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        childrenTransform.localPosition = Vector3.MoveTowards(childrenTransform.localPosition, nextPos, speed * Time.deltaTime);
        if(Vector3.Distance(childrenTransform.localPosition, nextPos) <= 0.1)
        {
            changeDestination();
        }
    }

    private void changeDestination()
    {
        nextPos = nextPos != posA ? posA : posB;
    }
}
