using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{

    public Text displaySubject, displayTeacher;
    // Start is called before the first frame update
    void Start()
    {
        displaySubject.text = dBManager.subject;
        displayTeacher.text = dBManager.teacher;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
