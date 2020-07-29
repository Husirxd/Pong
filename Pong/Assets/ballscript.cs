using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class ballscript : MonoBehaviour
{

public static ballscript instance;
    public float speed,acc;
public int score=0,lives=3;
    Vector2 direction,startposition;
    public GameObject Scoretxt,Manager,h1,h2,h3;

    // Start is called before the first frame update
    void Start()
    {
acc=speed/100;
direction = Vector2.one.normalized;
startposition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
if(lives>0){
transform.Translate(direction*speed*Time.deltaTime);
}
    }
    void OnTriggerEnter2D(Collider2D col){
      
        if(col.tag=="wall"){
          direction.x = -direction.x;
        }
        if(col.tag=="player"){
            score++;
            Scoretxt.GetComponent<TextMeshProUGUI>().text = "Score: "+score;
            speed=speed+acc;
            direction.x = -direction.x;
        }
        if(col.tag=="side"){
direction.y= -direction.y;
        }
        if(col.tag=="minusjeden"){
gameObject.transform.position = startposition;
lives--;
ChangeState();
gameObject.GetComponentInChildren<TrailRenderer>().Clear();
direction.x = -direction.x;
        }

    }
    void ChangeState(){
           switch(lives){
            case 1:
             h2.SetActive(false);
            break;
            case 2:
            h3.SetActive(false);
            break;
            case 0:
             h1.SetActive(false);
             Manager.GetComponent<manager>().GameOver(score);
            break;
        }
    }
}
