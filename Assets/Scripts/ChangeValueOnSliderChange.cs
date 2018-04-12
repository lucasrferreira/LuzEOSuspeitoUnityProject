using UnityEngine;
using UnityEngine.UI;

namespace TempoSuspeito
{
    public class ChangeValueOnSliderChange : MonoBehaviour
    {
        private static float? _value = null;
        public Slider Slider;
        public Text Text;

        private void Start()
        {
            if (!_value.HasValue)
                _value = Slider.value;
            else
            {
                Slider.value = _value.Value;
            }
                
            Text.text = Slider.value.ToString("0.00c");
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
            Text.text = newValue.ToString("0.00c");
            _value = newValue;
        }
    }
}