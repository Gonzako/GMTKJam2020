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


public class chainCreator : MonoBehaviour
{

    #region PublicFields
    public Transform startPoint, endPoint;
    public GameObject ropePrefab;
            

    [Range(1, 50)]
    public int wireSegments = 1;
    #endregion

    #region PrivateFields
    [SerializeField]
    private List<GameObject> chainList = new List<GameObject>();
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

    [ContextMenu("Generate Chain")]
    public void generateChain()
    {
        float distance = Vector3.Distance(startPoint.position, endPoint.position);
        Vector3 direction = (endPoint.position - startPoint.position);
        direction.z = 0;
        direction = direction.normalized;

        if(chainList.Count > 0)
        {
            foreach(GameObject n in chainList)
            {
                DestroyImmediate(n);
            }
            chainList.Clear();
        }
                
        chainList.Add(Instantiate(ropePrefab));
        var currentGO = chainList[0];
        currentGO.transform.parent = transform;
        currentGO.transform.right = direction;
        currentGO.transform.position = startPoint.position+direction*(distance/(2*wireSegments));
        var newScale = currentGO.transform.localScale;
        var currCol = currentGO.GetComponent<Collider>();
        
        newScale.x = distance / (2 * wireSegments);
        newScale.x /= currCol.bounds.extents.x;
        currentGO.transform.localScale = newScale;
        var currentJoint = currentGO.AddComponent<HingeJoint>();
        currentJoint.axis = Vector3.forward;
        currentJoint.anchor = Vector3.left*currCol.bounds.extents.x;

        for (int i = 1; i < wireSegments; i++)
        {
            chainList.Add(currentGO = Instantiate(ropePrefab));

            currentGO.transform.parent = transform;
            currentGO.transform.right = direction;
            currentGO.transform.position = startPoint.position + 
                    direction * (distance / (2 * wireSegments))*(2*i+1);
            //currentGO.transform.position.z -= 0;

            newScale = currentGO.transform.localScale;
            currCol = currentGO.GetComponent<Collider>();

            newScale.x = distance / (2 * wireSegments);
            newScale.x /= currCol.bounds.extents.x;
            currentGO.transform.localScale = newScale;

        }

    }

    #endregion


    #region PrivateMethods

    #endregion
}
