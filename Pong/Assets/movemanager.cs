using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movemanager : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w")||Input.GetKey(KeyCode.UpArrow)){
if(gameObject.transform.position.y<=3.68f){
    
gameObject.transform.position += new Vector3(0,speed/10,0);
}
}
     if(Input.GetKey("s")||Input.GetKey(KeyCode.DownArrow)){
if(gameObject.transform.position.y>=-3.68f){
gameObject.transform.position += new Vector3(0,-speed/10,0);
}
}

}
}
