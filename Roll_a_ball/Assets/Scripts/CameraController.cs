///////////////////////////////////////
// Práctica: Roll-a-ball
// Alumno/a: Alejandro Snatillana Ruiz
// Curso: 2017/2018
// Fichero: CameraController.cs
///////////////////////////////////////
using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}