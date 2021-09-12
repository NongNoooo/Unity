﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager
{
    public Action<Define.MouseEvent> MouseAction = null;

    bool pressed = false;

    public void OnUpdate()
    {
        if(MouseAction != null) //마우스를 눌렀다 땔때 클릭 이벤트를 발생시키기 위해 작성
        {
            if (Input.GetMouseButton(1)) //마우스 왼쪽을 눌렀을때
            {
                MouseAction.Invoke(Define.MouseEvent.Press);
                pressed = true; //마우스가 눌러졌을때 pressed를 true로 변경
            }
            else //마우스 왼쪽을 땔때
            {
                if (pressed) // pressed가 true라면
                {
                    MouseAction.Invoke(Define.MouseEvent.Click); //클릭발1
                    pressed = false;
                }
            }
        }
    }
}