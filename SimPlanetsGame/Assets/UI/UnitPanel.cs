using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using SimPlanet.Core;

namespace SimPlanet.GUI 
{
    public class UnitPanel : MonoBehaviour
    {
        [SerializeField] private Unit _unit;
        [SerializeField] private TextMeshProUGUI _text;

        private void Start()
        {
            _text.text = _unit.GetName();
        }
    }
}