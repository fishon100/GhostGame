using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enter : MonoBehaviour
{
    public SceneManager newScene;

    private void Awake()
    {
       
    }
    // Start is called before the first frame update
    void Start()
    {
        this.transform.tag = "Enter";
    }
    public void CangeScene()
    {
        SceneManager.LoadScene("");
       
    }


}
