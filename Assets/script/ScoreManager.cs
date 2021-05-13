using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    //���� ����
    public int currentScore;
    public int bestScore;
  
    public Text currentScoreTxt;
    public Text bestScoreTxt;
    // Start is called before the first frame update

    private void Start()
    {
        bestScore = PlayerPrefs.GetInt("Best Score", 0);
        bestScoreTxt.text = "�ְ�����:" + bestScore;

    }
    private void Update()
    {
        
    }
    public int GetScore()
    {
        return currentScore;

    }

    public void SetScore(int value)
    {
        //scoremanager�� currentscore ����
        currentScore++;

        //ui text�� currentScore ǥ��
        currentScoreTxt.text = "��������:" + currentScore;

        //�ְ����� ��
        //���� ���������� �ְ� �������� ũ�ٸ�
        if (currentScore > bestScore)
        {
            bestScore = currentScore;

            bestScoreTxt.text = "�ְ�����:" + bestScore;

            PlayerPrefs.SetInt("Best Score", bestScore);
        }    


    }
}
