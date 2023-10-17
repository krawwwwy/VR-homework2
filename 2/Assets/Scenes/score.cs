using UnityEngine;
using UnityEngine.UI; 

public class ScoreManager : MonoBehaviour
{
    public int score = 100; 
    public Text scoreText; 

    void Start()
    {
        UpdateScoreText(); 
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected"); // Добавьте это сообщение для отладки
        if (collision.gameObject.CompareTag("Enemy"))
        {
            score--; 
            UpdateScoreText(); 
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString(); 
    }
}
