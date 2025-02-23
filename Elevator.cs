using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    public float speed = 2f;

    void Start() {
        transform.position = startPoint.position;
    }

    void Update() {
        transform.position = Vector3.MoveTowards(
            transform.position,
            endPoint.position,
            speed * Time.deltaTime
        );
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == endPoint.tag) {
            Transform temp = startPoint;
            startPoint = endPoint;
            endPoint = temp;
        }
    }
}
