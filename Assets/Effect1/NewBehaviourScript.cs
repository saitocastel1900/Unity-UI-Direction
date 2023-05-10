using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particle;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
            SceneManager.LoadScene("SampleScene02");
        
        _particle.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,10f));
    }
}
