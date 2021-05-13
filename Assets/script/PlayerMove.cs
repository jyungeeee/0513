using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float speed = 7;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        float h = Input.GetAxis("Horizontal"); //GetAxis = -1 ~ 1
        float v = Input.GetAxis("Vertical");

        //방향
        Vector3 dir = Vector3.right * h + Vector3.up * v;
        
        //이동
        transform.Translate(dir * speed * Time.deltaTime);



    }

 

}
