using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoUpArrow : MonoBehaviour
{
    public static bool ImageShow = false;
    private Image image;
    // Start is called before the first frame update
   private void Awake() {
        image = GetComponent<Image>();
        image.enabled = false;
   }

    // Update is called once per frame
    void Update()
    {
        if (ImageShow)
        {
            image.enabled = true;
        }
    }
}
