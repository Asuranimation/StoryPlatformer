using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    public Camera cam;
    public Transform subject;

    private Vector2 startPosition;
    private float startZ;

    private Vector2 travel => (Vector2)cam.transform.position - startPosition;

    private float distanceFromSubject => transform.position.z - subject.position.z;
    private float clippingPlane => (cam.transform.position.z + (distanceFromSubject > 0? cam.farClipPlane : cam.nearClipPlane));

    private float paralaxFactor => Mathf.Abs(distanceFromSubject) / clippingPlane;
    
    void Start()
    {
        startPosition = transform.position;
        startZ = transform.position.z;
    }

    void Update()
    {
       Vector2 newPos = startPosition + travel * paralaxFactor;
       transform.position = new Vector3(newPos.x, newPos.y, startZ);

    }
}
