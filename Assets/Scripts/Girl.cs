using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Girl : GirlsTask //�M�Φb�֤k����W�Ω󰻴�
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other) //���a�i�J�����d������ChatButton
    {
        GameObject.FindWithTag("Player");
        Debug.Log("�����쪱�a");
        ChatIconOpen(ChatIconBtn);
    }

    private void OnTriggerExit(Collider other) //���a���������d�������ChatButton
    {
        Debug.Log("���a�w����");
        ChatIconClose(ChatIconBtn);
        ChatBoxClose(ChatBox);
    }
}
