using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceTest : MonoBehaviour
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
        /*if (Input.GetMouseButtonUp(0))
        {
            rb.velocity = Vector3.forward * 10;
        }*/

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

            if (d - c > 0 && b - a < Mathf.Abs(300))
            {
                //this.gameObject.transform.Translate(Vector3.forward * gridSizeVertical);
                rb.velocity = Vector3.forward * 10;
                //Move(Vector3.forward, gridSizeVertical);
                Debug.Log("�V�e����");
            }
            if (d - c < 0 && b - a < Mathf.Abs(300))
            {
                this.gameObject.transform.Translate(Vector3.back * gridSizeVertical);
                //Move(Vector3.back, gridSizeVertical);
                Debug.Log("�V�Ჾ��");
            }
            else if (d - c == 0)
            {
                Debug.Log("�S������");
            }
        }
    }
}
