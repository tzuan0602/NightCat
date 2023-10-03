using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoleControlMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float MouseX = (int)Input.mousePosition.x;
        float MouseY = (int)Input.mousePosition.y;
        Debug.Log(MouseX + "," + MouseY); //°»´ú·Æ¹«¦ì¸m

        if (Input.GetMouseButton(0))
        {
            Debug.Log("«ö¦í¥ªÁä");
        }
    }
}
