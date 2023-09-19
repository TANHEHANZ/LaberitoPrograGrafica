using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GanarPuntos : MonoBehaviour
{
    // Start is called before the first frame update
    public bool player1Ponts;
    public GameObject gameManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Tesoro"))
        {
            if (player1Ponts)
            {
                gameManager.GetComponent<GameManager>().player1Socored();


            }
            else
            {
                gameManager.GetComponent<GameManager>().player2Socored();

            }
        }
    }
}
