using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour
{
    public Button testButton;
    public AudioSource audioSource;
    public AudioClip engineSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonPressed()
    {
        Debug.Log("Button Pressed!!!");
        testButton.GetComponentInChildren<Text>().text = "YES";
    }
}
