using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// 
/// Copyright (c) 2020 All Rights Reserved
///
/// <author>Gonzako</author>
/// <co-authors>... </co-author>
/// <summary> Monobeavior class that does something </summary>

    [RequireComponent(typeof(LineRenderer))]
public class chainUpdater : MonoBehaviour
{

    #region PublicFields

    public Transform parentOfChain;

    public List<Transform> blackList;
    public List<Transform> addLast;
    #endregion

    #region PrivateFields

    LineRenderer lRenderer;
    
    #endregion

    #region UnityCallBacks

    // Start is called before the first frame update
    void Start()
    {
        lRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        var list = new List<Vector3>();
        for (int i = 0; i < parentOfChain.childCount; i++)
        {
            if(!blackList.Contains(parentOfChain.GetChild(i)))
                list.Add(parentOfChain.GetChild(i).position);
        }

        for (int i = 0; i < addLast.Count; i++)
        {
            list.Add(addLast[i].position);
        }

        lRenderer.positionCount = list.Count;
        lRenderer.SetPositions(list.ToArray());
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
