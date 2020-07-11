using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// 
/// Copyright (c) 2020 All Rights Reserved
///
/// <author>Gonzako</author>
/// <co-authors>... </co-author>
/// <summary> Monobeavior class that does something </summary>


public class addForceOposedOfMouseDirection : MonoBehaviour
{

    #region PublicFields

    public float forceAmount = 10f;

    #endregion

    #region PrivateFields

    private Camera cam;
    private Rigidbody2D rb;

    #endregion

    #region UnityCallBacks

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable()
    {
    
    }

    private void FixedUpdate()
    {
        var mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        var forceDir = ((transform.position - mousePos));
        forceDir.z = 0;
        forceDir = forceDir.normalized;

        Debug.Log(forceDir.magnitude);
        Debug.Log(forceDir);

        rb.AddForce(forceDir * forceAmount / Time.fixedDeltaTime);

    }

    #endregion

    #region PublicMethods

    #endregion


    #region PrivateMethods

    #endregion
}
