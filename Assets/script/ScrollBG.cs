using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBG : MonoBehaviour
{
    public Material material;

    float speed = 0.5f; //움직이는 속도

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() //배경 위로 움직이기
    {
        Vector2 dir = Vector2.up;
        material.mainTextureOffset += dir * speed * Time.deltaTime;
    }
}
