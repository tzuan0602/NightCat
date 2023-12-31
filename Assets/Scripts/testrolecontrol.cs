﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRoleControl : MonoBehaviour
{
    public float movementSpeed = 5f;

    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput).normalized;

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
        if (Physics.Raycast(transform.position, movementDirection, out hit, distanceToTarget))
        {
            // 碰到障礙物，停止移動
            Debug.Log("碰到障礙物");
        }
        else
        {
            // 沒有碰到障礙物，繼續移動
            transform.Translate(movementDirection * movementSpeed * Time.deltaTime, Space.World);
        }
    }
}