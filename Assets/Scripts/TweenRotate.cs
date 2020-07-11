using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// 
/// Copyright (c) 2020 All Rights Reserved
///
/// <author>Gonzako</author>
/// <co-authors>... </co-author>
/// <summary> Monobeavior class that does something </summary>


public class TweenRotate : MonoBehaviour
{

    #region PublicFields
    [SerializeField]
    public Vector3 targetRot = Vector3.forward * 45;
    

    #endregion

    #region PrivateFields

    #endregion

    #region UnityCallBacks

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable()
    {
    
    }

    #endregion

    #region PublicMethods

    public void tweenToRotation(float time)
    {
        transform.DORotateQuaternion(Quaternion.Euler(targetRot), time);
    }

    #endregion


    #region PrivateMethods

    #endregion
}
