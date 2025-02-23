using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerators : MonoBehaviour
{
    public float mult;

    private void OnTriggerEnter(Collider other) {
        other.GetComponent<FirstPersonMovement>().runSpeed *= mult;
    }

    private void OnTriggerExit(Collider other) {
        other.GetComponent<FirstPersonMovement>().runSpeed /= mult;
    }
}
