using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lesson1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        #region 二、游戏退出

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        #region 一、场景切换
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //切换到场景2
            //直接切会有问题
            SceneManager.LoadScene("Test2");
        }
        #endregion
        #region 二、游戏退出
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            //执行这句代码就会退出游戏，但是再编辑模式下没有作用
            //一定是发布游戏过后 才有用
            Application.Quit();
        }
        #endregion
    }
}