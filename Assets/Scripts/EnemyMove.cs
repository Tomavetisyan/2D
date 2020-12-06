using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class EnemyMove : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    [SerializeField]
    public Sprite sideSprite;
    [SerializeField]
    public Sprite backSprite;
    [SerializeField]
    public Sprite frontSprite;

    public int movespeedX = 1;
    public int movespeedY = 1;
    public float travelTime = 1;
    private float timeSinceChange;
    void Start(){
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        patrol();
    }
    void patrol(){
        timeSinceChange += Time.deltaTime;
        if(timeSinceChange<=travelTime/2){
            Move(movespeedX, movespeedY);
        }else if(timeSinceChange>=travelTime/2 && timeSinceChange <=travelTime){
            Move(-movespeedX, -movespeedY);
        }else if(timeSinceChange > travelTime){
            timeSinceChange = 0;
        }      
    }
    void Move(int movespeedX, int movespeedY){
        changeSprite(movespeedX,movespeedY);
        rb.velocity = new Vector2(movespeedX,movespeedY); 
    }
    void changeSprite(int movespeedX, int movespeedY){
        if(Math.Abs(movespeedX)>Math.Abs(movespeedY)){
            if(movespeedX>0){
                spriteRenderer.sprite = sideSprite;
                spriteRenderer.flipX = false;
            }else{
                spriteRenderer.sprite = sideSprite;
                spriteRenderer.flipX = true;
            }
        }else{
            if(movespeedY>0){
                spriteRenderer.sprite = backSprite;
            }else{
                spriteRenderer.sprite = frontSprite;
            }
        }
    }
}


