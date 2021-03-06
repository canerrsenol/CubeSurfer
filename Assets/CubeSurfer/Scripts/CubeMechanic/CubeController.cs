using CubeSurfer.Movement;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace CubeSurfer.CubeController
{
    public class CubeController : MonoBehaviour
    {
        private List<GameObject> cubeList = new List<GameObject>();
        [SerializeField] private Transform _playerModelTransform;
        [SerializeField] private Transform _player;

        private int decreaseHeight = 0;

        private void Start()
        {
            AddCollectedCubeToList();
        }

        private void AddCollectedCubeToList()
        {
            foreach(Transform child in transform)
            {
                if(child.CompareTag("Collected"))
                {
                    cubeList.Add(child.gameObject);
                }
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag("Collectable"))
            {
                other.tag = "Collected";
                other.transform.parent = this.transform;
                other.transform.position = _playerModelTransform.position + Vector3.up / 2;
                _playerModelTransform.position = _playerModelTransform.position + Vector3.up;
                cubeList.Add(other.gameObject);
            }
            else if(other.CompareTag("Obstacle"))
            {
                other.tag = "Player";
                decreaseHeight = other.GetComponent<ObstacleProperties>().ObstacleLength;
                print(cubeList.Count + "Cublelist count");
                print(decreaseHeight + "decrease count");

                if(decreaseHeight >= cubeList.Count)
                {
                    GameOver();
                }
                else
                {
                    for(int i=0; i< decreaseHeight; i++)
                    {
                        cubeList[0].transform.parent = null;
                        cubeList.RemoveAt(0);
                    }
                }
            }
        }

        private void GameOver()
        {
            _player.GetComponent<MovementController>().enabled = false;
            _playerModelTransform.GetComponent<Animator>().SetBool("death", true);
        }

        private void OnTriggerExit(Collider other)
        {
            if(other.CompareTag("Player"))
            {
                foreach(Transform child in _player)
                {
                    child.transform.position -= Vector3.up * decreaseHeight;
                }

                decreaseHeight = 0;
            }
        }

    }
}

