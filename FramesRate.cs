using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FramesRate : MonoBehaviour
{
    //Permite que la variable privada sea vista en el inspector
    [SerializeField]
    //Cantidad de fps deseada
    private int framesPerSecond = 30;
    void Start()
    {
      //Desactiva vSync
      QualitySettings.vSyncCount = 0;
      //Aplica el bloqueo de fps en la cantidad puesta en la variable
      Application.targetFrameRate = framesPerSecond;  
    }

}
