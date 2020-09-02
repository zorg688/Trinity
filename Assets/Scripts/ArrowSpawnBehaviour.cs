using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawnBehaviour : MonoBehaviour
{
    private IEnumerator coroutine;

    private bool _spawnOn = true;

    public GameObject _arrowPrefab;

    public GameObject _player;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(SpawnArrows());
    }

    // Update is called once per frame
    void Update()
    {
        if (_player.transform.position.x >= 110 && _player.transform.position.x <= 150 &&
            _player.transform.position.z >= 197 && _player.transform.position.z <= 210)
        {
            //_spawnOn = true;
            Instantiate(_arrowPrefab, new Vector3(Random.Range(110f, 150f), 1.5f, 230), Quaternion.identity).transform.SetParent(transform);
        }
        else
        {
            _spawnOn = false;
        }
        
        

        //Debug.Log(_player.transform.position);
        
        //_player.transform.position.x >= 110 && _player.transform.position.x <= 150 && _player.transform.position.z >= 197 && _player.transform.position.z <= 210
    }

    private IEnumerator SpawnArrows()
    {
        while(_spawnOn)
        {
            Instantiate(_arrowPrefab, new Vector3(Random.Range(110f, 150f), 1.5f, 230), Quaternion.identity).transform.SetParent(transform);
            yield return new WaitForSeconds(1.0f);
        }
    }
}
