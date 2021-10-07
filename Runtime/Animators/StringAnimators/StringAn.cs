using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace U.Motion
{
    //public class StringAn : TimeAnimatorCore
    //{

    //    public Text text;
    //    public string textToWrite = "Hola a todfs ff wefsf sfsdf ewfewfwefef fsdcsdvdf";
    //    private int lastWritedIndex = 0;


    //    private int characterIndex;


    //    private void Start()
    //    {
    //        config.delay = 3;
    //        config.duration = 10;
    //        text.text = "Hola";
    //        Set("Hola a todfs ff wefsf sfsdf ewfewfwefef fsdcsdvdf");
    //    }

    //    protected override void OnUpdate(float copletedPercentage)
    //    {

    //        characterIndex = Mathf.RoundToInt((textToWrite.Length * copletedPercentage));
            
    //        if(characterIndex != lastWritedIndex)
    //        {
    //            text.text = textToWrite.Substring(0, characterIndex);
    //            lastWritedIndex = characterIndex;
    //            Debug.Log("Writed");
    //        }
        
    //    }


    //    public override List<AnimationCurve> GetCurves()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public StringAn Set(string textToWrite, TimeAnimationParams animationParams = null)
    //    {
    //        this.textToWrite = textToWrite;
    //        base.Set(animationParams);

    //        return this;
    //    }

    //}
}
