using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickWebButton : MonoBehaviour
{

    public void WebButtonEvent() {
            Application.OpenURL(Constants.MAIN_URL); 
    }

}
