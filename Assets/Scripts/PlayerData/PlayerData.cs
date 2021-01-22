using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TerraFirma
{
    public class PlayerData : MonoBehaviour
    {

        [SerializeField] int startHealth;
        [SerializeField] private Elinvoimapisteet elinvoimapisteet;
        public Apple apple;
        private void Awake()
        {
            apple = new Apple();
            elinvoimapisteet = new Elinvoimapisteet(startHealth);
        }

        private void Update()
        {
            int Health = elinvoimapisteet.ElinVoimaPisteet();
            Debug.Log("Health" + Health);
        }

        private void Start()
        {

        }

        public int getMinimumHealth()
        {
            return 0;
        }

        public bool appleHasBeenThrown()
        {
            return apple.getThrown();
        }
    }
}
