using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{

    //public int life = 3;
    //public GameObject bullet;
    public Transform foot;
    bool groundCheck;
    public float speed = 2, jumpStrength = 5;  
    float Horizontal;
    public Rigidbody2D body;
    int direction = 1;
    private Animator anim;
    // Start is called before the first frame update
    void Start()

    {

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        Horizontal = Input.GetAxisRaw("Horizontal");
        body.velocity = new Vector2(Horizontal * speed, body.velocity.y);
        groundCheck = Physics2D.OverlapCircle(foot.position, 0.05f);



        if (Input.GetButtonDown("Jump") && groundCheck)
        {
            anim.SetInteger("Transition", 1);
            body.AddForce(new Vector2(0, jumpStrength * 100));
        }
        if (Horizontal != 0)
        {
            direction = (int)Horizontal;

        }
       /* if (Input.GetButton("Fire1"))
        {

            GameObject temp = Instantiate(bullet, transform.position, transform.rotation);
            temp.GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed * direction, 0);
        }*/
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       // if (collision.gameObject.CompareTag("enemy"))
        {
            //life--;
            //life-= 1;
            //life = life -1;
            //life -= collision.gameObject.GetComponent<Enemy>().damage;
            //if (life < 0)
           // {
               // Destroy(gameObject);

           // }
        }


    }
}




    



