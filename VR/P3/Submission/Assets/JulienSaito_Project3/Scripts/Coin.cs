using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
    public GameObject coinPoofPrefab;

    public void OnCoinClicked() {
        // Instantiate the CoinPoofPrefab where this coin is located : transform.position
        // Make sure the poof animates vertically : Quaternion.LookRotation(Vector3.up)
        Object.Instantiate(coinPoofPrefab, transform.position, Quaternion.LookRotation(Vector3.up));

        // Destroy this coin. Check the Unity documentation on how to use Destroy
        Destroy(gameObject, 0.5f);
    }
}
