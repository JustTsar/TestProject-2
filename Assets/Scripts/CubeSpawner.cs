using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private CubeMovement _cubePrefab;
    [SerializeField] private float _timeToNextSpawn;
    //����� ����� ���� ������������ � GameObject - �� � ������ ������ ���, ��� �� ����� �� ��� ������� ��� �������� �� ����� ������� ��� �� ������ 

    private bool _cubeSpawnIsReady = true;
    private void Update()
    {
        if (_cubeSpawnIsReady)
        {
            StartCoroutine(TimeToSpawnCube());
        }
    }
    private IEnumerator TimeToSpawnCube()
    {
        _cubeSpawnIsReady = false;
        GameObject cube = Instantiate(_cubePrefab.gameObject, _spawnPoint);
        yield return new WaitForSeconds(_timeToNextSpawn);
        _cubeSpawnIsReady = true;
    }
}
