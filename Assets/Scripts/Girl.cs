using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl : GirlsTask
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other) //NPC�������a�O�_�b�d�򤺨�Ĳ�oChatBox
    {
        GameObject.FindWithTag("Player");
        Debug.Log("�����쪱�a");

        if (Input.GetKeyDown(KeyCode.T))
        {
            ChatBoxOpen(ChatBox); //ChatBox���
        }
    }
}
