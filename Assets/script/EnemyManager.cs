using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    //최소시간
    [SerializeField]
    float minTime = 1;

    //최대시간
    [SerializeField]
    float maxTime = 5;

    //현재시간
    float currentTime = 0;

    //일정시간
    [SerializeField]
    float appearTime = 1;

    //적 프립
    [SerializeField]
    GameObject enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //시간이 흐른다
        currentTime += Time.deltaTime;

        //일정한 시간이 되면
        if (currentTime>appearTime )
        {
            //적을 생성
            GameObject enemy = Instantiate(enemyPrefab);

            //위치로 놓는다
            enemy.transform.position = transform.position;

            //시간을 0으로 초기화
            currentTime = 0;

            //적이 생성 후 적 생성 시간 다시 설정
            appearTime = Random.Range(minTime, maxTime);

        }

    }

 
}
