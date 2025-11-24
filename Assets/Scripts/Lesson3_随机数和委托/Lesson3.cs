using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Lesson3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 一、随机数
        //unity的随机数
        int randomNum = Random.Range(0, 10);//左包含右不包含
        print(randomNum);
        //c#的随机数
        System.Random r = new System.Random();
        r.Next(0, 100);
        #endregion
        #region 二、委托
        //C#自带委托
        System.Action<int, float> ac = (i, f) =>
        {

        };
        System.Func<int, string> fun2 = (i) =>
        {
            return "123";
        };
        //unity自带委托
        UnityAction uac = () =>
        {

        };
        UnityAction<string> uac1 = (s) =>
        {
            
        };
        #endregion
    }

    // Update is called once per frame
    void Update()
    {

    }
}
