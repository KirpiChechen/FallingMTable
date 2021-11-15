using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class UnityAdsInitialization : MonoBehaviour
{
    private string gameId = "3884397";
    // Start is called before the first frame update
    void Start()
    {
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize(gameId, false);
        }
    }
}
