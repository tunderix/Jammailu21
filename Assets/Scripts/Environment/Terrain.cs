using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TerraFirma
{
    public class Terrain : MonoBehaviour
    {

        [SerializeField] PlayerData playerdata;
        public void updatePlayerHealth()
        {
            //PlayerData playerdata = GameObject.Find("Player").GetComponent<PlayerData>();
            //int elinvoimapisteet = playerdata.getElinvoimapisteet();
            int minimumHealth = playerdata.getMinimumHealth();
        }
    }
}
