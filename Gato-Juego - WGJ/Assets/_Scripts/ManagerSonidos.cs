using UnityEngine;

public class ManagerSonidos : MonoBehaviour
{
    public static ManagerSonidos unicaInstancia;

    AudioSource _audSource;

    void Awake()
    {
        if(ManagerSonidos.unicaInstancia == null)
        {

            DontDestroyOnLoad(gameObject);

            _audSource = GetComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }

        
    }

    
    void Update()
    {
        
    }

    public static void Pausar()
    {
        unicaInstancia._audSource.Pause();
    }

    public static void Despausar()
    {
        unicaInstancia._audSource.UnPause();
    }
}
