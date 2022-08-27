using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNumber : MonoBehaviour
{
    public static int random_speed;

    public bool Random_Number(){
        random_speed = Random.Range(0,2);
        Debug.Log(random_speed);
        if(random_speed == 0){
           return true; }
        return false;
    }
}
