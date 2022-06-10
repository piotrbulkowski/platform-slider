using Assets.Scripts;
using System.Collections;
using TMPro;
using UnityEngine;

public class CountdownDelayStart : MonoBehaviour
{
    public int countdownTime;
    public TextMeshProUGUI countdownTextComponent;

    private void Start()
    {
        StartCoroutine(CountdownToStart());
    }
    IEnumerator CountdownToStart()
    {
        while(countdownTime > 0)
        {
            countdownTextComponent.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f);
            countdownTime--;
        }

        countdownTextComponent.text = "GO!";

        GameManager.Instance.Begin();

        yield return new WaitForSeconds(1f);
        countdownTextComponent.gameObject.SetActive(false);
    }
}
