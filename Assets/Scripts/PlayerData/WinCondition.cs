using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TerraFirma
{
    public class WinCondition
    {
        public int count;
        private int maxItems;


        public WinCondition()
        {
            count = 0;
            maxItems = 30;
        }

        public bool CheckWinCondition()
        {
            if (count >= maxItems)
            {
                return true;
            }
            return false;
        }

    }
}
