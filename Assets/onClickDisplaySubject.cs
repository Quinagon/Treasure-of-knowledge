using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onClickDisplaySubject : MonoBehaviour
{
    public Text section,subjectName; 
    // Start is called before the first frame update
    void Start()
    {

        section.text = dBManager.className +" "+ dBManager.section;
        subjectName.text = dBManager.subject;

        Debug.Log("Classroom Data: " + section.text);
        Debug.Log("Classroom Data: " + subjectName.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
