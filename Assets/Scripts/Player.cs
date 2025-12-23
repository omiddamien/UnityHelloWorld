using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Bullet;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }


        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position += new Vector3(10 * Time.deltaTime, 0f, 0f);
            player.transform.localScale = new Vector3(-Mathf.Abs(player.transform.localScale.x), player.transform.localScale.y, player.transform.localScale.z);
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position -= new Vector3(10 * Time.deltaTime, 0f, 0f);
            player.transform.localScale = new Vector3(Mathf.Abs(player.transform.localScale.x), player.transform.localScale.y, player.transform.localScale.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * 1000f);
        }

    }


    public void Shoot()
    {

        GameObject B = Instantiate(Bullet, GameObject.Find("BulletSpawnPoint").transform.position, Quaternion.identity);
        Vector2 direction = player.transform.localScale.x > 0 ? Vector2.left : Vector2.right;
        B.GetComponent<Rigidbody2D>().AddForce(direction * 2000f);
        SpriteRenderer bulletSR = B.GetComponent<SpriteRenderer>();
        if (bulletSR != null)
        {
            bulletSR.flipX = (direction == Vector2.left);
        }
        Destroy(B, 2f);
    }
}
