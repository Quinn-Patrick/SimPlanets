using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimPlanet.Core
{
    public class MouseGridSelector : MonoBehaviour
    {
        private Camera _cam;
        private Vector2Int _gridPosition;
        [SerializeField] private GameObject _selectionIndicator;

        void Start()
        {
            _cam = Camera.main;
        }

        private void Update()
        {
            Vector3 point = new Vector3();
            Event currentEvent = Event.current;
            Vector2 mousePos = new Vector2();
            mousePos.x = Input.mousePosition.x;
            mousePos.y = Input.mousePosition.y;

            point = _cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, -_cam.transform.position.z));
            point *= 1.5625f;

            _gridPosition = new Vector2Int(Mathf.FloorToInt(point.x), Mathf.FloorToInt(point.y));

            if (_selectionIndicator == null) return;
            _selectionIndicator.transform.position = (Vector2) _gridPosition * (64f / 100f);
        }

        void OnGUI()
        {
            UnityEngine.GUI.Label(new Rect(10, 50, 1000, 20), $"Grid Cursor Position: {_gridPosition}");
        }
    }
}