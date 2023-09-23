using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleControlKB : MonoBehaviour
{
    public float MoveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
        {
            this.gameObject.transform.Translate(Vector3.forward * Time.deltaTime * MoveSpeed);
        }

        if (Input.GetKey(KeyCode.S)) 
        {
            this.gameObject.transform.Translate(Vector3.back * Time.deltaTime * MoveSpeed);
        }

        if (Input.GetKey(KeyCode.A)) 
        {
            this.gameObject.transform.Translate(Vector3.left * Time.deltaTime * MoveSpeed);
        }

        if (Input.GetKey(KeyCode.D)) 
        {
            this.gameObject.transform.Translate(Vector3.right * Time.deltaTime * MoveSpeed);
        }

        /*if (Input.GetKeyDown(KeyCode.W)) 
        {
            this.gameObject.transform.Translate(0, 0, 10);
        }

        if (Input.GetKeyDown(KeyCode.S)) 
        {
            this.gameObject.transform.Translate(0, 0, -10);
        }

        if (Input.GetKeyDown(KeyCode.A)) 
        {
            this.gameObject.transform.Translate(-10, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.D)) 
        {
            this.gameObject.transform.Translate(10, 0, 0);
        }*/
    }
}
