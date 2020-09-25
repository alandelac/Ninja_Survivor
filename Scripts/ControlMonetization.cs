using UnityEngine;
using UnityEngine.Advertisements;

public class ControlMonetization : MonoBehaviour
{

    string gameId = "3686883";
    string normalAd = "video";
    

    // Initialize the Ads listener and service:
    void Start()
    {
        Advertisement.Initialize(gameId);
    }

    public void InterstitialAd()
    {
        Advertisement.Show(normalAd);
    }

    
}


