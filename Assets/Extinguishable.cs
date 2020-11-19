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


public class Extinguishable : MonoBehaviour
{

    #region PublicFields
    public int fireHealth = 500;
    public int midThreshold = 400, bottomThreshold = 200;
    public ParticleSystem topFire = null, midFire = null, lowFire = null;
    #endregion

    #region PrivateFields
    #endregion

    #region UnityCallBacks

    private void OnParticleCollision(GameObject other)
    {
        fireHealth--;
        if (fireHealth == midThreshold)
        {
            topFire.Stop();
            midFire.Play();
        } else if (fireHealth == bottomThreshold)
        {
            midFire.Stop();
            lowFire.Play();
        } else if(fireHealth < 0)
        {
            lowFire.Stop();
        }

    }


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

    #endregion


    #region PrivateMethods

    #endregion
}
