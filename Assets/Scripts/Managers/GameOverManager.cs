using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public Text warningText;
    public PlayerHealth playerHealth;

    public float restartDelay = 5f;

    Animator anim;
    float restartTimer;

    bool isGameOver;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
            restartTimer += Time.deltaTime;

            if (restartTimer >= restartDelay)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

        if(playerHealth.currentHealth <= 0 && !isGameOver)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        anim.SetTrigger("GameOver");
        isGameOver = true;
    }

    public void ShowWarning(float enemyDistance)
    {
        warningText.text = string.Format("! {0} m", Mathf.RoundToInt(enemyDistance));

        anim.SetTrigger("Warning");
    }
}