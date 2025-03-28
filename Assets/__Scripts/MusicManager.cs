using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MusicManager : MonoBehaviour
{

    public static MusicManager instance;
    // Start is called before the first frame update
    public void Awake()
    {
        if (instance == null){
            DontDestroyOnLoad(this.gameObject);
            instance = this;
        }
        else{
            Destroy(gameObject);
        }
    }
}
