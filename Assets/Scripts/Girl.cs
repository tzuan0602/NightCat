using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Girl : GirlsTask //套用在少女物件上用於偵測
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other) //玩家進入偵測範圍並顯示ChatButton
    {
        GameObject.FindWithTag("Player");
        Debug.Log("偵測到玩家");
        ChatIconOpen(ChatIconBtn);
    }

    private void OnTriggerExit(Collider other) //玩家遠離偵測範圍並隱藏ChatButton
    {
        Debug.Log("玩家已遠離");
        ChatIconClose(ChatIconBtn);
        ChatBoxClose(ChatBox);
    }
}
