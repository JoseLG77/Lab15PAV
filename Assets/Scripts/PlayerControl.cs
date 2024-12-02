using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D _componentRigidbody2D;
    public float horizontal;
    public float vertical;
    public float speed;
    public Proyectil prefabbullet;
    public AudioSource SFXmanager;



    private void Awake()
    {
        _componentRigidbody2D = GetComponent<Rigidbody2D>();
        speed = 7.5f;

    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (Input.GetButtonDown("Fire1") == true)
        {
            Shoot();
            SFXmanager.Play();
        }

    }

    void Shoot()
    {
        GameObject bullet = Instantiate(prefabbullet.gameObject,transform.position,transform.rotation);
        bullet.tag = "bullet";
    }

    private void FixedUpdate()
    {
        _componentRigidbody2D.velocity = new Vector2(horizontal * speed, vertical * speed);
    }
}
