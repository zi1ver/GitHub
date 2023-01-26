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
        }

        else if (collision.CompareTag("colLoudMetal"))
        {
            soundManager.PlaySfxLoudMetalClang();
        }

        else if (collision.CompareTag("colClearMetal"))
        {
            soundManager.PlaySfxClearMetalImpact();
        }

        else if (collision.CompareTag("colBone"))
        {
            soundManager.PlaySfxBoneImpact();
        }

        else if (collision.CompareTag("colCageRattle"))
        {
            soundManager.PlaySfxCageRattle();
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
