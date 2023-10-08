using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class RoleControlMouse : MonoBehaviour
{
    int a; //X初始位置
    int b; //X最後位置
    int c; //Y初始位置
    int d; //Y最後位置
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*
        MouseX = (int)Input.mousePosition.x;
        float MouseY = (int)Input.mousePosition.y;
        Debug.Log(MouseX + "," + MouseY) //偵測滑鼠位置
        */

        FrontAndBack();
        RightAndLeft();
    }

    void LateUpdate()
    {
        
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

            if (d - c > 0 && b - a < 300 && b - a > -300)
            {
                this.gameObject.transform.Translate(0, 0.5f, 1);
                Debug.Log("向前移動");
            }
            if (d - c < 0 && b - a < 300 && b - a > -300)
            {
                this.gameObject.transform.Translate(0, 0.5f, -1);
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

            if (b - a > 0 && d - c < 300 && d - c > -300)
            {
                this.gameObject.transform.Translate(1, 0.5f, 0);
                Debug.Log("向右移動");
            }
            if (b - a < 0 && d - c < 300 && d - c > -300)
            {
                this.gameObject.transform.Translate(-1, 0.5f, 0);
                Debug.Log("向左移動");
            }
            else if (b - a == 0)
            {
                Debug.Log("沒有移動");
            }
        }
    }
}
