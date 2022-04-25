using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float _spawnPeriod;
    [SerializeField] private GameObject _pipePrefab;
    [SerializeField] private CoinManager _coinCounter;

    private GameObject newPipe;
    private GameObject _newCoin;

    private float _timer = 1.4f;
    private float _DestroyTime = 5f;
    private float _verticalOffset;



    private void Update()
    {
        if( _timer > _spawnPeriod )
        {
            _verticalOffset = Random.Range( -1f, 3.25f );

            newPipe = Instantiate( _pipePrefab );
            newPipe.transform.position += new Vector3( 8, _verticalOffset, 0 );
            Destroy( newPipe, _DestroyTime );

            if( _coinCounter.coinToSpawn != null )
            {
                _newCoin = Instantiate( _coinCounter.coinToSpawn,
                                        parent: newPipe.transform,
                                        position: newPipe.transform.position,
                                        rotation: Quaternion.identity );
                Destroy( _newCoin, _DestroyTime );
            }


            _timer = 0;
        }

        _timer += Time.deltaTime;
    }
}
