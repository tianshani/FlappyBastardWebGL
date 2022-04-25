using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _bird;
    [SerializeField] private PipeSpawner _pipeSpawner;

    [SerializeField] private GameObject _startScreen;

    private int Coins;


    private void Start()
    {
        _startScreen.SetActive( true );
        
        Time.timeScale = 1;
    }


    public void GameStart()
    {
        _startScreen.SetActive( false );
        _bird.SetActive( true );
        _pipeSpawner.gameObject.SetActive( true );
    }


    public void GameOver()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene( 0 );
    }
}
