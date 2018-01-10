using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMovement : MonoBehaviour
{
    Animator animator;

    public GameObject Food;
    public int movementFlag;
    float restFlag;
    float moveSec, restSec;
    bool rest = false;
    public bool eat = false;
    bool eatreset = false;

    public Vector2 speed = new Vector2(3, 3);
    private Vector2 movement;
    private Vector2 foodpos;
    private Vector2 catpos;
    private Rigidbody2D rigidbodyComponent;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        StartCoroutine("ChangeMovement");
    }

    // Update is called once per frame
    private void Update()
    {
        if (Food.activeInHierarchy)
        {
            animator.SetBool("hungry", false);
            Eating();
        }
        else
        {
            if (gameObject.GetComponent<Cat>().hunger <= 30)
            {
                animator.SetBool("hungry", true);
                movement = new Vector2(0, 0);
                if (rigidbodyComponent == null)
                    rigidbodyComponent = GetComponent<Rigidbody2D>();
                rigidbodyComponent.velocity = movement;
                StopCoroutine("ChangeMovement");
            }
            else
            {
                Move();
                animator.SetBool("hungry", false);
            }
        }
    }
    void Eating()
    {
        if (eat)
        {
            if (!eatreset)
            {
                StartCoroutine("ResetEating");
                eatreset = true;
            }
            else
            {
                animator.SetBool("eating", eat);
                if(!IsInvoking("ChargeHungry"))
                    Invoke("ChargeHungry", 0.19f);
            }

        }
        else
        {
            foodpos = Food.transform.position;
            catpos = gameObject.transform.position;
            StopCoroutine("ChangeMovement");
            rest = false;
            if (foodpos.x - 0.05 > catpos.x)
            {
                if (foodpos.y + 0.95 > catpos.y)
                {
                    movement = new Vector2(0, 1);
                    movementFlag = 0;
                }
                else if (foodpos.y + 1.05 < catpos.y)
                {
                    movement = new Vector2(0, -1);
                    movementFlag = 2;
                }
                else
                {
                    movement = new Vector2(1, 0);
                    movementFlag = 1;
                }
            }
            else if (foodpos.x + 0.05 < catpos.x)
            {
                if (foodpos.y + 0.95 > catpos.y)
                {
                    movement = new Vector2(0, 1);
                    movementFlag = 0;
                }
                else if (foodpos.y + 1.05 < catpos.y)
                {
                    movementFlag = 2;
                    movement = new Vector2(0, -1);
                }
                else
                {
                    movementFlag = 3;
                    movement = new Vector2(-1, 0);
                }
            }
            else
            {
                movement = new Vector2(0, 0);
                eat = true;
            }

            animator.SetInteger("Condition", movementFlag);
            animator.SetBool("rest", rest);

            if (rigidbodyComponent == null)
                rigidbodyComponent = GetComponent<Rigidbody2D>();
            rigidbodyComponent.velocity = movement;
        }
    }
    void ChargeHungry()
    {
        gameObject.GetComponent<Cat>().plusMinusHunger(true);
    }
    IEnumerator ResetEating()
    {
        yield return new WaitForSeconds(2.0f);
        Food.SetActive(!Food.activeInHierarchy);
        eat = false;
        eatreset = false;
        animator.SetBool("eating", eat);
        StartCoroutine("ChangeMovement");
    }

    void Move()
    {
        switch (movementFlag)
        {
            case 0:
                movement = new Vector2(0, 1);
                break;
            case 1:
                if (rest != true)
                    movement = new Vector2(1, 0);
                else
                    movement = new Vector2(0, 0);
                break;
            case 2:
                movement = new Vector2(0, -1);
                break;
            case 3:
                if (rest != true)
                    movement = new Vector2(-1, 0);
                else
                    movement = new Vector2(0, 0);
                break;
        }
        if (rigidbodyComponent == null)
            rigidbodyComponent = GetComponent<Rigidbody2D>();
        rigidbodyComponent.velocity = movement;

    }

    void Restselect()
    {
        restFlag = Random.Range(0.0f, 2.0f);
        if (restFlag >= 1.0f)
        {
            rest = true;
        }
        else
        {
            rest = false;
        }
    }

    IEnumerator ChangeMovement()
    {
       
            movementFlag = Random.Range(0, 4);
        moveSec = Random.Range(2.0f, 4.0f);
        if (movementFlag == 1 || movementFlag == 3)
            Restselect();
        else
            rest = false;

        animator.SetBool("rest", rest);
        animator.SetInteger("Condition", movementFlag);

        yield return new WaitForSeconds(moveSec);
        StartCoroutine("ChangeMovement");
    }
}