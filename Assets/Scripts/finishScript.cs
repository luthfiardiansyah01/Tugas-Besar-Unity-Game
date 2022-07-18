using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class finishScript : MonoBehaviour
{
    public Text textOB;
    public GameObject Activator;
    public string finishText = "Finish Text";

    public float timer = 2f;

    void Start()
    {
        textOB.GetComponent<Text>().enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            textOB.GetComponent<Text>().enabled = true;
            textOB.text = finishText.ToString();
            StartCoroutine(DisableText());
        }
    }

    IEnumerator DisableText()
    {
        yield return new WaitForSeconds(timer);
        textOB.GetComponent<Text>().enabled = false;
        Destroy(Activator);
        SceneManager.LoadScene(0);
    }
}
