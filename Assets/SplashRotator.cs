using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// 
/// Copyright (c) 2020 All Rights Reserved
///
/// <author>Gonzako</author>
/// <co-authors>... </co-author>
/// <summary> Monobeavior class that does something </summary>


public class SplashRotator : MonoBehaviour
{

    #region PublicFields
    #endregion

    #region PrivateFields
    [SerializeField]
    ParticleSystem targetSys = null;
    ParticleSystem partSys   = null;
    List<ParticleCollisionEvent> partEvents;
    #endregion

    #region UnityCallBacks

    // Start is called before the first frame update
    void Start()
    {
        partSys = GetComponent<ParticleSystem>();
        partEvents = new List<ParticleCollisionEvent>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnEnable()
    {
 
    }

    private void OnParticleCollision(GameObject other)
    {
        int numCols = partSys.GetCollisionEvents(other, partEvents);

        for (int i = 0; i < numCols; i++)
        {
            var main = targetSys.main;
            main.startRotationZ = Vector3.Angle(partEvents[i].normal, Vector3.up);

        }
    }
    #endregion

    #region PublicMethods

    #endregion


    #region PrivateMethods

    #endregion
}
