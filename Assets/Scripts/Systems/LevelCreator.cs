using System;
using UnityEngine;

namespace CaveDweller.Systems
{
    public class LevelCreator : MonoBehaviour
    {
        [Header("Prefabs")]
        [SerializeField] private GameObject playerPrefab;
        [SerializeField] private GameObject enemyPrefab;
        [SerializeField] private GameObject levelPrefab;
        
        [Header("Locations")]
        [SerializeField] private Vector3 playerLocation;
        [SerializeField] private Vector3 enemyLocation;

        [Header("Other")]
        [SerializeField] private MainCanvas mainCanvas;
        private Player.Player playerInstance;
        private Enemy.Enemy enemyInstance;
        private GameObject currentLevel;

        private void Start()
        {
            SpawnLocation();
            SpawnCharacters();
            mainCanvas.Init(playerInstance.Health);
        }
        
        private void SpawnLocation()
        {
            currentLevel =
                Instantiate(levelPrefab, Vector3.zero, Quaternion.identity);
        }

        private void SpawnCharacters()
        {
            playerInstance = 
                Instantiate(playerPrefab, playerLocation, Quaternion.identity).GetComponent<Player.Player>();
            enemyInstance =
                Instantiate(enemyPrefab, enemyLocation, Quaternion.identity).GetComponent<Enemy.Enemy>();
        }

    }
}
