using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleRotation : MonoBehaviour
{
    private float spinSpeed = 5f;
    private float scaleSpeed = 0.1f;
    private float maxScale = 1.5f;
    private float minScale = 1.0f;

    private bool isScalingUp = true;

    private void Start()
    {
        transform.Rotate(Vector2.up, spinSpeed * Time.deltaTime);

        if (isScalingUp)
        {
            transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime; 
            if (transform.localScale.x > maxScale)
            {
                isScalingUp = false;
            }
        }
        else
        {
            transform.localScale -= Vector3.one * scaleSpeed * Time.deltaTime;
            if (transform .localScale.x < minScale)
            {
                isScalingUp = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
