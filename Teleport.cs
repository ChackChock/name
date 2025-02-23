using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Teleport : MonoBehaviour
{
    public Transform goalCoords;
    // *модификатор доступа* *тип данных* *название поля*;

    void OnTriggerEnter(Collider other) {
        other.transform.position = goalCoords.position;
    }

    private int health = 10;

    public int get_health(int mult, int minus) {
        return health * mult - minus;
    }

    void Start() {
        int hahaha = get_health(20, 5);
    }
}
