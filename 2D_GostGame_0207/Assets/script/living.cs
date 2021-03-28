using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class living : MonoBehaviour
{
    [Header("可被觸碰的物體")]
    public Collider2D bu;
    public Collider2D pe;

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

            bu.enabled = true;
            pe.enabled = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        inPlayer = true;
        bu.enabled = true;
        pe.enabled = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        inPlayer = false;
        bu.enabled = false;
        pe.enabled = false;
    }
}
