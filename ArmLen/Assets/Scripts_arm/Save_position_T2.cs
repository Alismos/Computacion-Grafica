using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Save_position_T2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        string fileName = "D:/Alismos/Documentos/Unity/BodyArm/ArmLen/Assets/Sensor2.csv";
        float dx = transform.localRotation.eulerAngles.x;
        float dy = transform.localRotation.eulerAngles.y;
        float dz = transform.localRotation.eulerAngles.z;

        using (StreamWriter writer = new StreamWriter(fileName, true))
        {
            writer.Write(transform.localPosition.x + ";" + transform.localPosition.y + ";" + transform.localPosition.z + ";" + dx + ";" + dy + ";" + dz + "\n");
        }

    }

    
}
