using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource      src;
    public AudioClip        sfx1,sfx2,sfx3;

    // Start is called before the first frame update
    void Start()
    {
        src.clip = sfx1;
        src.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
