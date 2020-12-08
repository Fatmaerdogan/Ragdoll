using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    [Tooltip("değişken true ise sağa false ise sola doğru gidecek")]
    public bool yon;
    void Update()
    {
        if(yon==true)
            this.transform.position += new Vector3(0f, 0f, 0.1f) ;
        else
            this.transform.position -= new Vector3(0f, 0f, 0.1f) ;
        if (this.transform.position.z >= 5)
        {
            yon = false;
        }
        else if(this.transform.position.z <= -5)
        {
            yon = true;
        }

    }
}
