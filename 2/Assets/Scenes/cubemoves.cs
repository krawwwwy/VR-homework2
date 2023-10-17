using UnityEngine;
using UnityEngine.UI;

public class MoveObject1 : MonoBehaviour
{
    public float speed = 5f;
    public int score = 100; // Переменная для хранения счетчика
    public Text scoreText; // Ссылка на компонент текста

    void Start()
    {
        UpdateScoreText(); // Вызываем метод для обновления текста при старте
    }

    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;
        transform.Translate(movement);
    }
    void OnTriggerEnter(Collider other)
    {
 
        if (other.CompareTag("Enemy")) // Проверяем, является ли объект с которым столкнулись "препятствием"
        {
            score--; // Уменьшаем счетчик при столкновении
            UpdateScoreText(); // Вызываем метод для обновления текста счетчика
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString(); // Обновляем текст счетчика
    }
}
