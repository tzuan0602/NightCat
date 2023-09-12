using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleControl : MonoBehaviour
{
    public float moveSpeed = 5f; // 控制角色移動速度

    private void Update()
    {
        HandleTouchInput();
    }

    private void HandleTouchInput()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    // 在此處理觸摸開始的操作
                    break;

                case TouchPhase.Moved:
                    // 在此處理觸摸移動的操作
                    Vector2 touchDeltaPosition = touch.deltaPosition;
                    Vector3 movement = new Vector3(touchDeltaPosition.x, 0f, touchDeltaPosition.y) * moveSpeed * Time.deltaTime;
                    transform.Translate(movement);
                    break;

                case TouchPhase.Ended:
                    // 在此處理觸摸結束的操作
                    break;
            }
        }
    }
}
