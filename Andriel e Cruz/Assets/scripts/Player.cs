using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{

    public int life = 3;
    public GameObject bullet;
    public Transform foot;
    bool groundCheck;
    public int speed = 5, jumpStrength = 5, bulletSpeed = 8;
    float Horizontal;
    public Rigidbody2D body;
    int direction = 1;

    public int score;
    public TMP_Text texto;
    public string TMP_Text;
    [SerializeField] private Bullet bulletprefab;
    public GameManangerScript gameMananger;
    private bool isDead;

    float timerShoot;
    public float fireRate;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {

        Horizontal = Input.GetAxisRaw("Horizontal");
        body.velocity = new Vector2(Horizontal * speed, body.velocity.y);
        groundCheck = Physics2D.OverlapCircle(foot.position, 0.05f);



        if (Input.GetButtonDown("Jump") && groundCheck)
        {
            body.AddForce(new Vector2(0, jumpStrength * 100));
        }
        if (Horizontal != 0)
        {
            direction = (int)Horizontal;

        }

       if (Input.GetButton("Fire1"))
       {
            if(timerShoot > fireRate)
            {
            GameObject temp = Instantiate(bullet, transform.position, transform.rotation);
            temp.GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed * direction, 0);
            timerShoot = 0;
            }
       }else
        {
            timerShoot += Time.deltaTime;
        }
        UpdateScoreText();

        texto.text = "Pontos:" + score.ToString();

        Horizontal = Input.GetAxisRaw("Horizontal");

        body.velocity = new Vector2(Horizontal * speed, body.velocity.y);

        groundCheck = Physics2D.OverlapCircle(foot.position, 0.05f);
    }
    



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            life--;

            if (life <= 0 && !isDead)
            {
                isDead = true;
                gameMananger.GameOver();
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Aumenta"))
        {
            score += 1;
            Destroy(collision.gameObject);
            UpdateScoreText();
        }
        if (collision.gameObject.CompareTag("MorreVoid"))
        {
            isDead = true;
            gameMananger.GameOver();
            Destroy(gameObject);
        }

    }
    private void UpdateScoreText()
    {
    }
}




    



