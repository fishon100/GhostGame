using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    #region 欄位
    [Header("移動速度"), Range(0, 20)]
    public float movespeed = 5f;

    //public float h;

    Vector2 movement;
    private Rigidbody2D rb;
    private Animator ani;

    public EventTrigger Eve ;


    //private SpriteRenderer spr;

    #endregion

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //動畫名稱 = 取得元件<動畫控制器>();
        ani = GetComponent<Animator>();
        //圖片名稱 = 取得元件<圖片控制>()
        //spr = GetComponent<SpriteRenderer>();

         Eve = GetComponent<EventTrigger>();

        

    }

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        ani.SetFloat("Horizontal", movement.x);
        ani.SetFloat("Vertical", movement.y);
        ani.SetFloat("Speed", movement.sqrMagnitude);

        
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movespeed * Time.fixedDeltaTime);
    }


    #region 方法
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Enter")
        {
            coll.gameObject.transform.GetComponent<Enter>().CangeScene();
            coll.gameObject.transform.GetComponent<Enter1>().CangeScene();
        }

        if (coll.gameObject.name == "櫃台")
        {
            
        }
    }

    





    #endregion
}
