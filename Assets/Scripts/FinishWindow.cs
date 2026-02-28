using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishWindow : MonoBehaviour
{
    private int currentScore = 10;

    [SerializeField] private TMP_Text scoreText; // Текст для отображения счета
    [SerializeField] private GameObject finishPanel; // Панель победы

    private void Start()
    {
        scoreText.text = currentScore.ToString();
        finishPanel.SetActive(false);
    }

    public void UpdateScoreText(int currentScore) 
    {
        scoreText.text = currentScore.ToString();
    }

    public void FinishGame() 
    {
        finishPanel.SetActive(true);
        //Time.timeScale = 0;

        //StartCoroutine(StartScene());
    }

    IEnumerator StartScene() 
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("SampleScene");
    }
}
