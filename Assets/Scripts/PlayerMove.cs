using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private SpriteRenderer SpriteRenderer;
    private Rigidbody2D RigidBody2D;

    [SerializeField]
    public Sprite sideSprite;
    [SerializeField]
    public Sprite backSprite;
    [SerializeField]
    public Sprite frontSprite;
    public int moveSpeed = 4;
    private Transform attackPoint;
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        RigidBody2D = GetComponent<Rigidbody2D>();
        attackPoint = transform.Find("attackPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("d")){
            moveRight();
        }else if(Input.GetKey("a")){
            moveLeft();
        }else{
            RigidBody2D.velocity = new Vector2(0, RigidBody2D.velocity.y);
        }
        if(Input.GetKey("w")){
            moveUp();
        }else if(Input.GetKey("s")){
            moveDown();
        }else{
            RigidBody2D.velocity = new Vector2(RigidBody2D.velocity.x,0);
        }
    }
    void moveRight(){
        attackPoint.localPosition = new Vector2(.15f,0);
        SpriteRenderer.sprite = sideSprite;
        SpriteRenderer.flipX = false;
        RigidBody2D.velocity = new Vector2(moveSpeed,RigidBody2D.velocity.y);
    }

    void moveLeft(){
        attackPoint.localPosition = new Vector2(-.15f,0);
        SpriteRenderer.sprite = sideSprite;
        SpriteRenderer.flipX = true;
        RigidBody2D.velocity = new Vector2(-moveSpeed,RigidBody2D.velocity.y);
    }

    void moveUp(){
        attackPoint.localPosition = new Vector2(0,.15f);
        SpriteRenderer.sprite = backSprite;
        RigidBody2D.velocity = new Vector2(RigidBody2D.velocity.x,moveSpeed);
    }

    void moveDown(){
        attackPoint.localPosition = new Vector2(0,-.15f);
        SpriteRenderer.sprite = frontSprite;
        RigidBody2D.velocity = new Vector2(RigidBody2D.velocity.x,-moveSpeed);
    }
}
