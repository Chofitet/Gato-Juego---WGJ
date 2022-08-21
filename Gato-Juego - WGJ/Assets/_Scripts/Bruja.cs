using System.Drawing;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bruja : MonoBehaviour
{
    private PlayerController player;
    public float rangoDeVision;
    public LayerMask capaDelGato;
    bool estarAlerta;
    public Transform gato;
    public float velocidad;
    bool EnAnim;

    public Transform BrujaDefaul;
    void Start()
    {
       player = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        AumentoRangoVision();

       estarAlerta = Physics.CheckSphere(transform.position,rangoDeVision,capaDelGato);

       if(estarAlerta == true)
       {
        //transform.LookAt(gato);
        transform.LookAt(new Vector3(gato.position.x,transform.position.y,gato.position.z));
        rangoDeVision = 0;
        player.WalkIncrease = 0;

                StartCoroutine(DelayAnim());
                EnAnim = true;
         
        }
       
    }

    private void OnDrawGizmos() {
        Gizmos.DrawWireSphere(transform.position,rangoDeVision);
        
    }

    IEnumerator DelayAnim()
    {

        yield return new WaitForSeconds(3);
        transform.LookAt(new Vector3(BrujaDefaul.position.x, BrujaDefaul.position.y, BrujaDefaul.position.z));
        PlayerStats.Vida--;
    
    }

    void AumentoRangoVision()
    {
        if(player.WalkIncrease > 5)
        {
            rangoDeVision = 0.5f;

        }
        if (player.WalkIncrease > 10)
        {
            rangoDeVision = 1;

        }
        if (player.WalkIncrease > 20)
        {
            rangoDeVision = 1.5f;

        }
        if (player.WalkIncrease > 25)
        {
            rangoDeVision = 2;

        }
        if (player.WalkIncrease > 30)
        {
            rangoDeVision = 2.5f;

        }
        if (player.WalkIncrease > 35)
        {
            rangoDeVision = 3;
        }
        if (player.WalkIncrease > 40)
        {
            rangoDeVision = 4;
        }

    }

    
    }
