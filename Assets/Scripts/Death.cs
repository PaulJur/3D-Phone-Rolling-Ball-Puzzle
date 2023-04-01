using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    [SerializeField]
    private GameObject _respawnPoint;
    [SerializeField]
    private GameObject _player;
    public bool playerRespawned=false;
  

    private void OnTriggerEnter(Collider other)
    {
        //If player collides with GameObject collider it will respawn at set respawn point.
        _player.transform.position=_respawnPoint.transform.position;
        playerRespawned=true;
    }
    private void FixedUpdate()
    {   //Once the player dies the whole scene resets.
        if (playerRespawned == true) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            playerRespawned = false;
        }
    }
}
