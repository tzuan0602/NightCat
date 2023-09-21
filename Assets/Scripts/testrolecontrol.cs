using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRoleControl : MonoBehaviour
{
    public float MoveSpeed = 50f; // 移动速度

    private void Update()
    {
        HandleKeyboardInput();
    }

    private void HandleKeyboardInput()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized * MoveSpeed * Time.deltaTime;

        // 应用移动
        transform.Translate(moveDirection);
    }
}