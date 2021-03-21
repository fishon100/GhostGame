using UnityEngine;

public class Player : MonoBehaviour
{
    #region 欄位
    [Header("移動速度"), Range(0, 1000)]
    public float speed;

    public float h;
    private Rigidbody2D rig;
    private Animator ani;
    private SpriteRenderer spr;

    #endregion

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        //動畫名稱 = 取得元件<動畫控制器>();
        ani = GetComponent<Animator>();
        //圖片名稱 = 取得元件<圖片控制>()
        spr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Move();
       
    }


    #region 方法

    
     



    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
     
        float v = Input.GetAxis("Vertical"); 
        float h = Input.GetAxis("Horizontal");
       
        rig.MovePosition(transform.position + transform.up * v * speed * Time.deltaTime + transform.right * h * speed * Time.deltaTime);

        
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            print("按下D");

            
            transform.localEulerAngles = Vector3.zero;
        }

        
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print("按下A");

            
            //transform.localEulerAngles = new Vector3(0, 180, 0);
        }

       
        //動畫.取得設置布林值("動畫參數名稱" ，水平值 != 0)
        ani.SetBool("開始往側走", h != 0);    //H 不為右1 也不為左-1 = 0
    }





        #endregion
    }
