using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]

public class NormalVectorCalculator : MonoBehaviour
{
    public Transform LightSourceTransform;
    public Transform objectTransform;
    public Material objectMaterial;

    private void Update()
    {
        Vector3 temp = LightSourceTransform.position - objectTransform.position;
        objectMaterial.SetVector("_LightSourceVector", temp);
    }
}
