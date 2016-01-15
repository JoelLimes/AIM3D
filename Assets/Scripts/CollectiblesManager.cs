using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CollectiblesManager : MonoBehaviour
{
    Animator basedoor;
    public Text countText;
    public Text timerText;
    private int count;
    private int nrOfTotalCollectables;
    private int nrOfCollectedItems;
    [SerializeField]private int TotalCollectibles;
    private float theTimer = 0;
    [SerializeField]private float theStartTime = 120;
    private bool StartCountdown = false;

    void Start()
    {
        theTimer = theStartTime;
        GameObject[] collectables = GameObject.FindGameObjectsWithTag("Collectable");
        nrOfTotalCollectables = collectables.Length;
        nrOfCollectedItems = 0;
        Debug.Log(nrOfTotalCollectables);
        count = 0;
        UpdateUI();
        basedoor = GetComponent<Animator>();
    }
    void Update() 
    {
        if (StartCountdown == true)
        {
            theTimer -=Time.deltaTime;
            Debug.Log("startcount");
        }
        if(theTimer <= 0)
        {
            //insertDeathThingy
            Debug.Log("heeyoo you died");
        }
        if (count == 1)
        {
            StartCountdown = true;
            timerText.text = "Time Left: " + theTimer.ToString();
        }
    }
    public void AddCollectable()
    {
        nrOfCollectedItems++;
        Debug.Log("You have " + nrOfCollectedItems + " of the " + nrOfTotalCollectables);
        count = count + 1;
        UpdateUI();

    }
    void UpdateUI()
    {
        countText.text = "Score:" + count.ToString();
        
        StartCoroutine(WaitForNext());
    }

    IEnumerator WaitForNext()
    {
        if (count == nrOfTotalCollectables)
            {
                basedoor.Play("up");
                yield return new WaitForSeconds(3);
               
            }
    }

}