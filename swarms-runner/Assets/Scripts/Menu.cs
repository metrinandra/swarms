using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    

    void Start(){
        string[] texts = {"Lockdown game", "avoid bat swards", "and stay negative", "hit PLAY button to start"};
       PrintText(texts, 1.0f);
   }
    public void PlayGame (){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
}

    IEnumerator PrintText(string[]texts, float delay){
        foreach (string txt in texts){
            print(txt);
            yield return new WaitForSeconds (delay);
        }

    }
}