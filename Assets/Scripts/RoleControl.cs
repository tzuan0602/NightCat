using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleControl : MonoBehaviour
{
    public float moveSpeed = 5f; // ����Ⲿ�ʳt��

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
                    // �b���B�zĲ�N�}�l���ާ@
                    break;

                case TouchPhase.Moved:
                    // �b���B�zĲ�N���ʪ��ާ@
                    Vector2 touchDeltaPosition = touch.deltaPosition;
                    Vector3 movement = new Vector3(touchDeltaPosition.x, 0f, touchDeltaPosition.y) * moveSpeed * Time.deltaTime;
                    transform.Translate(movement);
                    break;

                case TouchPhase.Ended:
                    // �b���B�zĲ�N�������ާ@
                    break;
            }
        }
    }
}
