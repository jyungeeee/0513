using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public AudioSource audioSource;
    

    [SerializeField]
    public float speed = 5; //미사일 속도

    // Start is called before the first frame update
    void Start()
    {

    }
 

    // Update is called once per frame
    void Update()
    {

        // 위로 이동
        transform.Translate(Vector3.up * 5 * Time.deltaTime);


    }
}
