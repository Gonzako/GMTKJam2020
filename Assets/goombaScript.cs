using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// 
/// Copyright (c) 2020 All Rights Reserved
///
/// <author>Gonzako</author>
/// <co-authors>... </co-author>
/// <summary> Monobeavior class that does something </summary>

[RequireComponent(typeof(constantTransformMove))]
public class goombaScript : MonoBehaviour
{

    #region PublicFields

    public Transform start;
    public Transform end;
    public float speed = 1;

    #endregion

    #region PrivateFields

    private constantTransformMove mover;
    private Vector3 target;
    private bool toEnd = false;
    #endregion

    #region UnityCallBacks

    // Start is called before the first frame update
    void Start()
    {
        target = start.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(target, transform.position) < 0.4f || Vector3.Distance(target, transform.position) > Vector3.Distance(start.position, end.position))//Hard coded value
        {
            if (toEnd)
            {
                target = end.position;
                toEnd = false;
            }
            else
            {
                target = start.position;
                toEnd = true;
            }
        }
        var dir = target - transform.position;
        dir.z = 0;
        dir = dir.normalized;

        mover.velocityValue = dir * speed;
    }

    void OnEnable()
    {
    
    }

    #endregion

    #region PublicMethods

    #endregion


    #region PrivateMethods

    #endregion
}
