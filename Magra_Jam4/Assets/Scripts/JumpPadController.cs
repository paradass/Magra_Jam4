using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPadController : MonoBehaviour
{
    [SerializeField] private bool blok;
    [SerializeField] private string animationName;
    Animator animator;
    void Start()
    {
        animator = transform.GetChild(0).GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            if (blok)
            {
                animator.Play(animationName);
                collision.gameObject.transform.position = transform.position;
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * 300);
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.right * 300);
            }
            else
            {
                animator.Play("jumpad normal");
                collision.gameObject.transform.position = transform.position;
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * 300);
            }
        }
    }
}
