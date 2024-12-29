using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed,jum;

    Rigidbody2D body;

    SpriteRenderer sprite;

    public bool isground;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)){
            body.linearVelocity  = new Vector2(speed,body.linearVelocity.y);
            sprite.flipX = false;

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            body.linearVelocity = new Vector2(-speed,body.linearVelocity.y);
            sprite.flipX = true;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow)){
           
            body.linearVelocity = new Vector2(0,body.linearVelocity.y);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && isground)
        {
            body.linearVelocity = new Vector2(body.linearVelocity.x, jum);
        }
    }
}
