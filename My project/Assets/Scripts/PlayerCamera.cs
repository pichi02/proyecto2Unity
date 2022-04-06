using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private Transform target;

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position + target.forward * offset.z + target.up * offset.y;

    }
}
