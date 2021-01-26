using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TerraFirma
{
    public class WinCondition
    {
        private int count = 0;
        public string GUIText;

        private void OnCollisionWithPlayer(GameObject player)
        {
            count += 1;
            //GameObject.Destroy("Gem").GetComponent<Item>();
        }

        /*         void Update()
                {
                    if (count >= 10)
                    {
                        g = new GameObject;
                        text = g.AddComponent(GUIText);
                        Text.text = "Retry? | Quit?";

                        text.transform.position = new Vector3(0.5f, 0.5f, 0);

                        text.Anchor = TextAnchor.MiddleCenter;
                    }
                } */

    }
}
