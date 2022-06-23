using UnityEngine;

namespace CubeSurfer.PlayerInput
{
    public class InputController : MonoBehaviour
    {
        private float _lastFrameX;
        private float _currentFrameMove;

        public float CurrentFrameMove { get { return _currentFrameMove; } }

        private void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                _lastFrameX = Input.mousePosition.x;
            }
            if(Input.GetMouseButton(0))
            {
                _currentFrameMove = Input.mousePosition.x - _lastFrameX;
                _lastFrameX = Input.mousePosition.x;
            }
            if(Input.GetMouseButtonUp(0))
            {
                _currentFrameMove = 0f;
            }
        }
    }
}

