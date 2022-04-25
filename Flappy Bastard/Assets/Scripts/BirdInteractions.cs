using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BirdInteractions : MonoBehaviour
{
    [SerializeField] private float _velocityMultiplier;

    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private GameManager _gameManager;

    [SerializeField] private TMP_Text _pointCounterText;
    [SerializeField] private TMP_Text _coinCounterText;

    //    [SerializeField] private CoinManager _coinCounter;

    private int _coins = 0;
    private int _points = 0;
    private const int GAINEDPOINTS = 100;

    private void Update()
    {
        if( Input.GetMouseButtonDown( 0 ) )
            _rb.velocity = Vector2.up * _velocityMultiplier;
    }


    private void OnCollisionEnter2D( Collision2D collision )
    {
        _gameManager.GameOver();
    }


    private void OnTriggerEnter2D( Collider2D collision )
    {
        if( collision.transform.tag == "Pipe" )
        {
            _points += GAINEDPOINTS;
            _pointCounterText.text = _points.ToString();
        }

        GameObject _coinCounter = collision.gameObject;

        if( _coinCounter.name.Contains( "SilverCoin" ) )
        {
            _coins += 50;
            _coinCounter.SetActive( false );
        }
        if( _coinCounter.name.Contains( "GoldenCoin" ) )
        {
            _coins += 10;
            _coinCounter.SetActive( false );
        }

        _coinCounterText.text = _coins.ToString();
    }
}
