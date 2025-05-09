using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public int targetScore;

    private void OnCollisionEnter(Collision collision)
    {
        GameManger.Score += targetScore;
        Destroy(gameObject);
    }

    public void Reposition()
    {
        float randomx = Random.Range(-4, 4);
        float randomy = Random.Range(1, 3);

        Vector3 repos = transform.position;
        repos.x= randomx;
        repos.y= randomy;

        transform.position= repos;
    }

}
