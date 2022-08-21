using System.Drawing;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bruja : MonoBehaviour
{
    private SoundManager sound;
    private PlayerController player;
    public float rangoDeVision;
    public LayerMask capaDelGato;
    bool estarAlerta;
    public Transform gato;
    public float velocidad;
    public Material[] Expresions;
    private MeshRenderer mesh;
    public Transform BrujaDefaul;
    public float RapidezRango;

    bool x;
    void Start()
    {
        sound = FindObjectOfType<SoundManager>();
        player = FindObjectOfType<PlayerController>();
        mesh = GetComponent<MeshRenderer>();
        mesh.material = Expresions[0];
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
        player.Expresion3();
        StartCoroutine(DelayAnim());
         
        }
       
    }

    private void OnDrawGizmos() {
        Gizmos.DrawWireSphere(transform.position,rangoDeVision);
        
    }

    IEnumerator DelayAnim()
    {
        if (x == false) sound.Gasp();
        x = true;
        yield return new WaitForSeconds(3);
        transform.LookAt(new Vector3(BrujaDefaul.position.x, BrujaDefaul.position.y, BrujaDefaul.position.z));
        PlayerStats.Vida--;
        mesh.material = Expresions[0];
        x = false;
    }

    void AumentoRangoVision()
    {
        if(player.WalkIncrease > RapidezRango*1)
        {
            rangoDeVision = 0.3f;
            mesh.material =Expresions[0];

        }
        if (player.WalkIncrease > RapidezRango * 1.5)
        {
            rangoDeVision = 0.6f;
            mesh.material = Expresions[1];

        }
        if (player.WalkIncrease > RapidezRango * 2)
        {
            rangoDeVision = 0.9f;
            mesh.material = Expresions[2];

        }
        if (player.WalkIncrease > RapidezRango * 2.5)
        {
            rangoDeVision = 1.2f;
            mesh.material = Expresions[3];

        }
        if (player.WalkIncrease > RapidezRango * 3)
        {
            rangoDeVision = 1.5f;
            mesh.material = Expresions[4];

        }
        if (player.WalkIncrease > RapidezRango * 3.5)
        {
            rangoDeVision = 1.8f;
            mesh.material = Expresions[5];
        }
        if (player.WalkIncrease > RapidezRango * 4)
        {
            rangoDeVision = 5f;
            mesh.material = Expresions[6];
        }

    }

    
    }
