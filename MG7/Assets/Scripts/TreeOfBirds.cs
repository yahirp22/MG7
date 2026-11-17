using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!


public class TreeSparrowController : MonoBehaviour
{
    [SerializeField] private GameObject[] sparrows;
    [SerializeField] private GameObject player = GameObject.Find("Colobus");
    [SerializeField] private float interactionDistance = 5f;
private void Start()
    {
        player = GameObject.Find("Colobus");
    }
    private void Update()
    {
        if (player == null)
            return;

        foreach (GameObject sparrow in sparrows)
        {
            if (sparrow == null)
                continue;

            if (Vector3.Distance(player.transform.position, sparrow.transform.position) < interactionDistance)
            {
                Debug.Log("Interacting with sparrow: " + sparrow.name);
                sparrow.SetActive(true);
            }
            else 
            {
                sparrow.SetActive(false);
            }
        }
    }
}