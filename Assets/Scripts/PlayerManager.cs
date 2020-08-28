using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] GameObject sword = null;
    //Vector3 mouseLastPos;
    //float RotationSensitivity = 150.0f;
    //float minAngleX = -70.0f;
    //float maxAngleX = 70.0f;
    //float minAngleY = -45.0f;
    //float maxAngleY = 45.0f;
    //float yRotate,xRotate;
    void Start()
    {
        //yRotate = 0.0f;
        //xRotate = 0.0f;
        //mouseLastPos = Input.mousePosition;
    }
    void Update()
    {

        //yRotate += Input.GetAxis("Mouse X") * RotationSensitivity * Time.deltaTime;
        //yRotate = Mathf.Clamp(yRotate, minAngleX, maxAngleX);
        //xRotate += Input.GetAxis("Mouse Y") * RotationSensitivity * Time.deltaTime;
        //xRotate = Mathf.Clamp(xRotate, minAngleY, maxAngleY);
        //transform.eulerAngles = new Vector3(0.0f, yRotate, xRotate);
        sword.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1.5f));
    }
}
