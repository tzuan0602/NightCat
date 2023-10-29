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

    public float gridSizeHorizontal = 1.0f; // ���k��V����l�j�p
    public float gridSizeVertical = 1.0f; // �e���V����l�j�p
    public float moveSpeed = 10.0f; // ���ʳt��

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
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

            if (d - c > 0)
            {
                rb.velocity = Vector3.forward * 100;
                //this.gameObject.transform.Translate(Vector3.forward * gridSizeVertical);
                //Move(Vector3.forward, gridSizeVertical);
                Debug.Log("�V�e����");
            }
            if (d - c < 0)
            {
                rb.velocity = Vector3.back * 100;
                //this.gameObject.transform.Translate(Vector3.back * gridSizeVertical);
                //Move(Vector3.back, gridSizeVertical);
                Debug.Log("�V�Ჾ��");
            }
            else if (d - c == 0)
            {
                Debug.Log("�S������");
            }
        }
    }

    void RightAndLeft() //�קאּ�O��Ĳ�o��k?!
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

            if (b - a < 0)
            {
                rb.velocity = Vector3.left * 50;
                //this.gameObject.transform.Translate(Vector3.left * gridSizeHorizontal);
                //Move(Vector3.left, gridSizeHorizontal);
                Debug.Log("�V������");
            }
            if (b - a > 0)
            {
                rb.velocity = Vector3.right * 50;
                //this.gameObject.transform.Translate(Vector3.right * gridSizeHorizontal);
                //Move(Vector3.right, gridSizeHorizontal);
                Debug.Log("�V�k����");
            }
            else if (b - a == 0)
            {
                Debug.Log("�S������");
            }
        }
    }

    void Move(Vector3 direction, float gridSize)
    {
        // �p��ؼЦ�m
        Vector3 targetPosition = transform.position + direction * gridSize;

        // ���ʦV�ؼЦ�m
        StartCoroutine(MoveToPosition(targetPosition));
    }

    IEnumerator MoveToPosition(Vector3 targetPosition)
    {
        while (Vector3.Distance(transform.position, targetPosition) > 0.1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            yield return null;
        }
    }
}
