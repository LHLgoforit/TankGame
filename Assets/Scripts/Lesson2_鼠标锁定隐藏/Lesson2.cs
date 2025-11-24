using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2 : MonoBehaviour
{
    public Texture2D tex;
    // Start is called before the first frame update
    void Start()
    {
        #region 一、隐藏鼠标
            Cursor.visible = true;
        #endregion
        #region 二、锁定鼠标
        //效果是不仅会被锁定还会被隐藏，按esc可以摆脱编辑模式下的锁定
            Cursor.lockState = CursorLockMode.Locked;
        #endregion
        #region 三、设置鼠标图片
        //参数一：光标图片
        //参数二：偏移位置 相对图片左上角
        //参数三：平台支持的光标模式（硬件或者软件）
        Cursor.SetCursor(tex, Vector2.zero,CursorMode.Auto);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
