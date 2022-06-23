using UnityEngine;

namespace CubeSurfer.PlayerCamera
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private Transform _targetTransform;
        [SerializeField] CameraSettings _cameraSettings;

        private void Update()
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Lerp(transform.position.z,
                _targetTransform.transform.position.z - _cameraSettings.ZoffSet, _cameraSettings.LerpSpeed * Time.deltaTime));
        }
    }
}

