using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridmove : MonoBehaviour
{
    public float gridSizeHorizontal = 1.0f; // ���k��V����l�j�p
    public float gridSizeVertical = 1.0f;   // �e���V����l�j�p
    public float moveSpeed = 5.0f;           // ���ʳt��

    void Update()
    {
        // ���������J
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
        // �p��ؼЦ�m
        Vector3 targetPosition = transform.position + direction * gridSize;

        // ���ʦV�ؼЦ�m
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
