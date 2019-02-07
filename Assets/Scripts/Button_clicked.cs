using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button_clicked : MonoBehaviour
{
    public string eEvel;

    public Button m_YourFirstButton;
    // Start is called before the first frame update
    void Start()
    {
        m_YourFirstButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("Timer", LoadSceneMode.Single);
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
