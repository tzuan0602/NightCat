using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour //按鈕控制
{
    public GameObject ChatBox;
    public Text TaskContent;
    // Start is called before the first frame update
    void Start()
    {
        TaskContent.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChatBoxOpen(GameObject obj)
    {
        obj.GetComponent<CanvasGroup>().alpha = 1;
        obj.GetComponent<CanvasGroup>().interactable = true;
        obj.GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

    public void TaskShow()
    {
        TaskContent.text = "解決怪物\r\n0/1";
    }
}
