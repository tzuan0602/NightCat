using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class testtwocontrol : MonoBehaviour
{
    public float movementSpeed = 5f;
    public string obstacleTag = "Obstacle";  // 更改為你的障礙物Tag

    private bool canMove = true;

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float horizontalInput = 0f;
        float verticalInput = 0f;

        // 判斷按鍵是否被按下
        if (Input.GetKey(KeyCode.W))
        {
            verticalInput = 1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            verticalInput = -1f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            horizontalInput = -1f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            horizontalInput = 1f;
        }

        // 計算移動方向
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // 判斷是否有移動輸入
        if (movement.magnitude >= 0.1f)
        {
            // 計算目標位置
            Vector3 targetPosition = transform.position + movement * movementSpeed * Time.deltaTime;

            // 如果可以移動，且未碰到障礙物，則移動
            if (canMove && !IsObstacleInPath(targetPosition))
            {
                // 移動角色
                transform.position = targetPosition;
            }
            else
            {
                // 碰到障礙物，停止移動
                canMove = false;
            }
        }
        else if (movement.magnitude < 0.1f)
        {
            // 當按鍵釋放時，設定 canMove 為 true，以便在下一次按下方向鍵時繼續移動
            canMove = true;
        }
    }

    bool IsObstacleInPath(Vector3 targetPosition)
    {
        // 在目標位置發射射線，檢測是否有障礙物
        RaycastHit hit;
        if (Physics.Raycast(transform.position, targetPosition - transform.position, out hit, Vector3.Distance(transform.position, targetPosition)))
        {
            // 碰到障礙物，如果是指定Tag的物體，返回 true
            return hit.collider.CompareTag(obstacleTag);
        }

        // 沒有碰到障礙物
        return false;
    }
}
