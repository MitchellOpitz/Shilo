using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{

    public GameObject panel;
    public float transitionTime;
    public float timeDelay;

    private float startTime;
    private float endTime;
    private float alphaColor;

    // Start is called before the first frame update
    void Start()
    {
        alphaColor = panel.GetComponent<CanvasGroup>().alpha;
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            FindObjectOfType<AudioManager>().PlaySound("Collectible");
            Destroy(gameObject);

            panel.SetActive(true);
        }
    }

    IEnumerator AdjustPanel()
    {

        yield return new WaitForSeconds(timeDelay);
    }
}
