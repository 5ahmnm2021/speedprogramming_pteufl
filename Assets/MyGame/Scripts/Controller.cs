using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public Text boolText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("Szene2");
    }

    public void RightAnswer()
    {
        boolText.text = "That's right!";
        boolText.color = Color.green;
    }

    public void WrongAnswer()
    {
        boolText.text = "That's wrong!";
        boolText.color = Color.red;
    }
}
