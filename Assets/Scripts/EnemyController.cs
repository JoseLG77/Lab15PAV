using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Animator animator;
    public GameManager GameManager;

    void Start()
    {
        animator = GetComponent<Animator>(); 
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "bullet") 
        {
            Destroy(col.gameObject); 
            animator.SetTrigger("FadeOut");
            GameManager.UpdateScore(100);
            Destroy(this.gameObject); 
        }
    }
    public void SetGameManager (GameManager gm)
    {
        GameManager = gm;
    }
}