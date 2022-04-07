using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MBoyMovement : MonoBehaviour
{

    Animator animBoy;
    Rigidbody2D rbBoy;
    public float fuerzaDeSalto;
    public bool enSuelo;
    public float velocidad;
    public bool isRun;
    void Start()
    {
        animBoy = GetComponent<Animator>();
        rbBoy = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
        Jump();
        Dead();
        Attack();
        Run();
    }


    public void Walk()
    {
        if (Input.GetKey(KeyCode.D))
        {
            animBoy.SetBool("isWalk", true);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }
        else
        {
            animBoy.SetBool("isWalk", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            animBoy.SetBool("isWalk", true);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }
       

    }

    public void Jump()
    {
        if (enSuelo)
        {
           
            if (Input.GetKeyDown(KeyCode.Space))
            {
               
                enSuelo = false;
                rbBoy.AddForce(Vector2.up * fuerzaDeSalto,ForceMode2D.Impulse);
            }
        }
       

       
    
        if(enSuelo)
        {
            animBoy.SetBool("isJump", false);
        }

        if (enSuelo==false)
        {
            animBoy.SetBool("isJump", true);
        }
    }

    public void Attack()
    {
        if(Input.GetMouseButtonDown(0))
        {
            animBoy.SetTrigger("isAttack");
        }
    }

    public void Dead()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            animBoy.SetTrigger("isDead");
        }
    }

    public void Run()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            isRun = true;
            velocidad = 8;
        }
        else
        {
            isRun = false;
            animBoy.SetBool("isRun", false);
        }

        if (isRun)
        {


            if (Input.GetKey(KeyCode.D))
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                animBoy.SetBool("isRun", true);
                animBoy.SetBool("isWalk", false);
                transform.Translate(Vector2.right * velocidad * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
                animBoy.SetBool("isRun", true);
                animBoy.SetBool("isWalk", false);

                transform.Translate(Vector2.right * velocidad * Time.deltaTime);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Floor"))
        {
            enSuelo = true;
        }
    }

   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DeadEmpty"))
        {
            SceneManager.LoadScene(4);
        }
    }
}
