using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shield : MonoBehaviour
{
    [Header("Inscribed")]
    public float rotationsPerSecond = 0.1f;

    [Header("Dynamic")]
    public int levelShown = 0; // This is set between lines // c & d

    // This non-public variable will not appear in the Inspector
    Material mat;
    public int lives = 3;
    public UnityEngine.UI.Image[] livesUI;                                                        // a

    void Start()
    {
        mat = GetComponent<Renderer>().material;                              // b
    }

    void Update()
    {
        // Read the current shield level from the Hero Singleton
        int currLevel = Mathf.FloorToInt(Hero.S.shieldLevel);               // c
                                                                            // If this is different from levelShown...
        if (levelShown != currLevel)
        {
            levelShown = currLevel;
            // Adjust the texture offset to show different shield level
            mat.mainTextureOffset = new Vector2(0.2f * levelShown, 0);       // d

            lives += 1;

            for( int i = 0; i < livesUI.Length; i++ )
            {
                if ( i < lives )
                {
                    livesUI[i].enabled = false;
                }
                else
                {
                    livesUI[i].enabled = true;
                }
            }
        }
        // Rotate the shield a bit every frame in a time-based way
        float rZ = -(rotationsPerSecond * Time.time * 360) % 360f;               // e
        transform.rotation = Quaternion.Euler(0, 0, rZ);
    }
}
