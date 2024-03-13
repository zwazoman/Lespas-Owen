using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSin : MonoBehaviour
{
    float sinCenterX;
    [SerializeField] float amplitude;
    [SerializeField] float frequency;
    void Start()
    {
        sinCenterX = transform.position.x;
        int direction = Random.Range(0, 2);
        if (direction == 0)
        {
            amplitude = -amplitude;
        }
    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        float sin = Mathf.Sin(pos.y * frequency) * amplitude;
        pos.x = sinCenterX + sin;

        transform.position = pos;
    }
}
