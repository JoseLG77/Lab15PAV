using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Vector3 direccion;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
        direccion = new Vector3(0, -1, 0);
        Destroy();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += this.direccion * this.speed * Time.deltaTime;
    }
    void Destroy()
    {
        Destroy(this.gameObject, 2.5f);
    }
}
