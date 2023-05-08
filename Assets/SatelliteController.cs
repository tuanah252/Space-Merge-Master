using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatelliteController : MonoBehaviour
{
    public GameObject target;
    public float radius = 2f;
    public float speed = 1f;

    private Vector3 center;

    private void Start()
    {
        center = target.transform.position;
    }

    private void Update()
    {
        center = target.transform.position;
        float time = Time.time * speed;
        float x = center.x + radius * Mathf.Sin(time);
        float y = center.y + radius * Mathf.Cos(time);
        transform.position = new Vector3(x, y, transform.position.z);
    }
}
