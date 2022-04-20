using UnityEngine;

namespace SimPlanet.Core
{
    public class DragableCamera : MonoBehaviour
    {
        public float _scaleFactor = 100f;

        public float _zoomLevel = -10;

        private Vector2 _dragOrigin;


        void Update()
        {
            _zoomLevel += Input.mouseScrollDelta.y;
            transform.position = new Vector3(transform.position.x, transform.position.y, _zoomLevel);

            if (Input.GetMouseButtonDown(0))
            {
                _dragOrigin = Input.mousePosition + transform.position;
            }

            if (!Input.GetMouseButton(0)) return;

            Vector2 pos = Input.mousePosition + transform.position;
            Vector2 delta = _dragOrigin - pos;
            float zoomFactor = -(Screen.height * 0.8657314629f) / _zoomLevel;
            transform.position += new Vector3(delta.x / zoomFactor, delta.y / zoomFactor, 0f);

            _dragOrigin = Input.mousePosition + transform.position;
        }

        private void OnGUI()
        {
            UnityEngine.GUI.Label(new Rect(10, 10, 1000, 20), $"Screen Resolution: {Screen.width} x {Screen.height}");
        }
    }
}