using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployAsteroids : MonoBehaviour
{

    [SerializeField] private float timeStart = 0;
    [SerializeField] private int per_second_increment = 10;
    [SerializeField] private GameObject[] asteroid;
    public float respawn_time = 1.0f;
    private Vector2 screen_bounds;
    Asteroid b;
    private int random_number;

    // Start is called before the first frame update
    private void Start()
    {
        screen_bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave());
    }

    void Update()
    {
        timeStart += Time.deltaTime;

        if (timeStart >= per_second_increment && respawn_time > 0.14f) {
            timeStart = 0f;
            Debug.Log("timeStart: " + Mathf.Round(timeStart));
            respawn_time -= 0.06f;
            Debug.Log("respawn_time: " + respawn_time);
        }
    }

    private void spawnEnemy(){

        random_number = Random.Range(0,3);
        
        GameObject a = Instantiate(asteroid[random_number]) as GameObject;

        b = asteroid[random_number].GetComponent<Asteroid>();
        b.RandomNumber();

        if(b.random_speed == 0){
            a.transform.position = new Vector2(Random.Range(-screen_bounds.x, -screen_bounds.x + 10), Random.Range(-screen_bounds.y - 0.7f, screen_bounds.y));
        } else {
            a.transform.position = new Vector2(Random.Range(-screen_bounds.x - 0.7f, screen_bounds.x), -screen_bounds.y + 3);
        }
    }

    IEnumerator asteroidWave(){
        while(true){
            yield return  new WaitForSeconds(respawn_time);
            spawnEnemy();
        }
    }
}
