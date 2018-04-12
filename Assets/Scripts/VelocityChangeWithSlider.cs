using UnityEngine;
using UnityEngine.UI;

namespace TempoSuspeito
{
    public class VelocityChangeWithSlider : MonoBehaviour
    {
        public Slider Slider;
        public Velocidade Velocidade;
        
        private void Start()
        {
            Velocidade.Speed = Slider.value;
        }

        private void OnEnable()
        {
            Slider.onValueChanged.AddListener(OnValueChange);
        }

        private void OnDisable()
        {
            Slider.onValueChanged.RemoveListener(OnValueChange);
        }

        private void OnValueChange(float newValue)
        {
            Velocidade.Speed = newValue;
        }
    }
}