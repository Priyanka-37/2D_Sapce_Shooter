using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundry
{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private Vector3 playerMove;

    private new Rigidbody rigidbody;

    public float speed;
    public float tilt;
    public Boundry boundry;

    public GameObject bolt;
    public Transform boltSpawnPostion;
    public float fireRate;
    private float nextFire;

    private void Start()
    {
        rigidbody = GetComponent< Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(bolt, boltSpawnPostion.transform.position, bolt.transform.rotation);
        }
    }

    private void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        playerMove = new Vector3(horizontal, 0.0f, vertical);

        rigidbody.velocity = playerMove * speed;

        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, boundry.xMin, boundry.xMax), 
            0,
            Mathf.Clamp(transform.position.z, boundry.zMin, boundry.zMax)
            );

        rigidbody.rotation = Quaternion.Euler(0.0f, 0.0f, rigidbody.velocity.x * -tilt);
    }

}
