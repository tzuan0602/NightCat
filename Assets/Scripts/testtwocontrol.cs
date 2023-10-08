using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class testtwocontrol : MonoBehaviour
{
    public float movementSpeed = 5f;
    public string obstacleTag = "Obstacle";  // ��אּ�A����ê��Tag

    private bool canMove = true;

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float horizontalInput = 0f;
        float verticalInput = 0f;

        // �P�_����O�_�Q���U
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

        // �p�Ⲿ�ʤ�V
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // �P�_�O�_�����ʿ�J
        if (movement.magnitude >= 0.1f)
        {
            // �p��ؼЦ�m
            Vector3 targetPosition = transform.position + movement * movementSpeed * Time.deltaTime;

            // �p�G�i�H���ʡA�B���I���ê���A�h����
            if (canMove && !IsObstacleInPath(targetPosition))
            {
                // ���ʨ���
                transform.position = targetPosition;
            }
            else
            {
                // �I���ê���A�����
                canMove = false;
            }
        }
        else if (movement.magnitude < 0.1f)
        {
            // ���������ɡA�]�w canMove �� true�A�H�K�b�U�@�����U��V����~�򲾰�
            canMove = true;
        }
    }

    bool IsObstacleInPath(Vector3 targetPosition)
    {
        // �b�ؼЦ�m�o�g�g�u�A�˴��O�_����ê��
        RaycastHit hit;
        if (Physics.Raycast(transform.position, targetPosition - transform.position, out hit, Vector3.Distance(transform.position, targetPosition)))
        {
            // �I���ê���A�p�G�O���wTag������A��^ true
            return hit.collider.CompareTag(obstacleTag);
        }

        // �S���I���ê��
        return false;
    }
}
