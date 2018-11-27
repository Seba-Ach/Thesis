using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerAttributes: MonoBehaviour {

    [SerializeField] float maxHP = 100f;
    [SerializeField] float maxMana = 500f;
    public static float currentHP = 100f;
    public static float currentMana = 500f;
    public GameObject deathScreen;
    public GameObject ourPlayer;


    void Start()
    {
        ourPlayer.SetActive(true);
        deathScreen.SetActive(false);
    }

    void Update()
    {
        if (currentHP < 100 && currentHP > 0)
        {
            currentHP = currentHP + (2 * Time.deltaTime);
        }

        if (currentMana < 100 && currentMana > 0)
        {
            currentMana = currentMana + (15 * Time.deltaTime);
        }

        if (currentHP < 0)
        {
            currentHP = 0;
        }

        if (currentMana < 0)
        {
            currentMana = 0;
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        if(currentHP == 0)
        {
            ourPlayer.SetActive(false);
            deathScreen.SetActive(true);
            Invoke("deathReloadLevel",5);
        }
    }

    public void deathReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        deathScreen.SetActive(false);
        ourPlayer.SetActive(true);
        currentHP = maxHP;
        currentMana = maxMana;
    }

    public float getHPPercent
    {
        get
        {
            return currentHP / maxHP;
        }
    }

    public float getManaPercent
    {
        get
        {
            return currentMana / maxMana;
        }
    }
}
