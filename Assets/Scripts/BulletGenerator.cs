using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]

public class BulletGenerator : MonoBehaviour {

    public GameObject bulletPrefab;
    public GameObject source;

    private float delta = 0.0f;
    private float span = 0.05f;

    private void Start() {
        this.source = GameObject.Find("Player");
    }

    void Update () {
        this.delta += Time.deltaTime;
        if (delta > span) {
            this.delta = 0.0f;
            if (Input.GetKey(KeyCode.Space)) {
                GameObject bullet = Instantiate(bulletPrefab) as GameObject;

                bullet.transform.position = source.transform.position;
            }
        }

	}
}
