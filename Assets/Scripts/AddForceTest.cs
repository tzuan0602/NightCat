using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceTest : MonoBehaviour
{
    int a; //X初始位置
    int b; //X最後位置
    int c; //Y初始位置
    int d; //Y最後位置

    public float gridSizeHorizontal = 1.0f; // 左右方向的格子大小
    public float gridSizeVertical = 1.0f; // 前後方向的格子大小
    public float moveSpeed = 10.0f; // 移動速度

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        FrontAndBack();
    }

    void FrontAndBack()
    {
        float MouseY1 = (int)Input.mousePosition.y;
        float MouseY2 = (int)Input.mousePosition.y;
        if (Input.GetMouseButtonDown(0)) //觸碰螢幕時的座標
        {
            c = (int)MouseY1;
            Debug.Log(c);
        }

        if (Input.GetMouseButtonUp(0)) //手指離開螢幕時的座標
        {
            d = (int)MouseY2;
            Debug.Log(d);

            if (d - c > 0 && b - a < Mathf.Abs(300))
            {
                rb.velocity = Vector3.forward * 10;
                Debug.Log("向前移動");
            }
            if (d - c < 0 && b - a < Mathf.Abs(300))
            {
                rb.velocity = Vector3.back * 10;
                Debug.Log("向後移動");
            }
            else if (d - c == 0)
            {
                Debug.Log("沒有移動");
            }
        }
    }

    void RightAndLeft()
    {
        float MouseX1 = (int)Input.mousePosition.x;
        float MouseX2 = (int)Input.mousePosition.x;
        if (Input.GetMouseButtonDown(0)) //觸碰螢幕時的座標
        {
            a = (int)MouseX1;
            Debug.Log(a);
        }

        if (Input.GetMouseButtonUp(0)) //手指離開螢幕時的座標
        {
            b = (int)MouseX2;
            Debug.Log(b);

            if (b - a < 0 && d - c < Mathf.Abs(300))
            {
                rb.velocity = Vector3.left * 10;
                Debug.Log("向左移動");
            }
            if (b - a > 0 && d - c < Mathf.Abs(300))
            {
                rb.velocity = Vector3.right * 10;
                Debug.Log("向右移動");
            }
            else if (b - a == 0)
            {
                Debug.Log("沒有移動");
            }
        }
    }
}
