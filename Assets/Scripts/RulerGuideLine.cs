using UnityEngine;
using UnityEngine.EventSystems;

namespace TempoSuspeito
{
    public class RulerGuideLine : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        public Transform GuideLineTransform;


        public void OnPointerEnter(PointerEventData eventData)
        {
            GuideLineTransform.position = transform.position;
            GuideLineTransform.gameObject.SetActive(true);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            GuideLineTransform.gameObject.SetActive(false);
        }
    }
}