using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]

public class BulletController : MonoBehaviour {

    public GameObject bullet;
    public Rigidbody2D rb;

    private float xMaxSpeed = 35.0f;
    private float yMaxSpeed = 0.0f;

    public void OnBecameInvisible() {
        Destroy(this.gameObject);
    }

    void Start () {
        this.bullet = GameObject.Find("Bullet");
        this.rb = GetComponent<Rigidbody2D>();
	}

    private void Move(float x, float y) {
        this.rb.velocity = new Vector2(xMaxSpeed * x, yMaxSpeed * y);
    }

    void Update () {
        Move(1.0f, 0.0f);
	}
}
