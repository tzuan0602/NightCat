using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class RoleControlMouse : MonoBehaviour
{
    int a; //X��l��m
    int b; //X�̫��m
    int c; //Y��l��m
    int d; //Y�̫��m
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
        Debug.Log(MouseX + "," + MouseY) //�����ƹ���m
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
        if (Input.GetMouseButtonDown(0)) //Ĳ�I�ù��ɪ��y��
        {
            c = (int)MouseY1;
            Debug.Log(c);
        }

        if (Input.GetMouseButtonUp(0)) //������}�ù��ɪ��y��
        {
            d = (int)MouseY2;
            Debug.Log(d);

            if (d - c > 0 && b - a < 300 && b - a > -300)
            {
                this.gameObject.transform.Translate(0, 0.5f, 1);
                Debug.Log("�V�e����");
            }
            if (d - c < 0 && b - a < 300 && b - a > -300)
            {
                this.gameObject.transform.Translate(0, 0.5f, -1);
                Debug.Log("�V�Ჾ��");
            }
            else if (d - c == 0)
            {
                Debug.Log("�S������");
            }
        }
    }

    void RightAndLeft()
    {
        float MouseX1 = (int)Input.mousePosition.x;
        float MouseX2 = (int)Input.mousePosition.x;
        if (Input.GetMouseButtonDown(0)) //Ĳ�I�ù��ɪ��y��
        {
            a = (int)MouseX1;
            Debug.Log(a);
        }

        if (Input.GetMouseButtonUp(0)) //������}�ù��ɪ��y��
        {
            b = (int)MouseX2;
            Debug.Log(b);

            if (b - a > 0 && d - c < 300 && d - c > -300)
            {
                this.gameObject.transform.Translate(1, 0.5f, 0);
                Debug.Log("�V�k����");
            }
            if (b - a < 0 && d - c < 300 && d - c > -300)
            {
                this.gameObject.transform.Translate(-1, 0.5f, 0);
                Debug.Log("�V������");
            }
            else if (b - a == 0)
            {
                Debug.Log("�S������");
            }
        }
    }
}
