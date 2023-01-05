using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchAndDrag : MonoBehaviour
{
    public float rotateSpeed;
    private bool isDragging; //bi?n dùng ?? ki?m tra có ?ang ch?m không
    private Vector2 touchPosittion;// tr? v? v? trí ch?m
    private Rigidbody2D rb;// bi?n xác ??nh có ?ang kéo v?t th? không
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            //touchPosition ???c gán giá tr? c?a v? trí ???c ch?m trên màn hình
            touchPosittion = Camera.main.ScreenToWorldPoint(touch.position);

            if(touch.phase == TouchPhase.Began)
            {
                //ch?m vào trong ph?m vi c?a collider
                if(GetComponent<Collider2D>().OverlapPoint(touchPosittion))
                {
                    isDragging = true;
                }
            }
            if(touch.phase == TouchPhase.Ended)
            {
                isDragging=false;
            }
        }

        
        if (isDragging)
        {
            rb.velocity = Vector2.zero;
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(transform.position.x, transform.position.y);
        }
        if (!isDragging)
        {
            transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
        }

    }
}
