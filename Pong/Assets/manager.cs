using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class manager : MonoBehaviour
{
    int lives,highscore;
public GameObject GameOverUI,ScoreTxt,HighScoreTxt;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

public void GameOver(int score){
    GameOverUI.SetActive(true);
    ScoreTxt.GetComponent<TextMeshProUGUI>().text = "YOUR SCORE: "+score.ToString();
    if(PlayerPrefs.HasKey("High")){
    highscore = PlayerPrefs.GetInt("High");
        if(highscore<score){
        PlayerPrefs.SetInt("High",score); 
        highscore = PlayerPrefs.GetInt("High");
}
}else{
    PlayerPrefs.SetInt("High",score);
    highscore = PlayerPrefs.GetInt("High");
}
HighScoreTxt.GetComponent<TextMeshProUGUI>().text = "The Best Score: "+highscore.ToString();


}
void Update() {
    if(ScoreTxt.activeInHierarchy==true&&ScoreTxt.transform.localPosition.x<0){
    
        ScoreTxt.transform.position += new Vector3(500*Time.deltaTime,0,0);
        HighScoreTxt.transform.position += new Vector3(500*Time.deltaTime,0,0);
    }
}
public void Menu(){
    SceneManager.LoadScene("Menu");
}
}
