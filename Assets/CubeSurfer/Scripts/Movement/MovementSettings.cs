using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeSurfer.Movement
{
    [CreateAssetMenu(menuName = "CubeSurfer/Movement/Movement Settings")]
    public class MovementSettings : ScriptableObject
    {
        public float HorizontalSpeed=5f;
        public float VerticalSpeed=5f;
    }
}

