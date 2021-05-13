using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    //�ּҽð�
    [SerializeField]
    float minTime = 1;

    //�ִ�ð�
    [SerializeField]
    float maxTime = 5;

    //����ð�
    float currentTime = 0;

    //�����ð�
    [SerializeField]
    float appearTime = 1;

    //�� ����
    [SerializeField]
    GameObject enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //�ð��� �帥��
        currentTime += Time.deltaTime;

        //������ �ð��� �Ǹ�
        if (currentTime>appearTime )
        {
            //���� ����
            GameObject enemy = Instantiate(enemyPrefab);

            //��ġ�� ���´�
            enemy.transform.position = transform.position;

            //�ð��� 0���� �ʱ�ȭ
            currentTime = 0;

            //���� ���� �� �� ���� �ð� �ٽ� ����
            appearTime = Random.Range(minTime, maxTime);

        }

    }

 
}
