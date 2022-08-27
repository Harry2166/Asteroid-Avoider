using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{

    public float speed = 10f;
    private Rigidbody2D rb;
    private Vector2 screen_bounds;
    public int random_speed;

    // Start is called before the first frame update
    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        if(random_speed == 0){
            rb.velocity = new Vector2(-speed, Random.Range(-1f, -1.5f));
        } else {
            rb.velocity = new Vector2(Random.Range(-1f, -1.5f), -speed);
        }
        //rb.velocity = new Vector2(-speed, 0); // i can randomly make it so that they have random speed stuff NICE (LOL YOU THOUGHT BOI)
        screen_bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    private void Update()
    {

        if(transform.position.x < screen_bounds.x * 1.15 || transform.position.y < screen_bounds.y * 1.15){
            Destroy(this.gameObject);
        }
    }

    public int RandomNumber(){
        random_speed = Random.Range(0,2);
        return random_speed;
    } // you have to call this outside of the function, fix this future harry!!!!!
}
