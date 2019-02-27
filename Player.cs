using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public GameObject plane_lose;
    public GameObject gaochubushenghan;
    public GameObject bgm;
    public Text text;
    private int score = 0;
	void Start () {
		
	} 
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision collision)
    {
        //string name = collision.collider.name
        if(collision.collider.tag=="PickUp")
        {
            Time.timeScale = 0;
            plane_lose.SetActive(true);
        }
        else if(collision.collider.tag == "Star")
        {
            bgm.SetActive(true);
            score =score+10;
            Destroy(collision.collider.gameObject);
            text.text = score.ToString();
        }
        else if (collision.collider.tag == "Gaodu")
        {
            {
                Time.timeScale = 0;
                gaochubushenghan.SetActive(true);
            }
        }
    }
}
