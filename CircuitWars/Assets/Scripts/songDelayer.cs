using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class songDelayer : MonoBehaviour
{
    [SerializeField] GameObject song;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(ExecuteAfterTime(3.1f));
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        song.SetActive(true);
        // Code to execute after the delay
    }
}
