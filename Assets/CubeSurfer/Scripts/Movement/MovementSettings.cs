using UnityEngine;

namespace CubeSurfer.Movement
{
    [CreateAssetMenu(menuName = "CubeSurfer/Movement/Movement Settings")]
    public class MovementSettings : ScriptableObject
    {
        public float HorizontalSpeed=3f;
        public float VerticalSpeed=5f;
        public float Border = 4.2f;
        public float MaxSwipeSpeed = 4f;
     }
}

