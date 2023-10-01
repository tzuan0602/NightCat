using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GirlsTask : MonoBehaviour //±±®ÓUI≈„•‹©M¡Ù¬√
{
    public GameObject ChatBox;
    public GameObject ChatIconBtn;
    // Start is called before the first frame update
    void Start()
    {
        ChatBoxClose(ChatBox); //ChatBox¡Ù¬√
        ChatIconClose(ChatIconBtn); //ChatButton¡Ù¬√
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //´ˆ∑∆π´•™¡‰√ˆ≥¨ChatBox
        {
            ChatBoxClose(ChatBox);
        }
    }

    public void ChatBoxClose(GameObject obj)
    {
        obj.GetComponent<CanvasGroup>().alpha = 0;
        obj.GetComponent<CanvasGroup>().interactable = false;
        obj.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void ChatBoxOpen(GameObject obj)
    {
        obj.GetComponent<CanvasGroup>().alpha = 1;
        obj.GetComponent<CanvasGroup>().interactable = true;
        obj.GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

    public void ChatIconClose(GameObject obj)
    {
        obj.GetComponent<CanvasGroup>().alpha = 0;
        obj.GetComponent<CanvasGroup>().interactable = false;
        obj.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void ChatIconOpen(GameObject obj)
    {
        obj.GetComponent<CanvasGroup>().alpha = 1;
        obj.GetComponent<CanvasGroup>().interactable = true;
        obj.GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
