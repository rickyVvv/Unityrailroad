using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Musicplayer : MonoBehaviour
{
    private void Awake(){
        DontDestroyOnLoad(gameObject);
    }
    // awake is a message that gets called right before start theres a whole 
    //flow chart
    // Start is called before the first frame update
    void Start(){
        Invoke("LoadFirstScene", 2f);
    }
    
    void LoadFirstScene(){
        SceneManager.LoadScene(1);
        
    }

}
