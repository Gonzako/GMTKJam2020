using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// 
/// Copyright (c) 2020 All Rights Reserved
///
/// <author>Gonzako</author>
/// <co-authors>... </co-author>
/// <summary> Monobeavior class that does something </summary>


public class mirrorRotation : MonoBehaviour
{

    #region PublicFields
    public Transform target;
    #endregion

    #region PrivateFields

    #endregion

    #region UnityCallBacks

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.rotation = target.rotation;
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
