using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace U.Motion
{
    public class AnimationChain : MonoBehaviour
    {
        public Tween[] list;
        public bool loop; // Loop is last animation will trigger the first again

        private void Awake()
        {
            if (list == null) return;

            for (int i = 0; i < list.Length; i++)
            {
                // Loop is last animation will trigger the first again
                if (!loop)
                {
                    if ((i + 1) == list.Length)
                    {

                        continue;
                    }
                }
                // No loop is last animation wont have any function
                else
                {
                    if ((i + 1) == list.Length) continue;


                }
            }    
        }

    }

}
