using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterLivin : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        this.transform.tag = "Enter";
    }
    public void CangeScene2()
    {
        SceneManager.LoadScene("大廳");
    }


}
