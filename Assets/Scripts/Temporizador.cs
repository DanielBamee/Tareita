using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Temporizador : MonoBehaviour
{
    public float cronometro;
    public GameObject playButton;
    public bool contando = true;
    public GameObject pausaButton;
    public bool pausado = false;
    public GameObject detenerButton;
    public bool detenido = false;
    public TextMeshProUGUI textoCronometro;
    private int horas, minutos, segundos, microsegundos;

    // Start is called before the first frame update
    void Start()
    {
        cronometro = 0;
    }
    // Update is called once per frame
    void Update()
    {
        horas = (int)(cronometro / 3600f);
        minutos = (int)(cronometro / 60f);
        segundos = (int)(cronometro - horas * 60f);
        microsegundos = (int)((cronometro - (int)cronometro) * 100f);
        if (contando == true)
        {
            cronometro = cronometro + Time.deltaTime;
        }

        if (detenido == true)
        {
            cronometro = 0;
        }
        textoCronometro.text = (horas +":"+ minutos + ":" + segundos + ":" + microsegundos.ToString());
    }
    public void playAction()
    {
        pausado = false;
        detenido = false;
        contando = true;
    }
    public void pauseAction()
    {
        contando = false;
        pausado = true;
        detenido = false;
    }
    public void detenerAction()
    {
        pausado = false;
        contando = false;
        detenido = true;
    }
}
