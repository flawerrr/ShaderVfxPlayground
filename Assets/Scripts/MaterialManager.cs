using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]

public class MaterialManager : MonoBehaviour
{
    [SerializeField] private Material thisMaterial;
    [SerializeField] [Range(-0.1f, 1f)]private float step = 1f;

    private void Update()
    {
        SetStepValue();
    }

    private void SetStepValue()
    {
        thisMaterial.SetFloat("_Step", step);
    }
}
