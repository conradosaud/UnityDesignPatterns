using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Transform bullet;

    bool isJumping = false;
    public float velocity = 5;
    public float jumpForce = 100;
    public int life = 3;

    Rigidbody2D rb;

    public static event Action<int> OnLifeChanged;

    private void Awake()
    {
        Moeda.OnCoinCollected += HandleCoinCollected;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");

        Vector2 moviment = new Vector2(horizontal * velocity, rb.velocity.y);

        if(Input.GetKey(KeyCode.Space) && isJumping == false)
        {
            isJumping = true;
            rb.AddForce(Vector3.up * jumpForce);
        }

        rb.velocity = moviment;

        // SINGLETON
        if( Input.GetKeyDown(KeyCode.Alpha1))
        {
            //GameObject.Find("SpawnPontos").GetComponent<SpawnPontos>().Spawnar(0);
            SpawnPontos.singleton.Spawnar(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //GameObject.Find("SpawnPontos").GetComponent<SpawnPontos>().Spawnar(1);
            SpawnPontos.singleton.Spawnar(1);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isJumping = false;
    }

    void HandleCoinCollected(bool velocityPoint)
    {
        if (velocityPoint)
            velocity++;
        else
            jumpForce += 25;
    }

    public void TakeDamage()
    {
        life--;
        OnLifeChanged(life);
    }

}
