using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteBook : MonoBehaviour
{
    [Header("可被觸碰的物體")]
    public Collider2D no;
    
    bool inPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inPlayer)
        {

            no.enabled = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        inPlayer = true;
        no.enabled = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        inPlayer = false;
        no.enabled = false;
    }
}
