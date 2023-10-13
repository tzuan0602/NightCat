using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridmove : MonoBehaviour
{
    public float gridSizeHorizontal = 1.0f; // 左右方向的格子大小
    public float gridSizeVertical = 1.0f;   // 前後方向的格子大小
    public float moveSpeed = 5.0f;           // 移動速度

    void Update()
    {
        // 偵測按鍵輸入
        if (Input.GetKeyDown(KeyCode.W))
        {
            Move(Vector3.forward, gridSizeVertical);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Move(Vector3.back, gridSizeVertical);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            Move(Vector3.left, gridSizeHorizontal);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Move(Vector3.right, gridSizeHorizontal);
        }
    }

    void Move(Vector3 direction, float gridSize)
    {
        // 計算目標位置
        Vector3 targetPosition = transform.position + direction * gridSize;

        // 移動向目標位置
        StartCoroutine(MoveToPosition(targetPosition));
    }

    IEnumerator MoveToPosition(Vector3 targetPosition)
    {
        while (Vector3.Distance(transform.position, targetPosition) > 0.1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            yield return null;
        }
    }
}
