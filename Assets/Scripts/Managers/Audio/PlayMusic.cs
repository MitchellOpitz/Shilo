using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public string musicName;

    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().PlaySound(musicName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
