using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    //현재 점수
    public int currentScore;
    public int bestScore;
  
    public Text currentScoreTxt;
    public Text bestScoreTxt;
    // Start is called before the first frame update

    private void Start()
    {
        bestScore = PlayerPrefs.GetInt("Best Score", 0);
        bestScoreTxt.text = "최고점수:" + bestScore;

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
        //scoremanager의 currentscore 증가
        currentScore++;

        //ui text에 currentScore 표시
        currentScoreTxt.text = "현재점수:" + currentScore;

        //최고점수 비교
        //만약 현재점수가 최고 점수보다 크다면
        if (currentScore > bestScore)
        {
            bestScore = currentScore;

            bestScoreTxt.text = "최고점수:" + bestScore;

            PlayerPrefs.SetInt("Best Score", bestScore);
        }    


    }
}
