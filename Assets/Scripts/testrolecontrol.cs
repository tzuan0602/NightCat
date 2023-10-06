using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRoleControl : MonoBehaviour
{
    public float movementSpeed = 5f;
    public LayerMask obstacleLayer;

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
        Vector3 movementDirection = (targetPosition - transform.position).normalized;
        float distanceToTarget = Vector3.Distance(transform.position, targetPosition);

        RaycastHit hit;
        if (!Physics.Raycast(transform.position, movementDirection, out hit, distanceToTarget, obstacleLayer))
        {
            // 没有障礙物，移動
            transform.Translate(movementDirection * movementSpeed * Time.deltaTime, Space.World);
        }
        //需有圍欄才可
    }
}