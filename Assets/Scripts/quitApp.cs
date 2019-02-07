using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class quitApp : MonoBehaviour
{

    public Button m_YourFirstButton;
    // Start is called before the first frame update
    void Start()
    {
        m_YourFirstButton.onClick.AddListener(TaskOnClick);

    }

    void TaskOnClick()
    {
        Application.Quit();
        Debug.Log("qiut");
    }



    // Update is called once per frame
    void Update()
    {

    }
}
