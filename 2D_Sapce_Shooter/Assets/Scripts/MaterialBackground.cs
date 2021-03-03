using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialBackground : MonoBehaviour
{
    public float BGScrollingSpeed;

    Material material;
    Vector2 offset;

    private void Start()
    {
        material = GetComponent<Renderer>().material;
        offset = new Vector2(0f, BGScrollingSpeed);
    }

    private void Update()
    {
    }
}
