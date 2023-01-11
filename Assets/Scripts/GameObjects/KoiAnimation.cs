using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoiAnimation : MonoBehaviour
{
    private SpriteRenderer image;
    public Sprite koi1;
    public Sprite koi2;
    public Sprite koi3;
    public Sprite koi4;

    private float currentImage;

    public float timeDelay;
    private float timeSinceLast;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<SpriteRenderer>();
        currentImage = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(timeSinceLast);
        if (timeSinceLast > timeDelay)
        {
            currentImage++;
            if (currentImage > 4)
            {
                currentImage = 1;
            }
            // Debug.Log("Changing to image: " + currentImage);

            if (currentImage == 1) {
                image.sprite = koi1;
            }

            if (currentImage == 2)
            {
                image.sprite = koi2;
            }

            if (currentImage == 3)
            {
                image.sprite = koi3;
            }

            if (currentImage == 4)
            {
                image.sprite = koi4;
            }

            timeSinceLast = 0;
        }

        timeSinceLast += Time.deltaTime;
    }
}
