﻿///////////////////////////////////////
// Práctica: Roll-a-ball
// Alumno/a: Alejandro Snatillana Ruiz
// Curso: 2017/2018
// Fichero: Rotator.cs
///////////////////////////////////////
using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}