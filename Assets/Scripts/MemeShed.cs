using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemeShed : MonoBehaviour
{
    public AudioManager audioManager;
    public bool isPlaying = false;

    void Awake(){
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other) {
        Debug.Log($"here we go");
        if(other.tag == "Player" && isPlaying == false){
            audioManager.PlayMusic();
            isPlaying = true;
        }
    }
}
