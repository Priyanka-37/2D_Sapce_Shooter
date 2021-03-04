using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Animation : MonoBehaviour
{
    public float bgScroolingSpeed = 5;
    Material material;
    Vector2 offset;

    private void Start()
    {
        material = GetComponent<Renderer>().material;
        offset = new Vector2(0.0f, bgScroolingSpeed);
    }

    private void Update()
    {
        material.mainTextureOffset += offset * Time.deltaTime;
    }
}
