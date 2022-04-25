using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private GameObject _goldenCoinSprite;
    [SerializeField] private GameObject _silverCoinSprite;

    public GameObject coinToSpawn;
    private int _randomNumber;
    private int coinPrice;


    private void Update()
    {
        _randomNumber = Random.RandomRange( 0, 10 );
        coinToSpawn = RandomCoinCalculation( _goldenCoinSprite, _silverCoinSprite, _randomNumber );
    }


    private GameObject RandomCoinCalculation( GameObject goldenCoin, GameObject silverCoin, int randomNumber )
    {
        GameObject coinToSpawn;

        coinToSpawn = null;
        if( randomNumber <= 1 )  // Probability: 0.2
        {
            coinToSpawn = goldenCoin;
        }
        if( randomNumber >= 7 )  // Probability: 0.4
        {
            coinToSpawn = silverCoin;
        }

        return coinToSpawn;
    }
}
