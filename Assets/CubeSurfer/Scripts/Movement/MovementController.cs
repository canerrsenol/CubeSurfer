using CubeSurfer.PlayerInput;
using UnityEngine;

namespace CubeSurfer.Movement
{
    public class MovementController : MonoBehaviour
    {
        [SerializeField] private MovementSettings _movementSettings;
        [SerializeField] private InputController _inputController;
        [SerializeField] private Transform _targetTransform;

        private void Update()
        {
            float calculatedMove = Mathf.Clamp(_inputController.CurrentFrameMove * _movementSettings.HorizontalSpeed, -_movementSettings.MaxSwipeSpeed, _movementSettings.MaxSwipeSpeed);
            if (calculatedMove < 0 && _targetTransform.position.x < -_movementSettings.Border) calculatedMove = 0f;
            if (calculatedMove > 0 && _targetTransform.position.x > _movementSettings.Border) calculatedMove = 0f;
            transform.Translate(new Vector3(calculatedMove, 0, _movementSettings.VerticalSpeed) * Time.deltaTime);
        }
    }
}


