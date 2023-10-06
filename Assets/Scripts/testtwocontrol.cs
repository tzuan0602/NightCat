using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testtwocontrol : MonoBehaviour
{
    public float movementSpeed = 5f;
    public string obstacleTag = "Obstacle";

    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f).normalized;

        if (movement.magnitude >= 0.1f)
        {
            Vector3 targetPosition = transform.position + movement * movementSpeed * Time.deltaTime;
            MoveToTarget(targetPosition);
        }
    }

    private void MoveToTarget(Vector3 targetPosition)
    {
        Vector2 movementDirection = (targetPosition - transform.position).normalized;
        float distanceToTarget = Vector3.Distance(transform.position, targetPosition);

        RaycastHit2D hit = Physics2D.Raycast(transform.position, movementDirection, distanceToTarget);
        if (hit.collider != null && hit.collider.CompareTag(obstacleTag))
        {
            // 碰到障?物，停止移?
            Debug.Log("碰到障?物");
        }
        else
        {
            // ?有碰到障?物，??移?
            transform.Translate(movementDirection * movementSpeed * Time.deltaTime, Space.World);
        }
    }
}
