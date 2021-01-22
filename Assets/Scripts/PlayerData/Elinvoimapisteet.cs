using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TerraFirma
{
    [System.Serializable]
    public class Elinvoimapisteet
    {
        [SerializeField] private int elinvoimapisteet;
        private int _minimumHealth;

        public Elinvoimapisteet(int minimumHealth)
        {
            _minimumHealth = minimumHealth;
            setElinvoimaPisteet(minimumHealth);
        }

        public void setElinvoimaPisteet(int value)
        {
            elinvoimapisteet = value;
        }

        public int ElinVoimaPisteet()
        {
            if (elinvoimapisteet < _minimumHealth)
                return _minimumHealth;
            else return elinvoimapisteet;
        }

    }
}
