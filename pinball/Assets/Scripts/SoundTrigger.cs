using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{

    public SoundManager soundManager;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("colLightMetal"))
        {
            soundManager.PlaySfxLightMetalImpact();

            //test
            Debug.Log("colLightMetal");
        }
        else if (collision.CompareTag("colLoudMetal"))
        {
            soundManager.PlaySfxLoudMetalClang();

            //test
            Debug.Log("colLoudtMetal");
        }
        else if (collision.CompareTag("colClearMetal"))
        {
            soundManager.PlaySfxClearMetalImpact();

            //test
            Debug.Log("colClearMetal");
        }
        else if (collision.CompareTag("colBone"))
        {
            soundManager.PlaySfxBoneImpact();

            //test
            Debug.Log("colBone");
        }
        else if (collision.CompareTag("colCageRattle"))
        {
            soundManager.PlaySfxCageRattle();

            //test
            Debug.Log("colCageRattle");
        }
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
