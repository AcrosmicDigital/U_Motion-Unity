using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U.Motion
{
    public interface IanimatorCore
    {
        void Play();
        void Pause();
        void Restart();
        void CompleteNow();
        Task Task();
        IEnumerator Coroutine();
    }
}
