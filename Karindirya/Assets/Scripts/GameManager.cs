using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    
    [System.Serializable]
    public class IngredientType
    {
        public string name;
        public bool isCollected;
    }

    public IngredientType[] requiredIngredients;
    private int collectedCount = 0;

    void Awake()
    {
        // Singleton pattern
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CollectIngredient(string ingredientName)
    {
        for (int i = 0; i < requiredIngredients.Length; i++)
        {
            if (requiredIngredients[i].name == ingredientName && !requiredIngredients[i].isCollected)
            {
                requiredIngredients[i].isCollected = true;
                collectedCount++;
                Debug.Log($"Collected {ingredientName}! ({collectedCount}/{requiredIngredients.Length})");
                
                // Check if all ingredients are collected
                CheckWinCondition();
                break;
            }
        }
    }

    private void CheckWinCondition()
    {
        if (collectedCount >= requiredIngredients.Length)
        {
            Debug.Log("Congratulations! All ingredients collected!");
            // You can add your win condition logic here
            // For example, load a win scene or show a victory panel
            // SceneManager.LoadScene("WinScene");
        }
    }

    public bool IsIngredientCollected(string ingredientName)
    {
        foreach (var ingredient in requiredIngredients)
        {
            if (ingredient.name == ingredientName)
            {
                return ingredient.isCollected;
            }
        }
        return false;
    }

    public string GetProgressText()
    {
        return $"Ingredients: {collectedCount}/{requiredIngredients.Length}";
    }
}
