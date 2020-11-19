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
    public bool fixZ = true;
    #endregion

    #region PrivateFields

    private Camera cam;
    private Rigidbody rb;

    #endregion

    #region UnityCallBacks

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        rb = GetComponent<Rigidbody>();
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
        if(fixZ) forceDir.z = 0;

        forceDir = forceDir.normalized;

        //Debug.Log(forceDir.magnitude);
        //Debug.Log(forceDir);

        rb.AddForce(forceDir * forceAmount / Time.fixedDeltaTime);
        rb.velocity -= Vector3.forward*rb.velocity.z;
        transform.position -= Vector3.forward * transform.position.z;
    }

    #endregion

    #region PublicMethods

    #endregion


    #region PrivateMethods

    #endregion
}
