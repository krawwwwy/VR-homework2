using UnityEngine;
using UnityEngine.UI;

public class MoveObject1 : MonoBehaviour
{
    public float speed = 5f;
    public int score = 100; // ���������� ��� �������� ��������
    public Text scoreText; // ������ �� ��������� ������

    void Start()
    {
        UpdateScoreText(); // �������� ����� ��� ���������� ������ ��� ������
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
 
        if (other.CompareTag("Enemy")) // ���������, �������� �� ������ � ������� ����������� "������������"
        {
            score--; // ��������� ������� ��� ������������
            UpdateScoreText(); // �������� ����� ��� ���������� ������ ��������
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString(); // ��������� ����� ��������
    }
}
