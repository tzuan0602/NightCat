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

    private void OnTriggerStay(Collider other) //NPC偵測玩家是否在範圍內並觸發ChatBox
    {
        GameObject.FindWithTag("Player");
        Debug.Log("偵測到玩家");

        if (Input.GetKeyDown(KeyCode.T))
        {
            ChatBoxOpen(ChatBox); //ChatBox顯示
        }
    }
}
