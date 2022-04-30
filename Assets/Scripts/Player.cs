using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float moveSpeed = 600f;
    float movement = 0f;

    public event System.Action OnPlayerDeath;
    void Update()
    {
       movement=Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime* -moveSpeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (OnPlayerDeath != null)
        {
            OnPlayerDeath();
        }
        Destroy(gameObject);
    }
   
}
