using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterRoad : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        this.transform.tag = "Enter";
    }
    public void CangeScene1()
    {
        SceneManager.LoadScene("大廳");
    }


}
