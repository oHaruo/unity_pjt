using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public float minXPosition = -5.0f; // ���� ��
    public float maxXPosition = 5.0f;   // ������ ��
    public float minYPosition = 0.0f;     // �Ʒ��� ��
    public float maxYPosition = 8.0f;    // ���� ��

    public float changePositionInterval = 2.0f; // ��ġ ���� ����
    private float timeSinceLastChange = 0f;

    private void ChangePosition()
    {
        // ������ �ʱ� ��ġ�� �����ϰ� ����
        float randomX = UnityEngine.Random.Range(minXPosition, maxXPosition);
        float randomY = Random.Range(minYPosition, maxYPosition);
        Vector3 randomPosition = new Vector3(randomX, randomY, transform.position.z);

        // ������ ���� ��ġ�� ���� �̵�
        transform.position = randomPosition;
    }

    void Start()
    {
        // ó�� ���� ��ġ�� �̵�
        ChangePosition();
    }

    void Update()
    {
        // ���� �ð��� ������ ��ġ ����
        timeSinceLastChange += Time.deltaTime;
        if (timeSinceLastChange >= changePositionInterval)
        {
            ChangePosition();
            timeSinceLastChange = 0f; // �ð��� �ʱ�ȭ
        }
    }
}