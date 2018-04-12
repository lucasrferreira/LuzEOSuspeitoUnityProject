using UnityEngine;

namespace TempoSuspeito
{
    public class LightEmisser : MonoBehaviour
    {
        public Velocidade LightPrefeb;

        private void Start()
        {
            var l1 = Instantiate(LightPrefeb, transform.position, Quaternion.identity);
            l1.Speed = 1f;
            var l2 = Instantiate(LightPrefeb, transform.position, Quaternion.identity);
            l1.Speed = -1f;
        }
    }
}