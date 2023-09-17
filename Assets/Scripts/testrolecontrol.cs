using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testrolecontrol : MonoBehaviour
{
    public float moveSpeed = 5f; // 移动速度

    private void Update()
    {
        HandleKeyboardInput();
    }

    private void HandleKeyboardInput()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized * moveSpeed * Time.deltaTime;

        // 应用移动
        transform.Translate(moveDirection);
    }
}
