using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class LixoSapawner : MonoBehaviour
{
    public float maximumX;
    public float fixedY;
    public float fixedZ;
    public float timer;
    public GameObject Lixo;
    public float MaxPoints;
    public float points = 0;
    public TMP_Text pointsText;
    public TMP_Text victoryText;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoutine());
        victoryText.gameObject.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
       
    }
    IEnumerator SpawnRoutine()
    {
        while (points < MaxPoints)
        {
            Instantiate(Lixo, new Vector3(Random.Range(-maximumX, maximumX=1), fixedY, fixedZ), Quaternion.identity);
            yield return new WaitForSeconds(timer);
        }
        victoryText.gameObject.SetActive(true);
    }

    public void AddToPoints(int value){
        points+=value;
        pointsText.text= "Points: "+points.ToString();
    }
}



