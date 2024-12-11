using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MatrixHelpers;
using System;

public class MatrixTest : MonoBehaviour
{
    // Start is called before the first frame update
    double[][] mat1= Matrix.MatrixIdentity(3);
    double[][] mat2= Matrix.MatrixIdentity(3);

    public double m1, m2, m3, m4, m5, m6, m7, m8;

    void Start()
    {
        Debug.Log(Matrix.PrintMatrix(mat1));
        Debug.Log(Matrix.PrintMatrix(Matrix.MatrixInverse(mat1)));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
