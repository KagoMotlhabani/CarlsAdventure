using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tutorial : MonoBehaviour
{
    public TMP_Text textBox;
    public int index;

    public string[] sentences = {
        "'Look at these objects... Something about them makes me want to sing about being a Guest at an old castle!'",
        "'Hmm.. What's that over there? On the hill?'",
        "'It appears someone used this desk for studies and research... I wonder what happened to them.'",
        "'What is this old structure? I must investigate'",
        "'*GASP* Is that me? Decorated in the colours of this world??? And who is this strange being on these walls? He looks like the one father (Alien Bob) calls 'creator...'"
    };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Tutorial" && index < 5){
            textBox.text = sentences[index];
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.tag == "Tutorial"){
            textBox.text = "";
            index ++;
        }
    }
}
