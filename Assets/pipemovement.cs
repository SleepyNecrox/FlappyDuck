using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemovement : MonoBehaviour
{
    [SerializeField] private float speed = 0.05f;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed;
    }
}
