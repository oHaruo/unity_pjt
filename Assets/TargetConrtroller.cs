using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public float minXPosition = -5.0f; // 왼쪽 끝
    public float maxXPosition = 5.0f;   // 오른쪽 끝
    public float minYPosition = 0.0f;     // 아래쪽 끝
    public float maxYPosition = 8.0f;    // 위쪽 끝

    public float changePositionInterval = 2.0f; // 위치 변경 간격
    private float timeSinceLastChange = 0f;

    private void ChangePosition()
    {
        // 과녁의 초기 위치를 랜덤하게 설정
        float randomX = UnityEngine.Random.Range(minXPosition, maxXPosition);
        float randomY = Random.Range(minYPosition, maxYPosition);
        Vector3 randomPosition = new Vector3(randomX, randomY, transform.position.z);

        // 설정한 랜덤 위치로 과녁 이동
        transform.position = randomPosition;
    }

    void Start()
    {
        // 처음 랜덤 위치로 이동
        ChangePosition();
    }

    void Update()
    {
        // 일정 시간이 지나면 위치 변경
        timeSinceLastChange += Time.deltaTime;
        if (timeSinceLastChange >= changePositionInterval)
        {
            ChangePosition();
            timeSinceLastChange = 0f; // 시간을 초기화
        }
    }
}