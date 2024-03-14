using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSin : MonoBehaviour
{
    float sinCenterY;
    [SerializeField] float amplitude;
    [SerializeField] float frequency;
    void Start()
    {
        sinCenterY = transform.position.y;
        int direction = Random.Range(0, 2);
        if (direction == 0)
        {
            amplitude = -amplitude;
        }
    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        float sin = Mathf.Sin(Time.time * frequency) * amplitude;
        pos.y = sinCenterY + sin;

        transform.position = pos;
    }
}
