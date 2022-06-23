using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleProperties : MonoBehaviour
{
    [SerializeField] private int obstacleLength;

    public int ObstacleLength { get { return obstacleLength; } }
}
