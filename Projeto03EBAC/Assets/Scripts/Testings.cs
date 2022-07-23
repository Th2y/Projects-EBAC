using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testings : MonoBehaviour
{
    public int value = 1;
    public string studentName = "Thayane";
    public string course = "Unity: do Zero ao Pro";

    void Update()
    {
        ChooseInput();
    }

    private void ChooseInput()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            value = 2;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            value = 1;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log(course);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log(studentName);
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("Student = " +studentName + "; Course = " + course + "; Value = " + value);
        }
    }
}
