using Assets.Scripts.GameCore.Health;
using System.Collections;
using UnityEditor;
using UnityEngine;

namespace Player
{
    public class PlayerHealth : objectHealth
    {
        private WaitForSeconds _regenerationInterval = new WaitForSeconds(5f);
        private float _regenerationValue = 1f;

        private void Start() => StartCoroutine(Regeneration());
        public override void TakeDamage(float damage)
        {
            base.TakeDamage(damage);
            if (CurrentHealth <= 0)
                Debug.Log("Игрок умер");
        }

        private IEnumerator Regeneration()
        {
            while (true)
            {
                TakeHeal(_regenerationValue);
                yield return _regenerationInterval;
            }
        }
    }
}